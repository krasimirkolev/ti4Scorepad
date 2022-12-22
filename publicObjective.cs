using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ti4Scorepad
{
    public partial class publicObjective : UserControl
    {
        int index;
        int Points = 0;

        public publicObjective(int index, int points, ref ImageList imageList)
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(publicObjective_MouseButton);
            
            this.index = -1;
            this.Points = points;
            this.labelPoints.Text = points.ToString();
            racesScored racesScored = new racesScored(imageList);
            racesScored.Location = new System.Drawing.Point(3, 132);
            this.Controls.Add(racesScored);
        }

        public Dictionary<string, int> size
        {
            get {
                Dictionary<string, int> size = new Dictionary<string, int>();
                size.Add("width", this.Width);
                size.Add("height", this.Height);
                return size;
            }
        }

        public void publicObjective_MouseButton(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuPublicObjectives.Items.Clear();

                List<int> publicObjectivesInPlay = ClassGlobalVariables.getPublicObjectivesInPlay();
                Dictionary<int, string> contextMenuSource = new Dictionary<int, string>();
                for (int i = 0; i < ClassGlobalVariables.listPublicObjectives().Length; i++)
                {
                    if (!publicObjectivesInPlay.Contains(i) && ClassGlobalVariables.listPublicObjectives()[i].Points == this.Points.ToString())
                    {
                        ToolStripMenuItem newItem = new ToolStripMenuItem()
                        {
                            Text = ClassGlobalVariables.listPublicObjectives()[i].Name,
                            Name = ClassGlobalVariables.listPublicObjectives()[i].Index.ToString()
                        };
                        contextMenuPublicObjectives.Items.Add(newItem);
                    }
                }
            }

        }

        private void contextMenuPublicObjectives_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // set public objective
            int index = Int32.Parse(e.ClickedItem.Name);
            if (this.index != -1)
            {
                ClassGlobalVariables.removePublicObjectiveInPlay(this.index);
            }
            ClassGlobalVariables.addPublicObjectiveInPlay(index);
            PublicObjectiveStruct publicObjective = ClassGlobalVariables.listPublicObjectives()[index];
            this.textBoxTitle.Text = publicObjective.Name;
            this.labelPhase.Text = publicObjective.Phase;
            this.textBoxDescription.Text = publicObjective.Description;
            this.labelPoints.Text = publicObjective.Points;
            this.index = index;
            this.Name = "publicObjective" + index.ToString();
        }

    }
}
