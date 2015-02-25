using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

//http://stackoverflow.com/questions/6460793/using-rijndael-to-encrypt-decrypt-files

namespace SzyfratorPlikow
{
    public class Encryptor
    {
        public bool EncryptFile(string inputFile, string outputFile, string key)
        {
            bool result = true;
            try
            {
                byte[] keyBytes;
                keyBytes = Encoding.Unicode.GetBytes(key);

                Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes);

                RijndaelManaged rijndaelCSP = new RijndaelManaged();
                rijndaelCSP.Key = derivedKey.GetBytes(rijndaelCSP.KeySize / 8);
                rijndaelCSP.IV = derivedKey.GetBytes(rijndaelCSP.BlockSize / 8);
                //rijndaelCSP.Padding = PaddingMode.ANSIX923;
                rijndaelCSP.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = rijndaelCSP.CreateEncryptor();

                FileStream inputFileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);

                byte[] inputFileData = new byte[(int)inputFileStream.Length];
                inputFileStream.Read(inputFileData, 0, (int)inputFileStream.Length);

                FileStream outputFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);

                CryptoStream encryptStream = new CryptoStream(outputFileStream, encryptor, CryptoStreamMode.Write);
                encryptStream.Write(inputFileData, 0, (int)inputFileStream.Length);
                encryptStream.FlushFinalBlock();

                rijndaelCSP.Clear();
                encryptStream.Close();
                inputFileStream.Close();
                outputFileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Szyfrowanie nieudane!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            MessageBox.Show("Szyfrowanie zakończone!");
            return result;
        }

        public bool DecryptFile(string inputFile, string outputFile, string key)
        {
            bool result = true;
            try
            {
                byte[] keyBytes = Encoding.Unicode.GetBytes(key);

                Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes);

                RijndaelManaged rijndaelCSP = new RijndaelManaged();
                rijndaelCSP.Key = derivedKey.GetBytes(rijndaelCSP.KeySize / 8);
                rijndaelCSP.IV = derivedKey.GetBytes(rijndaelCSP.BlockSize / 8);
                //rijndaelCSP.Padding = PaddingMode.ANSIX923;
                rijndaelCSP.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = rijndaelCSP.CreateDecryptor();

                FileStream inputFileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);

                CryptoStream decryptStream = new CryptoStream(inputFileStream, decryptor, CryptoStreamMode.Read);

                byte[] inputFileData = new byte[(int)inputFileStream.Length];
                decryptStream.Read(inputFileData, 0, (int)inputFileStream.Length);

                FileStream outputFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
                outputFileStream.Write(inputFileData, 0, inputFileData.Length);

                //int decrypt_length = decryptStream.Read(inputFileData, 0, (int)inputFileStream.Length);
                //FileStream outputFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
                //outputFileStream.Write(inputFileData, 0, decrypt_length);

                outputFileStream.Flush();

                rijndaelCSP.Clear();

                decryptStream.Close();
                inputFileStream.Close();
                outputFileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deszyfrowanie nieudane!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            MessageBox.Show("Deszyfrowanie zakończone!");
            return result;
        }
    }
}
