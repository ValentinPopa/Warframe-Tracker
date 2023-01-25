using DataAccess;
using Models;
using System.Data;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class Warframes : Form
    {
        private DBContext db;
        public Warframes()
        {
            InitializeComponent();
            db = new DBContext();
            refreshWarframes();
        }
        private void refreshWarframes()
        {
            try
            {
                BindingSource bs = new BindingSource();
                var query = from w in db.Warframe orderby w.warframe_name select new { ID = w.id_warframe, WarframeName = w.warframe_name, Crafted = w.crafted };
                bs.DataSource = query.ToList();
                WarframeShowGridView.DataSource = bs;
                WarframeShowGridView.Refresh();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }   
        private Warframe getId()
        {
            Warframe? w = null;
            try
            {
                w = db.Warframe.Find((int)WarframeShowGridView.SelectedCells[0].Value);
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            return w;
        }
        private void ShowPartsWarframeButton_Click(object sender, EventArgs e)
        {
            WarframeParts warframePart = new WarframeParts();
            warframePart.Show();
            this.Hide();
        }
        private void CreateButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string WarframeName = WarframeNameTextBox.Text;
                bool Crafted = CraftedCheckBox.Checked;
                if (string.IsNullOrEmpty(WarframeNameTextBox.Text))
                    MessageBox.Show("You have to input a text in the TextBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Warframe WarframeAdd = new Warframe() { warframe_name = WarframeName, crafted = Crafted };
                    db.Add(WarframeAdd);
                    db.SaveChanges();
                    MessageBox.Show("The warframe with the name: " + WarframeName + " has been created!");
                    WarframePart WarframePartAdd = new WarframePart() { warframe_name = WarframeName, warframe_blueprint_owned = false, warframe_chassis_owned = false, warframe_neuroptics_owned = false, warframe_system_owned = false, warframe_blueprint_crafted = false, warframe_chassis_crafted = false, warframe_neuroptics_crafted = false, warframe_system_crafted = false };
                    db.Add(WarframePartAdd);
                    db.SaveChanges();
                    refreshWarframes();
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_warframe;
                var Object = db.Warframe.FirstOrDefault(x => x.id_warframe == id);//expresie linq
                if (Object.crafted == CraftedCheckBox.Checked && string.IsNullOrEmpty(WarframeNameTextBox.Text))
                {
                    MessageBox.Show("You have to input a text in the TextBox or modify Crafted Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (string.IsNullOrEmpty(WarframeNameTextBox.Text))
                {

                    Object.crafted = CraftedCheckBox.Checked;
                    db.Update(Object);
                    db.SaveChanges();
                    MessageBox.Show("The warframe with the name " + Object.warframe_name + " has been updated!");
                    refreshWarframes();
                }
                else
                {
                    Object.warframe_name = WarframeNameTextBox.Text;
                    Object.crafted = CraftedCheckBox.Checked;
                    db.Update(Object);
                    db.SaveChanges();
                    MessageBox.Show("The warframe with the name " + Object.warframe_name + " has been updated!");
                    refreshWarframes();
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_warframe;
                var Object = db.Warframe.FirstOrDefault(x => x.id_warframe == id);//expresie linq
                string message = "Do you want to delete this warframe?";
                string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    db.Remove(Object);
                    db.SaveChanges();
                    MessageBox.Show("The warframe with the name " + Object.warframe_name + " has been deleted!");
                    refreshWarframes();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void BackToWarframeTrackerFromWarframeButton_Click(object sender, EventArgs e)
        {
            WarframeTracker warframeTracker = new WarframeTracker();
            this.Hide();
            warframeTracker.Show();
        }
    }
}
