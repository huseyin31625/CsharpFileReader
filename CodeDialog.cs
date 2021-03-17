using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsharpFileReader
{
    public partial class CodeDialog : Form
    {
        public CodeDialog()
        {
            InitializeComponent();
        }
        private void ShowMessageDialog(string code,string filename)
        {
            textBox1.Text = code;
            this.Text = filename;
        }
        internal virtual void ShowCode(string code,string filename)
        {
            ShowMessageDialog(code,filename);
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
