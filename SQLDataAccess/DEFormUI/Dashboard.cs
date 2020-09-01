using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEFormUI
{
    public partial class Dashboard : Form
    {
        List<Game> games = new List<Game>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();

            pictureBox1.Load(@"C:\Users\lexit\Desktop\DataEastDatabase\images\Data-East-logo.png");
        }

        private void UpdateBinding()
        {
            GameFoundDataGrid.DataSource = games;
        }

        private void GameFoundDataGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Title Button
        private void TitleButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            games = db.FullList(Text);

            UpdateBinding();

            pictureBox3.Load(@"C:\Users\lexit\Desktop\DataEastDatabase\images\NightSlashersTitle.jpg");
        }

        //Release Date Button
        private void ReleaseDateButtonClick(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            games = db.GameByDate(Text);

            UpdateBinding();

            pictureBox5.Load(@"C:\Users\lexit\Desktop\DataEastDatabase\images\Timeline.jpg");
        }

        // Hardware Type Button
        private void HardwareTypeButtonClick(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            games = db.GameByHardware(Text);

            UpdateBinding();

            pictureBox2.Load(@"C:\Users\lexit\Desktop\DataEastDatabase\images\DECOflyer.jfif");
        }


        // Genre Button
        private void GenreButtonClick(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            games = db.GameByGenre(Text);

            UpdateBinding();

            pictureBox4.Load(@"C:\Users\lexit\Desktop\DataEastDatabase\images\BadDudes.jfif");
        }
    }
}

  
