namespace SzyfratorPlikow
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btPrzeZrSz = new System.Windows.Forms.Button();
            this.tbZrodloSz = new System.Windows.Forms.TextBox();
            this.buttonSz = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonPrzeDocSz = new System.Windows.Forms.Button();
            this.tbDocSz = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btPokazZnakiSz = new System.Windows.Forms.CheckBox();
            this.tbHasloSz = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.buttonPrzeZrDe = new System.Windows.Forms.Button();
            this.tbZrodloDe = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.buttonPrzeDocDe = new System.Windows.Forms.Button();
            this.tbDocDe = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.cbPokazZnakiDe = new System.Windows.Forms.CheckBox();
            this.tbHasloDe = new System.Windows.Forms.TextBox();
            this.buttonDeSz = new System.Windows.Forms.Button();
            this.openFileDialogSzZr = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDeZr = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSzDoc = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogDeDoc = new System.Windows.Forms.SaveFileDialog();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(419, 338);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.buttonSz);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(411, 312);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Szyfrowanie";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btPrzeZrSz);
            this.groupBox7.Controls.Add(this.tbZrodloSz);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(395, 80);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Plik źródłowy";
            // 
            // btPrzeZrSz
            // 
            this.btPrzeZrSz.Location = new System.Drawing.Point(7, 47);
            this.btPrzeZrSz.Name = "btPrzeZrSz";
            this.btPrzeZrSz.Size = new System.Drawing.Size(75, 23);
            this.btPrzeZrSz.TabIndex = 1;
            this.btPrzeZrSz.Text = "Przeglądaj";
            this.btPrzeZrSz.UseVisualStyleBackColor = true;
            this.btPrzeZrSz.Click += new System.EventHandler(this.btPrzeZrSz_Click);
            // 
            // tbZrodloSz
            // 
            this.tbZrodloSz.Location = new System.Drawing.Point(7, 20);
            this.tbZrodloSz.Name = "tbZrodloSz";
            this.tbZrodloSz.Size = new System.Drawing.Size(382, 20);
            this.tbZrodloSz.TabIndex = 0;
            // 
            // buttonSz
            // 
            this.buttonSz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSz.Image = global::SzyfratorPlikow.Properties.Resources.sejf_maly;
            this.buttonSz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSz.Location = new System.Drawing.Point(5, 260);
            this.buttonSz.Name = "buttonSz";
            this.buttonSz.Size = new System.Drawing.Size(106, 45);
            this.buttonSz.TabIndex = 3;
            this.buttonSz.Text = "Szyfruj";
            this.buttonSz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSz.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.buttonPrzeDocSz);
            this.groupBox8.Controls.Add(this.tbDocSz);
            this.groupBox8.Location = new System.Drawing.Point(6, 93);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(395, 81);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Plik docelowy";
            // 
            // buttonPrzeDocSz
            // 
            this.buttonPrzeDocSz.Location = new System.Drawing.Point(7, 47);
            this.buttonPrzeDocSz.Name = "buttonPrzeDocSz";
            this.buttonPrzeDocSz.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzeDocSz.TabIndex = 1;
            this.buttonPrzeDocSz.Text = "Przeglądaj";
            this.buttonPrzeDocSz.UseVisualStyleBackColor = true;
            this.buttonPrzeDocSz.Click += new System.EventHandler(this.buttonPrzeDocSz_Click);
            // 
            // tbDocSz
            // 
            this.tbDocSz.Location = new System.Drawing.Point(7, 20);
            this.tbDocSz.Name = "tbDocSz";
            this.tbDocSz.Size = new System.Drawing.Size(382, 20);
            this.tbDocSz.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btPokazZnakiSz);
            this.groupBox9.Controls.Add(this.tbHasloSz);
            this.groupBox9.Location = new System.Drawing.Point(6, 181);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(395, 73);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Hasło";
            // 
            // btPokazZnakiSz
            // 
            this.btPokazZnakiSz.AutoSize = true;
            this.btPokazZnakiSz.Location = new System.Drawing.Point(7, 47);
            this.btPokazZnakiSz.Name = "btPokazZnakiSz";
            this.btPokazZnakiSz.Size = new System.Drawing.Size(84, 17);
            this.btPokazZnakiSz.TabIndex = 1;
            this.btPokazZnakiSz.Text = "Pokaż znaki";
            this.btPokazZnakiSz.UseVisualStyleBackColor = true;
            // 
            // tbHasloSz
            // 
            this.tbHasloSz.Location = new System.Drawing.Point(7, 20);
            this.tbHasloSz.Name = "tbHasloSz";
            this.tbHasloSz.Size = new System.Drawing.Size(382, 20);
            this.tbHasloSz.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox10);
            this.tabPage4.Controls.Add(this.groupBox11);
            this.tabPage4.Controls.Add(this.groupBox12);
            this.tabPage4.Controls.Add(this.buttonDeSz);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(411, 312);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Deszyfrowanie";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.buttonPrzeZrDe);
            this.groupBox10.Controls.Add(this.tbZrodloDe);
            this.groupBox10.Location = new System.Drawing.Point(6, 7);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(395, 80);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Plik źródłowy";
            // 
            // buttonPrzeZrDe
            // 
            this.buttonPrzeZrDe.Location = new System.Drawing.Point(7, 47);
            this.buttonPrzeZrDe.Name = "buttonPrzeZrDe";
            this.buttonPrzeZrDe.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzeZrDe.TabIndex = 1;
            this.buttonPrzeZrDe.Text = "Przeglądaj";
            this.buttonPrzeZrDe.UseVisualStyleBackColor = true;
            this.buttonPrzeZrDe.Click += new System.EventHandler(this.buttonPrzeZrDe_Click);
            // 
            // tbZrodloDe
            // 
            this.tbZrodloDe.Location = new System.Drawing.Point(7, 20);
            this.tbZrodloDe.Name = "tbZrodloDe";
            this.tbZrodloDe.Size = new System.Drawing.Size(382, 20);
            this.tbZrodloDe.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.buttonPrzeDocDe);
            this.groupBox11.Controls.Add(this.tbDocDe);
            this.groupBox11.Location = new System.Drawing.Point(6, 94);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(395, 81);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Plik docelowy";
            // 
            // buttonPrzeDocDe
            // 
            this.buttonPrzeDocDe.Location = new System.Drawing.Point(7, 47);
            this.buttonPrzeDocDe.Name = "buttonPrzeDocDe";
            this.buttonPrzeDocDe.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzeDocDe.TabIndex = 1;
            this.buttonPrzeDocDe.Text = "Przeglądaj";
            this.buttonPrzeDocDe.UseVisualStyleBackColor = true;
            this.buttonPrzeDocDe.Click += new System.EventHandler(this.buttonPrzeDocDe_Click);
            // 
            // tbDocDe
            // 
            this.tbDocDe.Location = new System.Drawing.Point(7, 20);
            this.tbDocDe.Name = "tbDocDe";
            this.tbDocDe.Size = new System.Drawing.Size(382, 20);
            this.tbDocDe.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.cbPokazZnakiDe);
            this.groupBox12.Controls.Add(this.tbHasloDe);
            this.groupBox12.Location = new System.Drawing.Point(6, 182);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(395, 73);
            this.groupBox12.TabIndex = 6;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Hasło";
            // 
            // cbPokazZnakiDe
            // 
            this.cbPokazZnakiDe.AutoSize = true;
            this.cbPokazZnakiDe.Location = new System.Drawing.Point(7, 47);
            this.cbPokazZnakiDe.Name = "cbPokazZnakiDe";
            this.cbPokazZnakiDe.Size = new System.Drawing.Size(84, 17);
            this.cbPokazZnakiDe.TabIndex = 1;
            this.cbPokazZnakiDe.Text = "Pokaż znaki";
            this.cbPokazZnakiDe.UseVisualStyleBackColor = true;
            // 
            // tbHasloDe
            // 
            this.tbHasloDe.Location = new System.Drawing.Point(7, 20);
            this.tbHasloDe.Name = "tbHasloDe";
            this.tbHasloDe.Size = new System.Drawing.Size(382, 20);
            this.tbHasloDe.TabIndex = 0;
            // 
            // buttonDeSz
            // 
            this.buttonDeSz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeSz.Image = global::SzyfratorPlikow.Properties.Resources.sejf_maly;
            this.buttonDeSz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeSz.Location = new System.Drawing.Point(5, 261);
            this.buttonDeSz.Name = "buttonDeSz";
            this.buttonDeSz.Size = new System.Drawing.Size(121, 45);
            this.buttonDeSz.TabIndex = 7;
            this.buttonDeSz.Text = "Deszyfruj";
            this.buttonDeSz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeSz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeSz.UseVisualStyleBackColor = true;
            // 
            // openFileDialogSzZr
            // 
            this.openFileDialogSzZr.FileName = "openFileDialog1";
            // 
            // openFileDialogDeZr
            // 
            this.openFileDialogDeZr.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 363);
            this.Controls.Add(this.tabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Szyfrator plików (Rijndael)";
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btPrzeZrSz;
        private System.Windows.Forms.TextBox tbZrodloSz;
        private System.Windows.Forms.Button buttonSz;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonPrzeDocSz;
        private System.Windows.Forms.TextBox tbDocSz;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox btPokazZnakiSz;
        private System.Windows.Forms.TextBox tbHasloSz;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button buttonPrzeZrDe;
        private System.Windows.Forms.TextBox tbZrodloDe;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button buttonPrzeDocDe;
        private System.Windows.Forms.TextBox tbDocDe;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox cbPokazZnakiDe;
        private System.Windows.Forms.TextBox tbHasloDe;
        private System.Windows.Forms.Button buttonDeSz;
        private System.Windows.Forms.OpenFileDialog openFileDialogSzZr;
        private System.Windows.Forms.OpenFileDialog openFileDialogDeZr;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSzDoc;
        private System.Windows.Forms.SaveFileDialog saveFileDialogDeDoc;
    }
}

