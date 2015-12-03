using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace yuni_mail_viewer
{
    public partial class Form1 : Form
    {
        [DllImport("yuni_mail_viewer_compornent.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static IntPtr connect_server(string mail_address, string password);

        [DllImport("yuni_mail_viewer_compornent.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static int get_subject_quantity(IntPtr handle);

        [DllImport("yuni_mail_viewer_compornent.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static void get_subject(IntPtr handle, StringBuilder subject, int index);

        [DllImport("yuni_mail_viewer_compornent.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static void get_content(IntPtr handle, StringBuilder content, int content_index);

        [DllImport("yuni_mail_viewer_compornent.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static void finish(IntPtr handle);


        public void connect_to_server(string mail_address, string password)
        {
            this.mail_address = mail_address;
            this.password = password;
            mail_address_label.Text = mail_address;

            handle = connect_server(mail_address, password);
            if(handle == (IntPtr)0)
            {
                MessageBox.Show("サーバーに接続できませんでした");
                return;
            }

            int subject_quantity = get_subject_quantity(handle);
            mail_list.BeginUpdate();
            for (int index = 0; index < subject_quantity; ++index)
            {
                StringBuilder buffer = new StringBuilder(1024);
                get_subject(handle, buffer, index);
                mail_list.Items.Add(buffer.ToString());
            }
            mail_list.EndUpdate();

            update_UI_ifneed_async();
        }


        public Form1()
        {
            InitializeComponent();
            shown_index = -1;
        }

        public void destruct()
        {
            finish(handle);
        }









        private string mail_address;
        private string password;
        private IntPtr handle;
        private int shown_index;

        private string get_content_html(string basic_content)
        {
            // todo
            return "";
        }

        private void output_file(string file_path, string content_html)
        {
            StreamWriter writer = new StreamWriter(file_path, false, Encoding.ASCII);
            writer.Write(content_html);
            writer.Close();
        }

        private string get_full_path(string related_path)
        {
            return Path.GetFullPath(related_path);
        }

        private async void update_UI_ifneed_async()
        {
            await Task.Run(() =>
            {
                while(true)
                {
                    Thread.Sleep(33);
                    int selected_index = mail_list.SelectedIndex;
                    if (shown_index == selected_index)
                    {
                        continue;
                    }

                    StringBuilder buffer = new StringBuilder(65536);
                    get_content(handle, buffer, selected_index);
                    string content_html = get_content_html(buffer.ToString());
                    string file_path = "data/" + selected_index + ".html";
                    output_file(file_path, content_html);

                    subject_box.Text = mail_list.Items[selected_index].ToString();
                    web_browser.Navigate(get_full_path(file_path));
                    shown_index = selected_index;
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nothing
        }
    }
}
