using DataAccess;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class WarframeTracker : Form
    {
        private DBContext? db;
        public WarframeTracker()
        {
            try
            {
                InitializeComponent();
                db = new DBContext();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void ShowWarframeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Warframes warframeShow = new Warframes();
                warframeShow.Show();
                this.Hide();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PrimaryWeapons primaryWeaponShow = new PrimaryWeapons();
                primaryWeaponShow.Show();
                this.Hide();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void SecondaryWeaponsButton_Click(object sender, EventArgs e)
        {
            try
            {
                SecondaryWeapons secondaryWeaponShow = new SecondaryWeapons();
                secondaryWeaponShow.Show();
                this.Hide();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void MeleeWeaponsButton_Click(object sender, EventArgs e)
        {
            try
            {
                MeleeWeapons meleeWeaponShow = new MeleeWeapons();
                meleeWeaponShow.Show();
                this.Hide();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void RelicsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Relics relics = new Relics();
                relics.Show();
                this.Hide();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}