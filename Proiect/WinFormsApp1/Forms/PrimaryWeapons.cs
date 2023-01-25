using DataAccess;
using Models;
using System.Data;

namespace WinFormsApp1.Forms
{
    public partial class PrimaryWeapons : Form
    {
        private DBContext db;
        public PrimaryWeapons()
        {
            InitializeComponent();
            db = new DBContext();
            refreshPrimaryWeapons();
        }
        private void refreshPrimaryWeapons()
        {
            BindingSource bs = new BindingSource();
            var query = from p in db.PrimaryWeapon orderby p.id_primaryWeapon select new { p.id_primaryWeapon, PrimaryWeaponName = p.primaryWeapon_name, Crafted = p.crafted };
            bs.DataSource = query.ToList();
            PrimaryWeaponsGridView.DataSource = bs;
            PrimaryWeaponsGridView.Refresh();
        }
        private PrimaryWeapon getId()
        {
            PrimaryWeapon? pw = null;
            try
            {
                pw = db.PrimaryWeapon.Find((int)PrimaryWeaponsGridView.SelectedCells[0].Value);
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            return pw;
        }
        private void CreatePrimaryWeaponsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string NamePrimaryWeapon = NamePrimaryWeaponsTextBox.Text;
                bool CraftedPrimaryWeapon = CraftedPrimaryWeaponsCheckBox.Checked;
                if (string.IsNullOrEmpty(NamePrimaryWeaponsTextBox.Text))
                    MessageBox.Show("You have to input a text in the TextBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    PrimaryWeapon AddPrimaryWeapon = new PrimaryWeapon() { primaryWeapon_name = NamePrimaryWeapon, crafted = CraftedPrimaryWeapon };
                    db.Add(AddPrimaryWeapon);
                    db.SaveChanges();
                    MessageBox.Show("The primary weapon with the name: " + NamePrimaryWeapon + " has been created!");
                    refreshPrimaryWeapons();
                }
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void UpdatePrimaryWeaponsButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_primaryWeapon;
                var Object = db.PrimaryWeapon.FirstOrDefault(x => x.id_primaryWeapon == id);//expresie linq
                if (Object.crafted == CraftedPrimaryWeaponsCheckBox.Checked && string.IsNullOrEmpty(NamePrimaryWeaponsTextBox.Text))
                {
                    MessageBox.Show("You have to input a text in the TextBox or modify Crafted Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (string.IsNullOrEmpty(NamePrimaryWeaponsTextBox.Text))
                {
                    Object.crafted = CraftedPrimaryWeaponsCheckBox.Checked;
                    db.Update(Object);
                    db.SaveChanges();
                    MessageBox.Show("The primary weapon with the name: " + Object.primaryWeapon_name + " has been updated!");
                    refreshPrimaryWeapons();
                }else
                {
                    Object.primaryWeapon_name = NamePrimaryWeaponsTextBox.Text;
                    Object.crafted = CraftedPrimaryWeaponsCheckBox.Checked;
                    db.Update(Object);
                    db.SaveChanges();
                    MessageBox.Show("The primary weapon with the name: " + Object.primaryWeapon_name + " has been updated!");
                    refreshPrimaryWeapons();
                }
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void DeletePrimaryWeaponsButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_primaryWeapon;
                var Object = db.PrimaryWeapon.FirstOrDefault(x => x.id_primaryWeapon == id);//expresie linq
                string message = "Do you want to delete this primary weapon?";
                string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    db.Remove(Object);
                    db.SaveChanges();
                    MessageBox.Show("The primary weapon with the name: " + Object.primaryWeapon_name + " has been deleted!");
                    refreshPrimaryWeapons();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void BackToWarframeTrackerFromPrimaryWeaponsButton_Click(object sender, EventArgs e)
        {
            WarframeTracker warframe = new WarframeTracker();
            this.Hide();
            warframe.Show();
        }
    }
}
