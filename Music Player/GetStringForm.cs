using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class GetStringForm : Form
    {
        private string[] result;
        public GetStringForm(string message, ref string[] original)
        {
            result = original;
            InitializeComponent();
            initialize(message);
        }
        private void initialize(string message)
        {
            label.Text = message;
            textBox.Text = result[0];
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            result[0] = textBox.Text;
            this.Close();
        }
    }
}
