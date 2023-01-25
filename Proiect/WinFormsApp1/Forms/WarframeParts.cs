using DataAccess;
using Models;
using System.Data;

namespace WinFormsApp1.Forms
{
    public partial class WarframeParts : Form
    {
        private DBContext db;
        public WarframeParts()
        {
            InitializeComponent();
            db = new DBContext();
            refreshWarframeParts();
        }
        private void refreshWarframeParts()
        {
            try
            {
                BindingSource bs = new BindingSource();
                var query = from pts in db.WarframePart orderby pts.id_warframePart select new { ID = pts.id_warframePart, WarframeName = pts.warframe_name, BlueprintC = pts.warframe_blueprint_crafted, SystemC = pts.warframe_system_crafted, ChassisC = pts.warframe_chassis_crafted, NeuropticsC = pts.warframe_neuroptics_crafted, BlueprintO = pts.warframe_blueprint_owned, SystemO = pts.warframe_system_owned, ChassisO = pts.warframe_chassis_owned, NeuropticsO = pts.warframe_neuroptics_owned };
                bs.DataSource = query.ToList();
                ShowWarframePartGridView.DataSource = bs;
                ShowWarframePartGridView.Refresh();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private WarframePart getId()
        {
            WarframePart? wp = null;
            try
            {
                wp = db.WarframePart.Find((int)ShowWarframePartGridView.SelectedCells[0].Value);
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            return wp;
        }
        private void UpdateWarframePartsButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_warframePart;
                var Object = db.WarframePart.FirstOrDefault(x => x.id_warframePart == id);
                Object.warframe_neuroptics_owned = OwnedWarframeNeuropticsCheckBox.Checked;
                Object.warframe_neuroptics_crafted = CraftedWarframeNeuropticsCheckBox.Checked;
                Object.warframe_blueprint_owned = OwnedWarframeBlueprintCheckBox.Checked;
                Object.warframe_blueprint_crafted = CraftedWarframeBlueprintCheckBox.Checked;
                Object.warframe_system_owned = OwnedWarframeSystemCheckBox.Checked;
                Object.warframe_system_crafted = CraftedWarframeSystemCheckBox.Checked;
                Object.warframe_chassis_owned = OwnedWarframeChassisCheckBox.Checked;
                Object.warframe_chassis_crafted = CraftedWarframeChassisCheckBox.Checked;
                db.Update(Object);
                db.SaveChanges();
                MessageBox.Show("The parts for the warframe named: " + Object.warframe_name + " have been updated!");
                refreshWarframeParts();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BackToWarframeButton_Click(object sender, EventArgs e)
        {
            Warframes warframe = new Warframes();
            this.Hide();
            warframe.Show();
        }

        private void ImportWarframePartButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool WarframeBlueprintCrafted = getId().warframe_blueprint_crafted;
                CraftedWarframeBlueprintCheckBox.Checked = WarframeBlueprintCrafted;
                bool WarframeSystemCrafted = getId().warframe_system_crafted;
                CraftedWarframeSystemCheckBox.Checked = WarframeSystemCrafted;
                bool WarframeChassisCrafted = getId().warframe_chassis_crafted;
                CraftedWarframeChassisCheckBox.Checked = WarframeChassisCrafted;
                bool WarframeNeuropticsCrafted = getId().warframe_neuroptics_crafted;
                CraftedWarframeNeuropticsCheckBox.Checked = WarframeNeuropticsCrafted;
                bool WarframeBlueprintOwned = getId().warframe_blueprint_owned;
                OwnedWarframeBlueprintCheckBox.Checked = WarframeBlueprintOwned;
                bool WarframeSystemOwned = getId().warframe_system_owned;
                OwnedWarframeSystemCheckBox.Checked = WarframeSystemOwned;
                bool WarframeChassisOwned = getId().warframe_chassis_owned;
                OwnedWarframeChassisCheckBox.Checked = WarframeChassisOwned;
                bool WarframeNeuropticsOwned = getId().warframe_neuroptics_owned;
                OwnedWarframeNeuropticsCheckBox.Checked = WarframeNeuropticsOwned;
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
