namespace ti4Scorepad
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonAddRaceInPlay = new System.Windows.Forms.Button();
            this.imageListRaces = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // buttonAddRaceInPlay
            // 
            this.buttonAddRaceInPlay.Location = new System.Drawing.Point(728, 12);
            this.buttonAddRaceInPlay.Name = "buttonAddRaceInPlay";
            this.buttonAddRaceInPlay.Size = new System.Drawing.Size(69, 23);
            this.buttonAddRaceInPlay.TabIndex = 0;
            this.buttonAddRaceInPlay.Text = "Add race";
            this.buttonAddRaceInPlay.UseVisualStyleBackColor = true;
            this.buttonAddRaceInPlay.Click += new System.EventHandler(this.buttonAddRaceInPlay_Click);
            // 
            // imageListRaces
            // 
            this.imageListRaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRaces.ImageStream")));
            this.imageListRaces.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRaces.Images.SetKeyName(0, "1theArborec.png");
            this.imageListRaces.Images.SetKeyName(1, "2theArgentFlight.png");
            this.imageListRaces.Images.SetKeyName(2, "3theBaronyOfLetnev.png");
            this.imageListRaces.Images.SetKeyName(3, "4theClanOfSaar.png");
            this.imageListRaces.Images.SetKeyName(4, "5theEmbersOfMuaat.png");
            this.imageListRaces.Images.SetKeyName(5, "6theEmiratesOfHacan.png");
            this.imageListRaces.Images.SetKeyName(6, "7theEmpyrean.png");
            this.imageListRaces.Images.SetKeyName(7, "8theFederationOfSol.png");
            this.imageListRaces.Images.SetKeyName(8, "9theGhostsOfCreuss.png");
            this.imageListRaces.Images.SetKeyName(9, "10theL1Z1XMindnet.png");
            this.imageListRaces.Images.SetKeyName(10, "11theMahactGeneSorcerers.png");
            this.imageListRaces.Images.SetKeyName(11, "12theMentakCoalition.png");
            this.imageListRaces.Images.SetKeyName(12, "13theNaaluCollective.png");
            this.imageListRaces.Images.SetKeyName(13, "14theNaazRokhaAlliance.png");
            this.imageListRaces.Images.SetKeyName(14, "15theNecroVirus.png");
            this.imageListRaces.Images.SetKeyName(15, "16theNomad.png");
            this.imageListRaces.Images.SetKeyName(16, "17sardakkNorr.png");
            this.imageListRaces.Images.SetKeyName(17, "18theTitansOfUl.png");
            this.imageListRaces.Images.SetKeyName(18, "19theUniversitiesOfJolNar.png");
            this.imageListRaces.Images.SetKeyName(19, "20theVuilRaithCabal.png");
            this.imageListRaces.Images.SetKeyName(20, "21theWinnu.png");
            this.imageListRaces.Images.SetKeyName(21, "22theXxchaKingdom.png");
            this.imageListRaces.Images.SetKeyName(22, "23theYinBrotherhood.png");
            this.imageListRaces.Images.SetKeyName(23, "24theYssarilTribes.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 997);
            this.Controls.Add(this.buttonAddRaceInPlay);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twilight Imperium 4 scorepad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddRaceInPlay;
        public System.Windows.Forms.ImageList imageListRaces;



    }
}

