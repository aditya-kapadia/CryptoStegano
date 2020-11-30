namespace TripleDES
{
    partial class frm_TripleDES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_MainEncryption = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_CopyEncryption = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_TDESEncrypt = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_TDESEncryptOutput = new System.Windows.Forms.RichTextBox();
            this.txt_TDESEncryptMsg = new System.Windows.Forms.TextBox();
            this.lbl_TDESEncryptOutput = new System.Windows.Forms.Label();
            this.btn_TDESEncrypt = new System.Windows.Forms.Button();
            this.txt_TDESEncryptKey = new System.Windows.Forms.TextBox();
            this.lbl_TDESEncryptMsg = new System.Windows.Forms.Label();
            this.lbl_TDESEncryptKey = new System.Windows.Forms.Label();
            this.grp_TDESDecrypt = new System.Windows.Forms.GroupBox();
            this.btn_CopyDecryption = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_TDESDecryptOutput = new System.Windows.Forms.RichTextBox();
            this.txt_TDESDecryptMsg = new System.Windows.Forms.TextBox();
            this.lbl_TDESDecryptOutput = new System.Windows.Forms.Label();
            this.btn_TDESDecrypt = new System.Windows.Forms.Button();
            this.txt_TDESDecryptKey = new System.Windows.Forms.TextBox();
            this.lbl_TDESDecryptMsg = new System.Windows.Forms.Label();
            this.lbl_TDESDecryptKey = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.grp_MainDecryption = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMessage1 = new System.Windows.Forms.TextBox();
            this.textBoxFilePath1 = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonOpenFile1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grp_Main = new System.Windows.Forms.GroupBox();
            this.btn_DecryptionMain = new System.Windows.Forms.Button();
            this.btn_EncryptionMain = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.grp_MainEncryption.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_TDESEncrypt.SuspendLayout();
            this.grp_TDESDecrypt.SuspendLayout();
            this.grp_MainDecryption.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grp_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_MainEncryption
            // 
            this.grp_MainEncryption.Controls.Add(this.groupBox2);
            this.grp_MainEncryption.Controls.Add(this.grp_TDESEncrypt);
            this.grp_MainEncryption.Location = new System.Drawing.Point(7, 13);
            this.grp_MainEncryption.Name = "grp_MainEncryption";
            this.grp_MainEncryption.Size = new System.Drawing.Size(913, 274);
            this.grp_MainEncryption.TabIndex = 9;
            this.grp_MainEncryption.TabStop = false;
            this.grp_MainEncryption.Text = "Encryption";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_CopyEncryption);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxMessage);
            this.groupBox2.Controls.Add(this.textBoxFilePath);
            this.groupBox2.Controls.Add(this.buttonEncode);
            this.groupBox2.Controls.Add(this.buttonOpenFile);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(364, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encryption(Steganography)";
            // 
            // btn_CopyEncryption
            // 
            this.btn_CopyEncryption.Location = new System.Drawing.Point(498, 67);
            this.btn_CopyEncryption.Name = "btn_CopyEncryption";
            this.btn_CopyEncryption.Size = new System.Drawing.Size(45, 23);
            this.btn_CopyEncryption.TabIndex = 7;
            this.btn_CopyEncryption.Text = "Copy";
            this.btn_CopyEncryption.UseVisualStyleBackColor = true;
            this.btn_CopyEncryption.Click += new System.EventHandler(this.btn_CopyEncryption_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter message";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(392, 69);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(100, 20);
            this.textBoxMessage.TabIndex = 5;
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(392, 22);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilePath.TabIndex = 4;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(417, 151);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 2;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(299, 19);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 208);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grp_TDESEncrypt
            // 
            this.grp_TDESEncrypt.Controls.Add(this.button3);
            this.grp_TDESEncrypt.Controls.Add(this.txt_TDESEncryptOutput);
            this.grp_TDESEncrypt.Controls.Add(this.txt_TDESEncryptMsg);
            this.grp_TDESEncrypt.Controls.Add(this.lbl_TDESEncryptOutput);
            this.grp_TDESEncrypt.Controls.Add(this.btn_TDESEncrypt);
            this.grp_TDESEncrypt.Controls.Add(this.txt_TDESEncryptKey);
            this.grp_TDESEncrypt.Controls.Add(this.lbl_TDESEncryptMsg);
            this.grp_TDESEncrypt.Controls.Add(this.lbl_TDESEncryptKey);
            this.grp_TDESEncrypt.Location = new System.Drawing.Point(23, 23);
            this.grp_TDESEncrypt.Name = "grp_TDESEncrypt";
            this.grp_TDESEncrypt.Size = new System.Drawing.Size(320, 233);
            this.grp_TDESEncrypt.TabIndex = 0;
            this.grp_TDESEncrypt.TabStop = false;
            this.grp_TDESEncrypt.Text = "Encryption(Cryptography)";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_TDESEncryptOutput
            // 
            this.txt_TDESEncryptOutput.Location = new System.Drawing.Point(72, 151);
            this.txt_TDESEncryptOutput.Name = "txt_TDESEncryptOutput";
            this.txt_TDESEncryptOutput.ReadOnly = true;
            this.txt_TDESEncryptOutput.Size = new System.Drawing.Size(232, 49);
            this.txt_TDESEncryptOutput.TabIndex = 8;
            this.txt_TDESEncryptOutput.Text = "";
            // 
            // txt_TDESEncryptMsg
            // 
            this.txt_TDESEncryptMsg.Location = new System.Drawing.Point(72, 35);
            this.txt_TDESEncryptMsg.Name = "txt_TDESEncryptMsg";
            this.txt_TDESEncryptMsg.Size = new System.Drawing.Size(232, 20);
            this.txt_TDESEncryptMsg.TabIndex = 1;
            // 
            // lbl_TDESEncryptOutput
            // 
            this.lbl_TDESEncryptOutput.AutoSize = true;
            this.lbl_TDESEncryptOutput.Location = new System.Drawing.Point(-3, 174);
            this.lbl_TDESEncryptOutput.Name = "lbl_TDESEncryptOutput";
            this.lbl_TDESEncryptOutput.Size = new System.Drawing.Size(77, 13);
            this.lbl_TDESEncryptOutput.TabIndex = 6;
            this.lbl_TDESEncryptOutput.Text = "Encrypted msg";
            // 
            // btn_TDESEncrypt
            // 
            this.btn_TDESEncrypt.Location = new System.Drawing.Point(72, 114);
            this.btn_TDESEncrypt.Name = "btn_TDESEncrypt";
            this.btn_TDESEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_TDESEncrypt.TabIndex = 2;
            this.btn_TDESEncrypt.Text = "Encrypt";
            this.btn_TDESEncrypt.UseVisualStyleBackColor = true;
            this.btn_TDESEncrypt.Click += new System.EventHandler(this.btn_TDESEncrypt_Click);
            // 
            // txt_TDESEncryptKey
            // 
            this.txt_TDESEncryptKey.Location = new System.Drawing.Point(72, 72);
            this.txt_TDESEncryptKey.Name = "txt_TDESEncryptKey";
            this.txt_TDESEncryptKey.Size = new System.Drawing.Size(232, 20);
            this.txt_TDESEncryptKey.TabIndex = 5;
            this.txt_TDESEncryptKey.Leave += new System.EventHandler(this.txt_TDESEncryptKey_Leave);
            // 
            // lbl_TDESEncryptMsg
            // 
            this.lbl_TDESEncryptMsg.AutoSize = true;
            this.lbl_TDESEncryptMsg.Location = new System.Drawing.Point(6, 35);
            this.lbl_TDESEncryptMsg.Name = "lbl_TDESEncryptMsg";
            this.lbl_TDESEncryptMsg.Size = new System.Drawing.Size(64, 13);
            this.lbl_TDESEncryptMsg.TabIndex = 3;
            this.lbl_TDESEncryptMsg.Text = "Original msg";
            // 
            // lbl_TDESEncryptKey
            // 
            this.lbl_TDESEncryptKey.AutoSize = true;
            this.lbl_TDESEncryptKey.Location = new System.Drawing.Point(6, 72);
            this.lbl_TDESEncryptKey.Name = "lbl_TDESEncryptKey";
            this.lbl_TDESEncryptKey.Size = new System.Drawing.Size(58, 13);
            this.lbl_TDESEncryptKey.TabIndex = 4;
            this.lbl_TDESEncryptKey.Text = "Key (128b)";
            // 
            // grp_TDESDecrypt
            // 
            this.grp_TDESDecrypt.Controls.Add(this.btn_CopyDecryption);
            this.grp_TDESDecrypt.Controls.Add(this.button4);
            this.grp_TDESDecrypt.Controls.Add(this.txt_TDESDecryptOutput);
            this.grp_TDESDecrypt.Controls.Add(this.txt_TDESDecryptMsg);
            this.grp_TDESDecrypt.Controls.Add(this.lbl_TDESDecryptOutput);
            this.grp_TDESDecrypt.Controls.Add(this.btn_TDESDecrypt);
            this.grp_TDESDecrypt.Controls.Add(this.txt_TDESDecryptKey);
            this.grp_TDESDecrypt.Controls.Add(this.lbl_TDESDecryptMsg);
            this.grp_TDESDecrypt.Controls.Add(this.lbl_TDESDecryptKey);
            this.grp_TDESDecrypt.Location = new System.Drawing.Point(580, 19);
            this.grp_TDESDecrypt.Name = "grp_TDESDecrypt";
            this.grp_TDESDecrypt.Size = new System.Drawing.Size(320, 244);
            this.grp_TDESDecrypt.TabIndex = 1;
            this.grp_TDESDecrypt.TabStop = false;
            this.grp_TDESDecrypt.Text = "Decryption(Cryptography)";
            // 
            // btn_CopyDecryption
            // 
            this.btn_CopyDecryption.Location = new System.Drawing.Point(275, 33);
            this.btn_CopyDecryption.Name = "btn_CopyDecryption";
            this.btn_CopyDecryption.Size = new System.Drawing.Size(45, 23);
            this.btn_CopyDecryption.TabIndex = 10;
            this.btn_CopyDecryption.Text = "Copy";
            this.btn_CopyDecryption.UseVisualStyleBackColor = true;
            this.btn_CopyDecryption.Click += new System.EventHandler(this.btn_CopyDecryption_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_TDESDecryptOutput
            // 
            this.txt_TDESDecryptOutput.Location = new System.Drawing.Point(72, 151);
            this.txt_TDESDecryptOutput.Name = "txt_TDESDecryptOutput";
            this.txt_TDESDecryptOutput.ReadOnly = true;
            this.txt_TDESDecryptOutput.Size = new System.Drawing.Size(232, 49);
            this.txt_TDESDecryptOutput.TabIndex = 8;
            this.txt_TDESDecryptOutput.Text = "";
            // 
            // txt_TDESDecryptMsg
            // 
            this.txt_TDESDecryptMsg.Location = new System.Drawing.Point(72, 35);
            this.txt_TDESDecryptMsg.Name = "txt_TDESDecryptMsg";
            this.txt_TDESDecryptMsg.Size = new System.Drawing.Size(203, 20);
            this.txt_TDESDecryptMsg.TabIndex = 1;
            // 
            // lbl_TDESDecryptOutput
            // 
            this.lbl_TDESDecryptOutput.AutoSize = true;
            this.lbl_TDESDecryptOutput.Location = new System.Drawing.Point(6, 174);
            this.lbl_TDESDecryptOutput.Name = "lbl_TDESDecryptOutput";
            this.lbl_TDESDecryptOutput.Size = new System.Drawing.Size(64, 13);
            this.lbl_TDESDecryptOutput.TabIndex = 6;
            this.lbl_TDESDecryptOutput.Text = "Original msg";
            // 
            // btn_TDESDecrypt
            // 
            this.btn_TDESDecrypt.Location = new System.Drawing.Point(72, 114);
            this.btn_TDESDecrypt.Name = "btn_TDESDecrypt";
            this.btn_TDESDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_TDESDecrypt.TabIndex = 2;
            this.btn_TDESDecrypt.Text = "Decrypt";
            this.btn_TDESDecrypt.UseVisualStyleBackColor = true;
            this.btn_TDESDecrypt.Click += new System.EventHandler(this.btn_TDESDecrypt_Click);
            // 
            // txt_TDESDecryptKey
            // 
            this.txt_TDESDecryptKey.Location = new System.Drawing.Point(72, 61);
            this.txt_TDESDecryptKey.Name = "txt_TDESDecryptKey";
            this.txt_TDESDecryptKey.Size = new System.Drawing.Size(232, 20);
            this.txt_TDESDecryptKey.TabIndex = 5;
            this.txt_TDESDecryptKey.Leave += new System.EventHandler(this.txt_TDESDecryptKey_Leave);
            // 
            // lbl_TDESDecryptMsg
            // 
            this.lbl_TDESDecryptMsg.AutoSize = true;
            this.lbl_TDESDecryptMsg.Location = new System.Drawing.Point(-3, 35);
            this.lbl_TDESDecryptMsg.Name = "lbl_TDESDecryptMsg";
            this.lbl_TDESDecryptMsg.Size = new System.Drawing.Size(77, 13);
            this.lbl_TDESDecryptMsg.TabIndex = 3;
            this.lbl_TDESDecryptMsg.Text = "Encrypted msg";
            // 
            // lbl_TDESDecryptKey
            // 
            this.lbl_TDESDecryptKey.AutoSize = true;
            this.lbl_TDESDecryptKey.Location = new System.Drawing.Point(6, 72);
            this.lbl_TDESDecryptKey.Name = "lbl_TDESDecryptKey";
            this.lbl_TDESDecryptKey.Size = new System.Drawing.Size(58, 13);
            this.lbl_TDESDecryptKey.TabIndex = 4;
            this.lbl_TDESDecryptKey.Text = "Key (128b)";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(550, 293);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // grp_MainDecryption
            // 
            this.grp_MainDecryption.Controls.Add(this.groupBox3);
            this.grp_MainDecryption.Controls.Add(this.grp_TDESDecrypt);
            this.grp_MainDecryption.Location = new System.Drawing.Point(14, 8);
            this.grp_MainDecryption.Name = "grp_MainDecryption";
            this.grp_MainDecryption.Size = new System.Drawing.Size(906, 269);
            this.grp_MainDecryption.TabIndex = 11;
            this.grp_MainDecryption.TabStop = false;
            this.grp_MainDecryption.Text = "Decryption";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxMessage1);
            this.groupBox3.Controls.Add(this.textBoxFilePath1);
            this.groupBox3.Controls.Add(this.buttonDecode);
            this.groupBox3.Controls.Add(this.buttonOpenFile1);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(10, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Decryption(Steganography)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message :";
            // 
            // textBoxMessage1
            // 
            this.textBoxMessage1.Location = new System.Drawing.Point(411, 72);
            this.textBoxMessage1.Name = "textBoxMessage1";
            this.textBoxMessage1.Size = new System.Drawing.Size(100, 20);
            this.textBoxMessage1.TabIndex = 4;
            // 
            // textBoxFilePath1
            // 
            this.textBoxFilePath1.Location = new System.Drawing.Point(411, 22);
            this.textBoxFilePath1.Name = "textBoxFilePath1";
            this.textBoxFilePath1.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilePath1.TabIndex = 3;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(452, 202);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 2;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonOpenFile1
            // 
            this.buttonOpenFile1.Location = new System.Drawing.Point(304, 20);
            this.buttonOpenFile1.Name = "buttonOpenFile1";
            this.buttonOpenFile1.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile1.TabIndex = 1;
            this.buttonOpenFile1.Text = "Open File";
            this.buttonOpenFile1.UseVisualStyleBackColor = true;
            this.buttonOpenFile1.Click += new System.EventHandler(this.buttonOpenFile1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 218);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // grp_Main
            // 
            this.grp_Main.Controls.Add(this.btn_DecryptionMain);
            this.grp_Main.Controls.Add(this.btn_EncryptionMain);
            this.grp_Main.Location = new System.Drawing.Point(8, 8);
            this.grp_Main.Name = "grp_Main";
            this.grp_Main.Size = new System.Drawing.Size(924, 279);
            this.grp_Main.TabIndex = 12;
            this.grp_Main.TabStop = false;
            this.grp_Main.Text = "Home";
            // 
            // btn_DecryptionMain
            // 
            this.btn_DecryptionMain.Location = new System.Drawing.Point(499, 106);
            this.btn_DecryptionMain.Name = "btn_DecryptionMain";
            this.btn_DecryptionMain.Size = new System.Drawing.Size(150, 47);
            this.btn_DecryptionMain.TabIndex = 1;
            this.btn_DecryptionMain.Text = "Decryption";
            this.btn_DecryptionMain.UseVisualStyleBackColor = true;
            this.btn_DecryptionMain.Click += new System.EventHandler(this.btn_DecryptionMain_Click);
            // 
            // btn_EncryptionMain
            // 
            this.btn_EncryptionMain.Location = new System.Drawing.Point(227, 106);
            this.btn_EncryptionMain.Name = "btn_EncryptionMain";
            this.btn_EncryptionMain.Size = new System.Drawing.Size(150, 47);
            this.btn_EncryptionMain.TabIndex = 0;
            this.btn_EncryptionMain.Text = "Encryption";
            this.btn_EncryptionMain.UseVisualStyleBackColor = true;
            this.btn_EncryptionMain.Click += new System.EventHandler(this.btn_EncryptionMain_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(268, 293);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 23);
            this.btn_Home.TabIndex = 13;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // frm_TripleDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 328);
            this.Controls.Add(this.grp_MainEncryption);
            this.Controls.Add(this.grp_MainDecryption);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.grp_Main);
            this.Controls.Add(this.btn_Exit);
            this.Name = "frm_TripleDES";
            this.Text = "Cryptography";
            this.grp_MainEncryption.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_TDESEncrypt.ResumeLayout(false);
            this.grp_TDESEncrypt.PerformLayout();
            this.grp_TDESDecrypt.ResumeLayout(false);
            this.grp_TDESDecrypt.PerformLayout();
            this.grp_MainDecryption.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grp_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_MainEncryption;
        private System.Windows.Forms.GroupBox grp_TDESDecrypt;
        private System.Windows.Forms.TextBox txt_TDESDecryptMsg;
        private System.Windows.Forms.Label lbl_TDESDecryptOutput;
        private System.Windows.Forms.Button btn_TDESDecrypt;
        private System.Windows.Forms.TextBox txt_TDESDecryptKey;
        private System.Windows.Forms.Label lbl_TDESDecryptMsg;
        private System.Windows.Forms.Label lbl_TDESDecryptKey;
        private System.Windows.Forms.GroupBox grp_TDESEncrypt;
        private System.Windows.Forms.TextBox txt_TDESEncryptMsg;
        private System.Windows.Forms.Label lbl_TDESEncryptOutput;
        private System.Windows.Forms.Button btn_TDESEncrypt;
        private System.Windows.Forms.TextBox txt_TDESEncryptKey;
        private System.Windows.Forms.Label lbl_TDESEncryptMsg;
        private System.Windows.Forms.Label lbl_TDESEncryptKey;
        private System.Windows.Forms.RichTextBox txt_TDESDecryptOutput;
        private System.Windows.Forms.RichTextBox txt_TDESEncryptOutput;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grp_MainDecryption;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMessage1;
        private System.Windows.Forms.TextBox textBoxFilePath1;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonOpenFile1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_CopyEncryption;
        private System.Windows.Forms.Button btn_CopyDecryption;
        private System.Windows.Forms.GroupBox grp_Main;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_DecryptionMain;
        private System.Windows.Forms.Button btn_EncryptionMain;
    }
}

