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
            this.components = new System.ComponentModel.Container();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelPhase = new System.Windows.Forms.Label();
            this.labelStatic = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.RichTextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.contextMenuPublicObjectives = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // labelPoints
            // 
            this.labelPoints.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoints.Location = new System.Drawing.Point(69, 109);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(19, 20);
            this.labelPoints.TabIndex = 2;
            this.labelPoints.Text = "0";
            this.labelPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPhase
            // 
            this.labelPhase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPhase.AutoSize = true;
            this.labelPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhase.ForeColor = System.Drawing.Color.Red;
            this.labelPhase.Location = new System.Drawing.Point(94, 30);
            this.labelPhase.Name = "labelPhase";
            this.labelPhase.Size = new System.Drawing.Size(72, 13);
            this.labelPhase.TabIndex = 3;
            this.labelPhase.Text = "UNKNOWN";
            this.labelPhase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStatic
            // 
            this.labelStatic.AutoSize = true;
            this.labelStatic.Location = new System.Drawing.Point(94, 114);
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
            this.textBoxTitle.Location = new System.Drawing.Point(6, 3);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(280, 24);
            this.textBoxTitle.TabIndex = 8;
            this.textBoxTitle.Text = "UNKNOWN";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.Location = new System.Drawing.Point(6, 46);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(280, 60);
            this.textBoxDescription.TabIndex = 9;
            this.textBoxDescription.Text = "UNKNOWN";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape});
            this.shapeContainer1.Size = new System.Drawing.Size(295, 200);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape
            // 
            this.lineShape.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineShape.Name = "lineShape";
            this.lineShape.X1 = 5;
            this.lineShape.X2 = 290;
            this.lineShape.Y1 = 130;
            this.lineShape.Y2 = 130;
            // 
            // contextMenuPublicObjectives
            // 
            this.contextMenuPublicObjectives.Name = "contextMenuPublicObjectives";
            this.contextMenuPublicObjectives.ShowImageMargin = false;
            this.contextMenuPublicObjectives.Size = new System.Drawing.Size(36, 4);
            this.contextMenuPublicObjectives.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuPublicObjectives_ItemClicked);
            // 
            // publicObjective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuPublicObjectives;
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelStatic);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelPhase);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "publicObjective";
            this.Size = new System.Drawing.Size(295, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelPhase;
        private System.Windows.Forms.Label labelStatic;
        private System.Windows.Forms.RichTextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape;
        private System.Windows.Forms.ContextMenuStrip contextMenuPublicObjectives;
    }
}
