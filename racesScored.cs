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
        List<int> racesScoredList = new List<int>(); // indexes from ClassGlobalVariables.listRaces
        Dictionary<int, string> listRaces = ClassGlobalVariables.listRaces();
        Dictionary<int, PictureBox> imagesMap = new Dictionary<int, PictureBox>();
        int racesScoredCount = 0;
        public racesScored(ref ImageList imageList)
        {
            InitializeComponent();

            this.imagesMap = new Dictionary<int, PictureBox>() {
                {0, this.pictureBox1},
                {1, this.pictureBox2},
                {2, this.pictureBox3},
                {3, this.pictureBox4},
                {4, this.pictureBox5},
                {5, this.pictureBox6},
                {6, this.pictureBox7},
                {7, this.pictureBox8}
            };
            this.imageList = imageList;
        }

        private void contextMenuRaces_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = Int32.Parse(e.ClickedItem.Name);
            this.racesScoredList.Add(index);
            this.imagesMap[this.racesScoredCount].Image = this.imageList.Images[index];
            this.racesScoredCount++;
        }

        private void this_OpenContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuRaces.Items.Clear();

                List<int> racesInPlay = ClassGlobalVariables.getRacesInPlay();
                for (int i = 0; i < racesInPlay.Count; i++)
                {
                    if (!this.racesScoredList.Contains(racesInPlay[i]))
                    {
                        ToolStripMenuItem newItem = new ToolStripMenuItem()
                        {
                            Text = this.listRaces[racesInPlay[i]],
                            Name = racesInPlay[i].ToString(),
                            Image = this.imageList.Images[racesInPlay[i]]
                        };
                        contextMenuRaces.Items.Add(newItem);
                    }
                }
                contextMenuRaces.Show(Cursor.Position);
            }

        }
    }
}
