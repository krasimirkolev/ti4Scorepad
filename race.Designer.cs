namespace ti4Scorepad
{
    partial class race
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxRace = new System.Windows.Forms.PictureBox();
            this.labelRace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRace)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRace
            // 
            this.pictureBoxRace.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRace.Name = "pictureBoxRace";
            this.pictureBoxRace.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxRace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRace.TabIndex = 0;
            this.pictureBoxRace.TabStop = false;
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(51, 15);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(35, 13);
            this.labelRace.TabIndex = 1;
            this.labelRace.Text = "label1";
            // 
            // race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this.pictureBoxRace);
            this.Name = "race";
            this.Size = new System.Drawing.Size(290, 45);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRace;
        private System.Windows.Forms.Label labelRace;
    }
}
