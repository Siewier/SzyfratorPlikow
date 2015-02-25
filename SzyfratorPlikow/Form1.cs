using System;
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
                tbDocSz.Text = plikZrSz + ".sejf";
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
                tbZrodloDe.Text = plikZrDe;
                //char[] MyChar = { '.', 's', 'e', 'j', 'f'};
                //string tempText = plikZrDe.TrimEnd(MyChar);
                string tempText = plikZrDe.Remove(plikZrDe.Length - 5, 5);
                tbDocDe.Text = tempText;
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

        private void btPokazZnakiSz_CheckedChanged(object sender, EventArgs e)
        {
            if (btPokazZnakiSz.Checked == true)
            {
                tbHasloSz.UseSystemPasswordChar = false;
            }
            else
            {
                tbHasloSz.UseSystemPasswordChar = true;
            }
        }

        private void cbPokazZnakiDe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPokazZnakiDe.Checked == true)
            {
                tbHasloDe.UseSystemPasswordChar = false;
            }
            else
            {
                tbHasloDe.UseSystemPasswordChar = true;
            }
        }

        private void buttonDeSz_Click(object sender, EventArgs e)
        {
            string haslo = tbHasloDe.Text;
            plikZrDe = tbZrodloDe.Text;
            plikDocDe = tbDocDe.Text;
            Encryptor szyfrator = new Encryptor();
            bool wynik = szyfrator.DecryptFile(plikZrDe, plikDocDe, haslo);
            tbHasloDe.Text = "";
        }

        private void buttonSz_Click(object sender, EventArgs e)
        {
            string haslo = tbHasloSz.Text;
            plikZrSz = tbZrodloSz.Text;
            plikDocSz = tbDocSz.Text;
            Encryptor szyfrator = new Encryptor();
            bool wynik = szyfrator.EncryptFile(plikZrSz, plikDocSz, haslo);
            tbHasloSz.Text = "";
        }
    }
}
