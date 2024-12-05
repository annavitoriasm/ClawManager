using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClawManager
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Alert_Load(object sender, EventArgs e)
        {

        }

        private void CustomAlert(string title, string description, Action buttonConfirm, Action buttonCancel)
        {
            lbPlace1.Text = title;
            lbPlace2.Text = description;
            ShowDialog();

            button1.Click += (sender, e) =>
            {
                buttonConfirm();
                this.Close();
            };

            button2.Click += (sender, e) =>
            {
                buttonCancel();
                this.Close();
            };

            
        }

        private void lbPlace1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
