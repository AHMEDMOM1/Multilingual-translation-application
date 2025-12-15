using Multilingual_translation_application.Services;
using Multilingual_translation_application.Services.Translation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Services.Translation;

namespace Multilingual_translation_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly ITranslationService _translationService = new TranslationService();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFrom.Items.AddRange(new[] { "English", "Turkish", "Arabic" });
            cmbTo.Items.AddRange(new[] { "English", "Turkish", "Arabic" });

            cmbFrom.SelectedIndex = 0;
            cmbTo.SelectedIndex = 1;

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTranslate_Click_1(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string from = cmbFrom.SelectedItem.ToString();
            string to = cmbTo.SelectedItem.ToString();

            txtOutput.Text = _translationService.Translate(input, from, to);
        }

    }
}
