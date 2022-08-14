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
    public partial class race : UserControl
    {
        public race(Image raceImage, string raceName)
        {
            InitializeComponent();
            pictureBoxRace.Image = raceImage;
            labelRace.Text = raceName;
        }
    }
}
