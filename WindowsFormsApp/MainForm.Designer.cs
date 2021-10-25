
namespace WindowsFormsApp
{
    partial class MainForm
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
            this.buttonDecryptPol = new System.Windows.Forms.Button();
            this.buttonEncryptPol = new System.Windows.Forms.Button();
            this.buttonDecryptCaesar = new System.Windows.Forms.Button();
            this.labelDecrypt = new System.Windows.Forms.Label();
            this.richTextBoxEncrypt = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDecrypt = new System.Windows.Forms.RichTextBox();
            this.labelEncrypt = new System.Windows.Forms.Label();
            this.buttonEncryptCaesar = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDecryptPol
            // 
            this.buttonDecryptPol.Location = new System.Drawing.Point(673, 435);
            this.buttonDecryptPol.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonDecryptPol.Name = "buttonDecryptPol";
            this.buttonDecryptPol.Size = new System.Drawing.Size(310, 56);
            this.buttonDecryptPol.TabIndex = 19;
            this.buttonDecryptPol.Text = "Дешифровать текст с помощью магического квадрата";
            this.buttonDecryptPol.UseVisualStyleBackColor = true;
            this.buttonDecryptPol.Click += new System.EventHandler(this.ButtonDecryptPol_Click);
            // 
            // buttonEncryptPol
            // 
            this.buttonEncryptPol.Location = new System.Drawing.Point(134, 154);
            this.buttonEncryptPol.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonEncryptPol.Name = "buttonEncryptPol";
            this.buttonEncryptPol.Size = new System.Drawing.Size(319, 70);
            this.buttonEncryptPol.TabIndex = 18;
            this.buttonEncryptPol.Text = "Зашифровать текст с помощью магического квадрата";
            this.buttonEncryptPol.UseVisualStyleBackColor = true;
            this.buttonEncryptPol.Click += new System.EventHandler(this.ButtonEncryptPol_Click);
            // 
            // buttonDecryptCaesar
            // 
            this.buttonDecryptCaesar.Location = new System.Drawing.Point(673, 349);
            this.buttonDecryptCaesar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonDecryptCaesar.Name = "buttonDecryptCaesar";
            this.buttonDecryptCaesar.Size = new System.Drawing.Size(310, 44);
            this.buttonDecryptCaesar.TabIndex = 17;
            this.buttonDecryptCaesar.Text = "Дешифровать текст шифром Цезаря";
            this.buttonDecryptCaesar.UseVisualStyleBackColor = true;
            this.buttonDecryptCaesar.Click += new System.EventHandler(this.ButtonDecryptCaesar_Click);
            // 
            // labelDecrypt
            // 
            this.labelDecrypt.AutoSize = true;
            this.labelDecrypt.Location = new System.Drawing.Point(708, 9);
            this.labelDecrypt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDecrypt.Name = "labelDecrypt";
            this.labelDecrypt.Size = new System.Drawing.Size(243, 21);
            this.labelDecrypt.TabIndex = 14;
            this.labelDecrypt.Text = "Введите дешифруемый текст";
            // 
            // richTextBoxEncrypt
            // 
            this.richTextBoxEncrypt.Location = new System.Drawing.Point(15, 255);
            this.richTextBoxEncrypt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.richTextBoxEncrypt.Name = "richTextBoxEncrypt";
            this.richTextBoxEncrypt.Size = new System.Drawing.Size(549, 288);
            this.richTextBoxEncrypt.TabIndex = 13;
            this.richTextBoxEncrypt.Text = "";
            this.richTextBoxEncrypt.TextChanged += new System.EventHandler(this.richTextBoxEncrypt_TextChanged);
            // 
            // richTextBoxDecrypt
            // 
            this.richTextBoxDecrypt.Location = new System.Drawing.Point(576, 41);
            this.richTextBoxDecrypt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.richTextBoxDecrypt.Name = "richTextBoxDecrypt";
            this.richTextBoxDecrypt.Size = new System.Drawing.Size(503, 271);
            this.richTextBoxDecrypt.TabIndex = 12;
            this.richTextBoxDecrypt.Text = "";
            this.richTextBoxDecrypt.TextChanged += new System.EventHandler(this.richTextBoxDecrypt_TextChanged);
            // 
            // labelEncrypt
            // 
            this.labelEncrypt.AutoSize = true;
            this.labelEncrypt.Location = new System.Drawing.Point(179, 229);
            this.labelEncrypt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEncrypt.Name = "labelEncrypt";
            this.labelEncrypt.Size = new System.Drawing.Size(225, 21);
            this.labelEncrypt.TabIndex = 11;
            this.labelEncrypt.Text = "Введите шифруемый текст";
            this.labelEncrypt.Click += new System.EventHandler(this.labelEncrypt_Click);
            // 
            // buttonEncryptCaesar
            // 
            this.buttonEncryptCaesar.Location = new System.Drawing.Point(134, 100);
            this.buttonEncryptCaesar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonEncryptCaesar.Name = "buttonEncryptCaesar";
            this.buttonEncryptCaesar.Size = new System.Drawing.Size(319, 44);
            this.buttonEncryptCaesar.TabIndex = 10;
            this.buttonEncryptCaesar.Text = "Зашифровать текст шифром Цезаря";
            this.buttonEncryptCaesar.UseVisualStyleBackColor = true;
            this.buttonEncryptCaesar.Click += new System.EventHandler(this.ButtonEncryptCaesar_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(270, 63);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(48, 29);
            this.textBoxKey.TabIndex = 15;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Введите ключ для шифра Цезаря";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecryptPol);
            this.Controls.Add(this.buttonEncryptPol);
            this.Controls.Add(this.buttonDecryptCaesar);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelDecrypt);
            this.Controls.Add(this.richTextBoxEncrypt);
            this.Controls.Add(this.richTextBoxDecrypt);
            this.Controls.Add(this.labelEncrypt);
            this.Controls.Add(this.buttonEncryptCaesar);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Шифрование-дешифрование";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDecryptPol;
        private System.Windows.Forms.Button buttonEncryptPol;
        private System.Windows.Forms.Button buttonDecryptCaesar;
        private System.Windows.Forms.Label labelDecrypt;
        private System.Windows.Forms.RichTextBox richTextBoxEncrypt;
        private System.Windows.Forms.RichTextBox richTextBoxDecrypt;
        private System.Windows.Forms.Label labelEncrypt;
        private System.Windows.Forms.Button buttonEncryptCaesar;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label1;
    }
}