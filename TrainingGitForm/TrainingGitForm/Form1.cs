using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingGitForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text.ToUpper() == "PELLE PLUTT")
            {
                btn1.Text = "Tog ett skutt";
            }
            else
            {
                btn1.Text = "Pelle Plutt";
            }
            
        }
    }
}
