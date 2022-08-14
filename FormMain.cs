using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ti4Scorepad
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            int screenWidth = this.Width;
            int screenHeight = this.Height;

            int[,] positions = ClassGlobalVariables.positionsStaticPublicObjectives();
            List<ti4Scorepad.publicObjective> emptyPublicObjectives = ClassGlobalVariables.emptyPublicObjectives();
            for (int i = 0; i < 10; i++)
            {
                emptyPublicObjectives[i].Location = new System.Drawing.Point(positions[i, 0], positions[i, 1]);
                emptyPublicObjectives[i].Name = "publicObjective";
                this.Controls.Add(emptyPublicObjectives[i]);
            }
            
        }

        private void buttonAddRaceInPlay_Click(object sender, EventArgs e)
        {
            FormRaceSelector raceSelector = new FormRaceSelector();
            int[,] positions = ClassGlobalVariables.positionsStaticRaces();
            int racesInPlayCount = ClassGlobalVariables.getRacesInPlay().Count;
            if (raceSelector.ShowDialog() == DialogResult.OK) {
                string raceName = ClassGlobalVariables.listRaces()[raceSelector.returnValue];
                ClassGlobalVariables.addRaceInPlay(raceSelector.returnValue);
                race current = new race(imageListRaces.Images[raceSelector.returnValue], raceName);
                current.Location = new System.Drawing.Point(positions[racesInPlayCount, 0], positions[racesInPlayCount, 1]);
                current.Name = "race" + raceSelector.returnValue;
                this.Controls.Add(current);
                if (racesInPlayCount == 7) {
                    this.buttonAddRaceInPlay.Enabled = false;
                }
            }
        }

    }
}
