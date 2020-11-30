using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TripleDES
{
    public partial class frm_TripleDES : Form
    {
        DESnTripleDES crypto = new DESnTripleDES();
        public frm_TripleDES()
        {
            InitializeComponent();
            grp_Main.Show();
            grp_MainDecryption.Hide();
            grp_MainEncryption.Hide();
        }

        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };
        //public static string StringToBinary(string data)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (char c in data.ToCharArray())
        //    {
        //        sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
        //    }
        //    return sb.ToString();
        //}
 
        private void btn_TDESEncrypt_Click(object sender, EventArgs e)
        {
            txt_TDESEncryptOutput.Text = DESnTripleDES.TripleDesEncryption(txt_TDESEncryptMsg.Text, txt_TDESEncryptKey.Text);
        }

        private void btn_TDESDecrypt_Click(object sender, EventArgs e)
        {
            txt_TDESDecryptOutput.Text = DESnTripleDES.TripleDesDecryption(txt_TDESDecryptMsg.Text, txt_TDESDecryptKey.Text);
        }

        private void txt_TDESEncryptKey_Leave(object sender, EventArgs e)
        {
            if (txt_TDESEncryptKey.Text.Length != 16)
            {
                MessageBox.Show("Triple DES key should be equal to 128 bit or 16 characters");
                txt_TDESEncryptKey.Text = "";
            }
        }

        private void txt_TDESDecryptKey_Leave(object sender, EventArgs e)
        {
            if (txt_TDESDecryptKey.Text.Length != 16)
            {
                MessageBox.Show("Triple DES key should be equal to 128 bit or 16 characters");
                txt_TDESDecryptKey.Text = "";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_TDESEncryptKey.Text = "";
            txt_TDESEncryptMsg.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_TDESDecryptMsg.Text = "";
            txt_TDESDecryptKey.Text = "";
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image FIle (*.png, *.jpg, *.bmp | *.png; *.jpg; *.bmp";
            openDialog.InitialDirectory = @"E:\Project\CrpytoStegano\Images";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(textBoxFilePath.Text);
            string text = textBoxMessage.Text;

            Bitmap output = new Bitmap(bmp);
            output = Steganogarphy_Encode(output, text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image FIle (*.bmp) | *.bmp";
            saveFile.InitialDirectory = @"E:\Project\CrpytoStegano\Images";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                output.Save(textBoxFilePath.Text);
            }
        }

        public static Bitmap Steganogarphy_Encode(Bitmap bmp, string text)
        {
            State state = State.Hiding;

            int charIndex = 0;
            int charValue = 0;
            long pixelElementIndex = 0;
            int zeros = 0;
            int R = 0, G = 0, B = 0;

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    for (int n = 0; n < 3; n++)
                    {
                        if (pixelElementIndex % 8 == 0)
                        {
                            if (state == State.Filling_With_Zeros && zeros == 8)
                            {
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                return bmp;
                            }
                            if (charIndex >= text.Length)
                            {
                                state = State.Filling_With_Zeros;
                            }
                            else
                            {
                                charValue = text[charIndex++];
                            }
                        }
                        switch (pixelElementIndex % 3)
                        {
                            case 0:
                                {
                                    if (state == State.Hiding)
                                    {
                                        R += charValue % 2;
                                        charValue /= 2;
                                    }
                                } break;
                            case 1:
                                {
                                    if (state == State.Hiding)
                                    {
                                        G += charValue % 2;
                                        charValue /= 2;
                                    }
                                } break;
                            case 2:
                                {
                                    if (state == State.Hiding)
                                    {
                                        B += charValue % 2;
                                        charValue /= 2;
                                    }
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                } break;
                        }
                        pixelElementIndex++;
                        if (state == State.Filling_With_Zeros)
                        {
                            zeros++;
                        }
                    }
                }
            }
            return bmp;
        }

        private void buttonOpenFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image FIle (*.bmp) | *.bmp";
            openDialog.InitialDirectory = @"E:\Project\CrpytoStegano\Images";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath1.Text = openDialog.FileName.ToString();
                pictureBox2.ImageLocation = textBoxFilePath1.Text;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxFilePath1.Text);
            string message = Steganography_Decode(img);

            textBoxMessage1.Text = message;
        }

        public static string Steganography_Decode(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            string extractedText = String.Empty;

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    charValue = charValue * 2 + pixel.R % 2;
                                } break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                } break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                } break;
                        }
                        colorUnitIndex++;
                        if (colorUnitIndex % 8 == 0)
                        {
                            charValue = reverseBits(charValue);

                            if (charValue == 0)
                            {
                                return extractedText;
                            }
                            char c = (char)charValue;
                            extractedText += c.ToString();
                        }
                    }
                }
            }
            return extractedText;
        }

        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;
                n /= 2;
            }
            return result;
        }

        private void btn_CopyEncryption_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = txt_TDESEncryptOutput.Text;
        }

        private void btn_CopyDecryption_Click(object sender, EventArgs e)
        {
            txt_TDESDecryptMsg.Text = textBoxMessage1.Text;
        }

        private void btn_EncryptionMain_Click(object sender, EventArgs e)
        {
            ResetAll();
            grp_Main.Hide();
            grp_MainDecryption.Hide();
            grp_MainEncryption.Show();
        }

        private void btn_DecryptionMain_Click(object sender, EventArgs e)
        {
            ResetAll();
            grp_Main.Hide();
            grp_MainDecryption.Show();
            grp_MainEncryption.Hide();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            ResetAll();
            grp_Main.Show();
            grp_MainDecryption.Hide();
            grp_MainEncryption.Hide();
        }

        public void ResetAll()
        {
            txt_TDESDecryptKey.Text = null;
            txt_TDESDecryptMsg.Text = null;
            txt_TDESDecryptOutput.Text = null;
            txt_TDESEncryptKey.Text = null;
            txt_TDESEncryptMsg.Text = null;
            txt_TDESEncryptOutput.Text = null;
            textBoxFilePath.Text = null;
            textBoxFilePath1.Text = null;
            textBoxMessage.Text = null;
            textBoxMessage1.Text = null;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }
    }
}
