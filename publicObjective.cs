using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.MouseEventArgs;

namespace ti4Scorepad
{
    public partial class publicObjective : UserControl
    {
        int displayIndex;
        int index = -1;
        int publicObjectiveIndex = -1;
        int Points = 0;
        public publicObjective(int index, int points)
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(publicObjective_MouseButton);
            this.displayIndex = index;
            this.Points = points;
            this.labelPoints.Text = points.ToString();
        }

        public Dictionary<string, int> size
        {
            get {
                int width = this.Width;
                int height = this.Height;
                Dictionary<string, int> size = new Dictionary<string, int>();
                size.Add("width", width);
                size.Add("height", height);
                return size;
            }
        }
        public void setNew(string name, string phase, string description, string points) {
            this.textBoxTitle.Text = name;
            this.labelPhase.Text = phase;
            this.textBoxDescription.Text = description;
        }
        public void publicObjective_MouseButton(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                FormPublicObjectiveSelector publicObjectiveSelector = new FormPublicObjectiveSelector(this.index, this.Points);
                if (publicObjectiveSelector.ShowDialog() == DialogResult.OK) {
                    if (this.publicObjectiveIndex != -1) {
                        ClassGlobalVariables.removePublicObjectiveInPlay(this.publicObjectiveIndex);
                    }
                    this.publicObjectiveIndex = publicObjectiveSelector.returnValue;
                    ClassGlobalVariables.addPublicObjectiveInPlay(publicObjectiveIndex);
                    PublicObjectiveStruct publicObjective = ClassGlobalVariables.listPublicObjectives()[this.publicObjectiveIndex];
                    this.textBoxTitle.Text = publicObjective.Name;
                    this.labelPhase.Text = publicObjective.Phase;
                    this.textBoxDescription.Text = publicObjective.Description;
                    this.labelPoints.Text = publicObjective.Points;
                    this.index = publicObjectiveSelector.returnValue;
                    this.Name = "publicObjective" + publicObjectiveSelector.returnValue;
                }
                
            }
        }

    }
}
