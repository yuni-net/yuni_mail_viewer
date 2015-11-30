using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuni_mail_viewer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void on_click_login(object sender, EventArgs e)
        {
            if(isnt_it_mail_address(mail_address_box.Text))
            {
                // todo
            }
            // todo
        }
    }
}
