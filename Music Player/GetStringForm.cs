using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
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

            FormClosing += (sender, e) =>
            {
                if (CheckEmpty())
                    e.Cancel = true;

                SetResult();
            };
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
            if (CheckEmpty())
                return;
            this.Close();
        }

        private void SetResult()
        {
            result[0] = textBox.Text;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmButton_Click(sender, e);
            }
        }

        private bool CheckEmpty()
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("You must enter something! Whitespace does not count!");
                return true;
            }
            return false;
        }
    }
}
