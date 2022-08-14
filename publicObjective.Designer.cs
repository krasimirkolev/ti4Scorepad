namespace ti4Scorepad
{
    partial class publicObjective
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
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelPhase = new System.Windows.Forms.Label();
            this.labelStatic = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.RichTextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPoints
            // 
            this.labelPoints.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(55, 159);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(13, 13);
            this.labelPoints.TabIndex = 2;
            this.labelPoints.Text = "0";
            this.labelPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPhase
            // 
            this.labelPhase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPhase.AutoSize = true;
            this.labelPhase.Location = new System.Drawing.Point(3, 48);
            this.labelPhase.Name = "labelPhase";
            this.labelPhase.Size = new System.Drawing.Size(65, 13);
            this.labelPhase.TabIndex = 3;
            this.labelPhase.Text = "UNKNOWN";
            this.labelPhase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStatic
            // 
            this.labelStatic.AutoSize = true;
            this.labelStatic.Location = new System.Drawing.Point(16, 184);
            this.labelStatic.Name = "labelStatic";
            this.labelStatic.Size = new System.Drawing.Size(97, 13);
            this.labelStatic.TabIndex = 6;
            this.labelStatic.Text = "VICTORY POINTS";
            this.labelStatic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(132, 42);
            this.textBoxTitle.TabIndex = 8;
            this.textBoxTitle.Text = "UNKNOWN";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(6, 64);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(128, 92);
            this.textBoxDescription.TabIndex = 9;
            this.textBoxDescription.Text = "UNKNOWN";
            // 
            // publicObjective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelStatic);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelPhase);
            this.Name = "publicObjective";
            this.Size = new System.Drawing.Size(137, 206);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelPhase;
        private System.Windows.Forms.Label labelStatic;
        private System.Windows.Forms.RichTextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}
