using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Mot_Chut
{
    public partial class FormBegin : Form
    {
        public FormBegin()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            FormLogIn form2 = new FormLogIn();
            form2.ShowDialog();
        }
    }
}
