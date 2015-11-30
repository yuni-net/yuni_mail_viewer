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

namespace yuni_mail_viewer
{
    public partial class Form1 : Form
    {
        [DllImport("yuni_mail_viewer_compornent.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static IntPtr connect(string mail_address, string password);

        [DllImport("yuni_mail_viewer_compornent.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static int get_subject_quantity(IntPtr handle);

        [DllImport("yuni_mail_viewer_compornent.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static void get_subject(IntPtr handle, StringBuilder subjects, int index);

        [DllImport("yuni_mail_viewer_compornent.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static void get_content(IntPtr handle, int content_index);

        [DllImport("yuni_mail_viewer_compornent.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static void finish(IntPtr handle);




        public void connect_to_server(string mail_address, string password)
        {
            this.mail_address = mail_address;
            this.password = password;
            mail_address_label.Text = mail_address;

            handle = connect(mail_address, password);
            if(handle == (IntPtr)0)
            {
                MessageBox.Show("サーバーに接続できませんでした");
                return;
            }

            int subject_quantity = get_subject_quantity(handle);
            mail_list.BeginUpdate();
            for (int index = 0; index < subject_quantity; ++index)
            {
                StringBuilder buffer = new StringBuilder(65536);
                get_subject(handle, buffer, index);
                mail_list.Items.Add(buffer.ToString());
            }
            mail_list.EndUpdate();
        }


        public Form1()
        {
            InitializeComponent();
        }




        public void destruct()
        {
            finish(handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private string mail_address;
        private string password;
        private IntPtr handle;
    }
}
