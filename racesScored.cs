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
    public partial class racesScored : UserControl
    {
        ImageList imageList = new ImageList();
        List<int> racesScoredList = new List<int>();
        public racesScored(ImageList imageList)
        {
            InitializeComponent();

            this.imageList = imageList;
        }

        private void this_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuRaces.Items.Clear();

                List<int> racesInPlay = ClassGlobalVariables.getRacesInPlay();
                Dictionary<int, string> listRaces = ClassGlobalVariables.listRaces();
                for (int i = 0; i < racesInPlay.Count; i++)
                {
                    if (!this.racesScoredList.Contains(racesInPlay[i]))
                    {
                        ToolStripMenuItem newItem = new ToolStripMenuItem()
                        {
                            Text = listRaces[racesInPlay[i]],
                            Name = racesInPlay[i].ToString(),
                            Image = this.imageList.Images[racesInPlay[i]]
                        };
                        contextMenuRaces.Items.Add(newItem);
                    }
                }
                contextMenuRaces.Show();
            }
        }

        private void contextMenuRaces_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = Int32.Parse(e.ClickedItem.Name);
            this.racesScoredList.Add(index);
            // listViewRacesScored.Items.Add("", index);
        }

    }
}
