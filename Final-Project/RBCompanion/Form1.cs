using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBCompanion
{
    public partial class rbcCompanion : Form
    {
        List<Panel> panelList = new List<Panel>();
        List<Panel> panelBtnList = new List<Panel>();

        int numberOfOccupants = 20;
        public rbcCompanion()
        {
            InitializeComponent();

            setUpLists();

            this.OccupancyCountLabel.Text = numberOfOccupants.ToString();
            
            this.WelcomeLabel.Parent = this.WelcomePictureBox;
            this.WelcomeLabel.BackColor = Color.Transparent;


            this.HomeBtn.Click += new EventHandler(HomeBtn__Click);
            this.ClimbsBtn.Click += new EventHandler(ClimbsBtn__Click);
            this.ProfileBtn.Click += new EventHandler(ProfileBtn__Click);
            this.TimerBtn.Click += new EventHandler(TimerBtn__Click);
            this.LinksBtn.Click += new EventHandler(LinksBtn__Click);

            // Context menu buttons
            this.add1OccupantToolStripMenuItem.Click += new EventHandler(Add1OccupantToolStripMenuItem__Click);
            this.remove1OccupantToolStripMenuItem.Click += new EventHandler(Remove1OccupantToolStripMenuItem__Click);

        }

        private void setUpLists()
        {
            panelList.Add(this.homePanel);
            panelList.Add(this.climbsPanel);
            panelList.Add(this.profilePanel);
            panelList.Add(this.timerPanel);
            panelList.Add(this.linksPanel);

            panelBtnList.Add(this.homeBtnPanel);
            panelBtnList.Add(this.climbsBtnPanel);
            panelBtnList.Add(this.profileBtnPanel);
            panelBtnList.Add(this.timerBtnPanel);
            panelBtnList.Add(this.linksBtnPanel);

            panelList[0].BringToFront();
        }

        private void Add1OccupantToolStripMenuItem__Click(object sender, EventArgs e)
        {
            numberOfOccupants++;
            this.OccupancyCountLabel.Text = numberOfOccupants.ToString();
            if(numberOfOccupants >= 50)
            {
                this.OccupancyCountLabel.ForeColor = Color.Red;
            } else
            {
                this.verticalProgressBar1.Value = numberOfOccupants;
            }
        }
        private void Remove1OccupantToolStripMenuItem__Click(object sender, EventArgs e)
        {
            numberOfOccupants--;
            if (numberOfOccupants <= 50)
            {
                this.OccupancyCountLabel.ForeColor = Color.White;
                this.OccupancyCountLabel.Text = numberOfOccupants.ToString();
            }

            if(numberOfOccupants < 0)
            {
                numberOfOccupants = 0;
            }
            
            this.verticalProgressBar1.Value = numberOfOccupants;
        }

        private void HomeBtn__Click(object sender, EventArgs e)
        {
            selectPanel(0);
            //Highlight this button panel
        }

        private void ClimbsBtn__Click(object sender, EventArgs e)
        {
            selectPanel(1);
            // Show home panel + hide other panels
        }
        private void ProfileBtn__Click(object sender, EventArgs e)
        {
            selectPanel(2);
            // Show home panel + hide other panels
        }
        private void TimerBtn__Click(object sender, EventArgs e)
        {
            selectPanel(3);
            // Show home panel + hide other panels
        }
        private void LinksBtn__Click(object sender, EventArgs e)
        {
            selectPanel(4);
            // Show home panel + hide other panels
        }

        private void selectPanel(int btnPanelIndex)
        {
            for(int i = 0; i < panelList.Count; i++)
            {
                if(i ==  btnPanelIndex)
                {
                    //Selected color
                    panelBtnList[i].BackColor = Color.FromArgb(224, 224, 224);
                    panelList[i].BringToFront();
                } 
                else
                {
                    panelBtnList[i].BackColor = Color.Gray;
                }
            }
        }






        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
