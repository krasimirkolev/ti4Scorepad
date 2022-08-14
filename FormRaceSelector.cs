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
    public partial class FormRaceSelector : Form
    {
        public int returnValue { get; set; }
        public FormRaceSelector()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.returnValue = ((KeyValuePair<int, string>)comboBoxRace.SelectedItem).Key;
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormRaceSelector_Shown(object sender, EventArgs e)
        {
            List<int> racesInPlay = ClassGlobalVariables.getRacesInPlay();
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            for (int i = 0; i < ClassGlobalVariables.listRaces().Count; i++)
            {
                if (!racesInPlay.Contains(i))
                {
                    comboSource.Add(i, ClassGlobalVariables.listRaces()[i]);

                }
            }
            comboBoxRace.DataSource = new BindingSource(comboSource, null);
            comboBoxRace.DisplayMember = "Value";
            comboBoxRace.ValueMember = "Key";
            comboBoxRace.Text = "";
            this.buttonOk.Enabled = false;
        }

        private void comboBoxRace_SelectedValueChanged(object sender, EventArgs e)
        {
            this.buttonOk.Enabled = true;
        }
    }
}
