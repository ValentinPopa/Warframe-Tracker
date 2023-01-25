using DataAccess;
using Models;
using System.Data;

namespace WinFormsApp1.Forms
{
    public partial class Relics : Form
    {
        private DBContext db;
        public Relics()
        {
            InitializeComponent();
            db = new DBContext();
            refreshRelics();
        }
        private void refreshRelics()
        {
            try
            {
                BindingSource bs = new BindingSource();
                var query = from r in db.Relic orderby r.relic_name select new { r.id_relic, RelicName = r.relic_name, Common1 = r.common_1, Common2 = r.common_2, Common3 = r.common_3, Uncommon1 = r.uncommon_1, Uncommon2 = r.uncommon_2, Rare1 = r.rare_1 };
                bs.DataSource = query.ToList();
                ShowRelicsGridView.DataSource = bs;
                ShowRelicsGridView.Refresh();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void FindText(String text)
        {
            try
            {
                BindingSource bs = new BindingSource();
                var query = from r in db.Relic where r.common_1 == text || r.common_2 == text || r.common_3 == text || r.uncommon_1 == text || r.uncommon_2 == text || r.rare_1 == text orderby r.relic_name select new { ID = r.id_relic, RelicName = r.relic_name, Common1 = r.common_1, Common2 = r.common_2, Common3 = r.common_3, Uncommon1 = r.uncommon_1, Uncommon2 = r.uncommon_2, Rare1 = r.rare_1 };
                bs.DataSource = query.ToList();
                ShowRelicsGridView.DataSource = bs;
                ShowRelicsGridView.Refresh();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private Relic getId()
        {
            Relic? t = null;
            try
            {
                t = db.Relic.Find((int)ShowRelicsGridView.SelectedCells[0].Value);
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            return t;
        }
        private void CreateRelicButton_Click(object sender, EventArgs e)
        {
            try
            {
                string relic_name = RelicNameTextBox.Text;
                string common1 = Common1TextBox.Text;
                string common2 = Common2TextBox.Text;
                string common3 = Common3TextBox.Text;
                string uncommon1 = Uncommon1TextBox.Text;
                string uncommon2 = Uncommon2TextBox.Text;
                string rare1 = Rare1TextBox.Text;
                if (string.IsNullOrEmpty(RelicNameTextBox.Text) || string.IsNullOrEmpty(Common1TextBox.Text) || string.IsNullOrEmpty(Common2TextBox.Text) || string.IsNullOrEmpty(Common3TextBox.Text) || string.IsNullOrEmpty(Uncommon1TextBox.Text) || string.IsNullOrEmpty(Uncommon2TextBox.Text) || string.IsNullOrEmpty(Rare1TextBox.Text))
                    MessageBox.Show("You have to input a text in the TextBoxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Relic RelicAdd = new Relic() { relic_name = relic_name, common_1 = common1, common_2 = common2, common_3 = common3, uncommon_1 = uncommon1, uncommon_2 = uncommon2, rare_1 = rare1 };
                    db.Add(RelicAdd);
                    db.SaveChanges();
                    refreshRelics();
                    MessageBox.Show("The relic with the name: " + relic_name + " has been created!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void UpdateRelicButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_relic;
                var Object = db.Relic.FirstOrDefault(x => x.id_relic == id);
                Object.relic_name = RelicNameTextBox.Text;
                Object.common_1 = Common1TextBox.Text;
                Object.common_2 = Common2TextBox.Text;
                Object.common_3 = Common3TextBox.Text;
                Object.uncommon_1 = Uncommon1TextBox.Text;
                Object.uncommon_2 = Uncommon2TextBox.Text;
                Object.rare_1 = Rare1TextBox.Text;
                if (string.IsNullOrEmpty(RelicNameTextBox.Text) && string.IsNullOrEmpty(Common1TextBox.Text) && string.IsNullOrEmpty(Common2TextBox.Text) && string.IsNullOrEmpty(Common3TextBox.Text) && string.IsNullOrEmpty(Uncommon1TextBox.Text) && string.IsNullOrEmpty(Uncommon2TextBox.Text) && string.IsNullOrEmpty(Rare1TextBox.Text))
                    MessageBox.Show("You have to input a text in at least 1 TextBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    db.Update(Object);
                    db.SaveChanges();
                    refreshRelics();
                    MessageBox.Show("The relic with the name: " + Object.relic_name + " has been updated!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void DeleteRelicButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().id_relic;
                var Object = db.Relic.FirstOrDefault(x => x.id_relic == id);
                string message = "Do you want to delete this relic?";
                string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    db.Remove(Object);
                    db.SaveChanges();
                    refreshRelics();
                    MessageBox.Show("The relic with the name: " + Object.relic_name + " has been deleted!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void BackToWarframeTrackerFromRelicsButton_Click(object sender, EventArgs e)
        {
            WarframeTracker warframeTracker = new WarframeTracker();
            this.Hide();
            warframeTracker.Show();
        }
        private void ImportPartsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string relic_name = getId().relic_name;
                string common1 = getId().common_1;
                string common2 = getId().common_2;
                string common3 = getId().common_3;
                string uncommon1 = getId().uncommon_1;
                string uncommon2 = getId().uncommon_2;
                string rare1 = getId().rare_1;
                RelicNameTextBox.Text = relic_name;
                Common1TextBox.Text = common1;
                Common2TextBox.Text = common2;
                Common3TextBox.Text = common3;
                Uncommon1TextBox.Text = uncommon1;
                Uncommon2TextBox.Text = uncommon2;
                Rare1TextBox.Text = rare1;
                MessageBox.Show("Import done.");
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search = InputForSearchTextBox.Text;
            FindText(search);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            RelicNameTextBox.Text = null;
            Common1TextBox.Text = null;
            Common2TextBox.Text = null;
            Common3TextBox.Text = null;
            Uncommon1TextBox.Text = null;
            Uncommon2TextBox.Text = null;
            Rare1TextBox.Text = null;
        }
    }
}
