using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Araujo
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;

            // Create list of material
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

            // Populate surface material
            cmbSurfaceMaterial.DataSource = materials;

            // Deselect options
            cmbSurfaceMaterial.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            _mainMenu.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
