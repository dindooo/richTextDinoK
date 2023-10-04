namespace richBoxDinoK
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
            this.btnCitaj = new System.Windows.Forms.Button();
            this.btnBriši = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCitaj
            // 
            this.btnCitaj.Location = new System.Drawing.Point(73, 41);
            this.btnCitaj.Name = "btnCitaj";
            this.btnCitaj.Size = new System.Drawing.Size(75, 23);
            this.btnCitaj.TabIndex = 0;
            this.btnCitaj.Text = "Čitaj";
            this.btnCitaj.UseVisualStyleBackColor = true;
            this.btnCitaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBriši
            // 
            this.btnBriši.Location = new System.Drawing.Point(399, 41);
            this.btnBriši.Name = "btnBriši";
            this.btnBriši.Size = new System.Drawing.Size(75, 23);
            this.btnBriši.TabIndex = 1;
            this.btnBriši.Text = "Briši";
            this.btnBriši.UseVisualStyleBackColor = true;
            this.btnBriši.Click += new System.EventHandler(this.btnBriši_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(73, 396);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(73, 95);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(401, 267);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnBriši);
            this.Controls.Add(this.btnCitaj);
            this.Name = "Form1";
            this.Text = "Rich Text Box Kontrole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCitaj;
        private System.Windows.Forms.Button btnBriši;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

