
namespace TextFromImages
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFile = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(36, 23);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(75, 23);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(142, 23);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 1;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TextFromImages.Properties.Resources.demo_picture;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(356, 23);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(296, 306);
            this.resultBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert from Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.selectFile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text from images";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button button1;
    }
}

