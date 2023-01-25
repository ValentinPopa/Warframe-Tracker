using DataAccess;
using Models;
using System.Data;

namespace WinFormsApp1.Forms
{
    public partial class MeleeWeapons : Form
    {
        private DBContext db;
        public MeleeWeapons()
        {
            InitializeComponent();
            db = new DBContext();
            refreshMeleeWeapons();
        }
        private void refreshMeleeWeapons()
        {
            try
            {
                BindingSource bs = new BindingSource();
                var query = from m in db.MeleeWeapon orderby m.id_meleeWeapon select new { m.id_meleeWeapon, MeleeWeaponName = m.meleeWeapon_name, Crafted = m.crafted };
                bs.DataSource = query.ToList();
                ShowMeleeWeaponsGridView.DataSource = bs;
                ShowMeleeWeaponsGridView.Refresh();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private MeleeWeapon getId()
        {
            MeleeWeapon? mw = null;
            try
            {
                mw = db.MeleeWeapon.Find((int)ShowMeleeWeaponsGridView.SelectedCells[0].Value); 
            }catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            return mw;
        }
        private void CreateMeleeWeaponButton_Click(object sender, EventArgs e)
        {
            try
            {
                string NameMeleeWeapon = NameMeleeWeaponTextBox.Text;
                bool CraftedMeleeWeapon = CraftedMeleeWeaponCheckBox.Checked;
                if (string.IsNullOrEmpty(NameMeleeWeaponTextBox.Text))
                    MessageBox.Show("You have to input a text in the TextBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MeleeWeapon AddMeleeWeapon = new MeleeWeapon() { meleeWeapon_name = NameMeleeWeapon, crafted = CraftedMeleeWeapon };
                    db.Add(AddMeleeWeapon);
                    db.SaveChanges();
                    MessageBox.Show("The melee weapon with the name: " + NameMeleeWeapon + " has been created!");
                    refreshMeleeWeapons();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void UpdateMeleeWeaponButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_meleeWeapon;
                var Object = db.MeleeWeapon.FirstOrDefault(x => x.id_meleeWeapon == id);//expresie linq
                if (Object.crafted == CraftedMeleeWeaponCheckBox.Checked && string.IsNullOrEmpty(NameMeleeWeaponTextBox.Text))
                {
                    MessageBox.Show("You have to input a text in the TextBox or modify Crafted Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (string.IsNullOrEmpty(NameMeleeWeaponTextBox.Text))
                {
                    Object.crafted = CraftedMeleeWeaponCheckBox.Checked;
                    db.Update(Object);
                    db.SaveChanges();
                    MessageBox.Show("The melee weapon with the name: " + Object.meleeWeapon_name + " has been updated!");
                    refreshMeleeWeapons();
                }
                else
                {
                    Object.meleeWeapon_name = NameMeleeWeaponTextBox.Text;
                    Object.crafted = CraftedMeleeWeaponCheckBox.Checked;
                    db.Update(Object);
                    db.SaveChanges();
                    MessageBox.Show("The melee weapon with the name: " + Object.meleeWeapon_name + " has been updated!");
                    refreshMeleeWeapons();
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void DeleteMeleeWeaponButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_meleeWeapon;
                var Object = db.MeleeWeapon.FirstOrDefault(x => x.id_meleeWeapon == id);//expresie linq
                string message = "Do you want to delete this melee weapon?";
                string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    db.Remove(Object);
                    db.SaveChanges();
                    MessageBox.Show("The melee weapon with the name: " + Object.meleeWeapon_name + " has been deleted!");
                    refreshMeleeWeapons();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void BackToWarframeTrackerFromMeleeWeaponsButton_Click(object sender, EventArgs e)
        {
            WarframeTracker warframe = new WarframeTracker();
            this.Hide();
            warframe.Show();
        }
    }
}
