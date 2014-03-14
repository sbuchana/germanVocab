using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vocabText.Text = "";
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            vocabText.Text = textBoxInput.Text;
            textBoxInput.Text = "";
        }

        private void uUmlautButton_Click(object sender, EventArgs e)
        {
            textBoxInput.AppendText("ü");
            textBoxInput.Focus();
        }

        private void oUmlautButton_Click(object sender, EventArgs e)
        {
            textBoxInput.AppendText("ö");
            textBoxInput.Focus();
        }

        private void aUmlautButton_Click(object sender, EventArgs e)
        {
            textBoxInput.AppendText("ä");
            textBoxInput.Focus();
        }

        private void eszettButton_Click(object sender, EventArgs e)
        {
            textBoxInput.AppendText("ß");
            textBoxInput.Focus();
        }

        private void uCapUmlautButton_Click(object sender, EventArgs e)
        {
            textBoxInput.AppendText("Ü");
            textBoxInput.Focus();
        }

        private void oCapUmlautButton_Click(object sender, EventArgs e)
        {
            textBoxInput.AppendText("Ö");
            textBoxInput.Focus();
        }

        private void aCapUmlautButton_Click(object sender, EventArgs e)
        {
            textBoxInput.AppendText("Ä");
            textBoxInput.Focus();
        }

    }
}
