using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzyfratorPlikow
{
    public partial class Form1 : Form
    {
        private string plikZrSz;
        private string plikZrDe;
        private string plikDocSz;
        private string plikDocDe;

        public Form1()
        {
            InitializeComponent();
        }

        private void btPrzeZrSz_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogSzZr.ShowDialog();
            if (result == DialogResult.OK)
            {
                plikZrSz = openFileDialogSzZr.FileName;
                tbZrodloSz.Text = plikZrSz;
            }
        }

        private void buttonPrzeDocSz_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialogSzDoc.ShowDialog();
            if (result == DialogResult.OK)
            {
                plikDocSz = saveFileDialogSzDoc.FileName;
                tbDocSz.Text = plikDocSz;
            }
        }

        private void buttonPrzeZrDe_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogDeZr.ShowDialog();
            if (result == DialogResult.OK)
            {
                plikZrDe = openFileDialogDeZr.FileName;
                tbZrodloSz.Text = plikZrDe;
            }
        }

        private void buttonPrzeDocDe_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialogDeDoc.ShowDialog();
            if (result == DialogResult.OK)
            {
                plikDocSz = saveFileDialogDeDoc.FileName;
                tbDocDe.Text = plikDocDe;
            }
        }
    }
}
