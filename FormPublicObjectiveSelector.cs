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
    public partial class FormPublicObjectiveSelector : Form
    {
        public int returnValue { get; set; }
        public int Points;
        public FormPublicObjectiveSelector(int index, int points)
        {
            InitializeComponent();
            this.returnValue = index;
            this.Points = points;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.returnValue = ((KeyValuePair<int, string>)comboBoxPublicObjectives.SelectedItem).Key;
            this.DialogResult = DialogResult.OK;
        }

        private void FormPublicObjectiveSelector_Shown(object sender, EventArgs e)
        {
            List<int> publicObjectivesInPlay = ClassGlobalVariables.getPublicObjectivesInPlay();
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            int selectedIndex = -1;
            for (int i = 0; i < ClassGlobalVariables.listPublicObjectives().Length; i++)
            {
                if ((ClassGlobalVariables.listPublicObjectives()[i].Index == this.returnValue || !publicObjectivesInPlay.Contains(i)) && ClassGlobalVariables.listPublicObjectives()[i].Points == this.Points.ToString())
                {
                    comboSource.Add(ClassGlobalVariables.listPublicObjectives()[i].Index, ClassGlobalVariables.listPublicObjectives()[i].Name);
                    if (ClassGlobalVariables.listPublicObjectives()[i].Index == this.returnValue)
                    {
                        selectedIndex = comboSource.Count - 1;
                    }
                }
            }
            comboBoxPublicObjectives.DataSource = new BindingSource(comboSource, null);
            comboBoxPublicObjectives.DisplayMember = "Value";
            comboBoxPublicObjectives.ValueMember = "Key";
            if (selectedIndex != -1)
            {
                comboBoxPublicObjectives.SelectedIndex = selectedIndex;
                //ClassGlobalVariables.removePublicObjectiveInPlay(ClassGlobalVariables.listPublicObjectives()[selectedIndex].Index);
            }
            else
            {
                comboBoxPublicObjectives.Text = "";
                this.buttonOk.Enabled = false;            
            }

        }

        private void comboBoxPublicObjectives_SelectedValueChanged(object sender, EventArgs e)
        {
            this.buttonOk.Enabled = true;
        }

    }
}
