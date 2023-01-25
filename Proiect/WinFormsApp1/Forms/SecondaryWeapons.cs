using DataAccess;
using Models;
using System.Data;

namespace WinFormsApp1.Forms
{
    public partial class SecondaryWeapons : Form
    {
        private DBContext db;
        public SecondaryWeapons()
        {
            InitializeComponent();
            db = new DBContext();
            refreshSecondaryWeapons();
        }
        private void refreshSecondaryWeapons()
        {
            try
            {
                BindingSource bs = new BindingSource();
                var query = from s in db.SecondaryWeapon orderby s.id_secondaryWeapon select new { s.id_secondaryWeapon, SecondaryWeaponName = s.secondaryWeapon_name, Crafted = s.crafted };
                bs.DataSource = query.ToList();
                ShowSecondaryWeaponsGridView.DataSource = bs;
                ShowSecondaryWeaponsGridView.Refresh();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private SecondaryWeapon getId()
        {
            SecondaryWeapon? sw = null;
            try
            {
                sw = db.SecondaryWeapon.Find((int)ShowSecondaryWeaponsGridView.SelectedCells[0].Value);
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            return sw;
        }
        private void CreateSecondaryWeaponButton_Click(object sender, EventArgs e)
        {
            try
            {
                string NameSecondaryWeapon = NameSecondaryWeaponTextBox.Text;
                bool CraftedSecondaryWeapon = CraftedSecondaryWeaponCheckBox.Checked;
                if (string.IsNullOrEmpty(NameSecondaryWeaponTextBox.Text))
                    MessageBox.Show("You have to input a text in the TextBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    SecondaryWeapon AddSecondaryWeapon = new SecondaryWeapon() { secondaryWeapon_name = NameSecondaryWeapon, crafted = CraftedSecondaryWeapon };
                    db.Add(AddSecondaryWeapon);
                    db.SaveChanges();
                    MessageBox.Show("The secondary weapon with the name: " + NameSecondaryWeapon+" has been created!");
                    refreshSecondaryWeapons();
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void UpdateSecondarWeaponsButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_secondaryWeapon;
                var Object = db.SecondaryWeapon.FirstOrDefault(x => x.id_secondaryWeapon == id);//expresie linq
                if (Object.crafted == CraftedSecondaryWeaponCheckBox.Checked && string.IsNullOrEmpty(NameSecondaryWeaponTextBox.Text))
                {
                    MessageBox.Show("You have to input a text in the TextBox or modify Crafted Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (string.IsNullOrEmpty(NameSecondaryWeaponTextBox.Text))
                {
                    Object.crafted = CraftedSecondaryWeaponCheckBox.Checked;
                    db.Update(Object);
                    db.SaveChanges();
                    MessageBox.Show("The secondary weapon with the name: " + Object.secondaryWeapon_name + " has been updated!");
                    refreshSecondaryWeapons();
                }else
                {
                    Object.secondaryWeapon_name = NameSecondaryWeaponTextBox.Text;
                    Object.crafted = CraftedSecondaryWeaponCheckBox.Checked;
                    db.Update(Object);
                    db.SaveChanges();
                    MessageBox.Show("The secondary weapon with the name: " + Object.secondaryWeapon_name + " has been updated!");
                    refreshSecondaryWeapons();
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void DeleteSecondaryWeaponButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_secondaryWeapon;
                var Object = db.SecondaryWeapon.FirstOrDefault(x => x.id_secondaryWeapon == id);//expresie linq
                string message = "Do you want to delete this secondary weapon?";
                string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    db.Remove(Object);
                    db.SaveChanges();
                    MessageBox.Show("The secondary weapon with the name: " + Object.secondaryWeapon_name + " has been deleted!");
                    refreshSecondaryWeapons();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void BackToWarframeTrackerFromSecondaryWeaponsButton_Click(object sender, EventArgs e)
        {
            WarframeTracker warframe = new WarframeTracker();
            this.Hide();
            warframe.Show();
        }
    }
}
