using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents_Replica
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            // exit button disabled
            this.exitButton.Enabled = false;

            // set timer interval to 1 second ?
            this.timer1.Interval = 1000;

            // set webBrowser
            // set browser groupbox text
            // set image

            // radiobutton event handlers (PRESEDENT LIST)
            this.presRadio1.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio2.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio3.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio4.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio5.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio6.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio7.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio8.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio9.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio10.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio11.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio12.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio13.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio14.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio15.Click += new EventHandler(PresidentRadioButton__Click);
            this.presRadio16.Click += new EventHandler(PresidentRadioButton__Click);

            // radiobutton event handlers (FILTERS)
            this.filterRadioAll.Click += new EventHandler(FilterRadioButton__Click);
            this.filterRadioDemocrat.Click += new EventHandler(FilterRadioButton__Click);
            this.filterRadioDemRep.Click += new EventHandler(FilterRadioButton__Click);
            this.filterRadioFederalist.Click += new EventHandler(FilterRadioButton__Click);
            this.filterRadioRepublican.Click += new EventHandler(FilterRadioButton__Click);

            // timer tick event handler
            this.timer1.Tick += new EventHandler(Timer__Tick);

            // textbox keypress event handler
            this.presText1.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText2.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText3.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText4.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText5.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText6.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText7.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText8.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText9.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText10.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText11.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText12.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText13.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText14.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText15.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.presText16.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);

            // textbox leave event handler 
            this.presText1.Leave += new EventHandler(TextBox__Leave);
            this.presText2.Leave += new EventHandler(TextBox__Leave);
            this.presText3.Leave += new EventHandler(TextBox__Leave);
            this.presText4.Leave += new EventHandler(TextBox__Leave);
            this.presText5.Leave += new EventHandler(TextBox__Leave);
            this.presText6.Leave += new EventHandler(TextBox__Leave);
            this.presText7.Leave += new EventHandler(TextBox__Leave);
            this.presText8.Leave += new EventHandler(TextBox__Leave);
            this.presText9.Leave += new EventHandler(TextBox__Leave);
            this.presText10.Leave += new EventHandler(TextBox__Leave);
            this.presText11.Leave += new EventHandler(TextBox__Leave);
            this.presText12.Leave += new EventHandler(TextBox__Leave);
            this.presText13.Leave += new EventHandler(TextBox__Leave);
            this.presText14.Leave += new EventHandler(TextBox__Leave);
            this.presText15.Leave += new EventHandler(TextBox__Leave);
            this.presText16.Leave += new EventHandler(TextBox__Leave);

            // Image mouseEnter event
            this.pictureOfPresident.MouseEnter += new EventHandler(Image__MouseEnter);
            // Image mouseLeave event
            this.pictureOfPresident.MouseLeave += new EventHandler(Image__MouseLeave);

            // Exit button click event handler
            this.exitButton.Click += new EventHandler(ExitButton__Click);

        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            //if countdown = starting time
            {
                //start timer
            }

            // if typed not a number
            {
                // Do not show / enter the key in the textbox.
            }
        }
        private void TextBox__Leave(object sender, EventArgs e)
        {
            // if number != president's number
            {
                // dont let them leave,

                // Display error using error provider.
            }
            // Else if all numbers match
            {
                // End Timer
                
                // Switch to a video ( the video doesn't load for me)
            }

        }
        private void Timer__Tick(object sender, EventArgs e)
        {
            // if countdown = 1
            {
                //Stop timer
                
                // Clear all textboxes

                // reset progress bar
            }
            //else 
            {
                // tick down progress bar
            }
        }
        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FilterRadioButton__Click(object sender, EventArgs e)
        {
            // switch (Button Name)
            {
                //case All: make all visible
                //case Democrat: hide (1,6,9,10,11,13,14,15,16) show rest
                //case Republican: show (1,6,9,10,11,15) Hide rest
                //case DemRep: show 16 hide rest
                //case federalist: show 13 + 14 hide rest
            }
        }
        private void PresidentRadioButton__Click( object sender, EventArgs e)
        {
            // update web browser 
            
            // update groupbox text to url
            
            // update image
        }
        private void Image__MouseEnter(object sender, EventArgs e)
        {
            // resize image up
            this.pictureOfPresident.Size = new System.Drawing.Size(350, 420);
        }
        private void Image__MouseLeave(object sender, EventArgs e)
        {
            // resize Image down
            // 234 290
            this.pictureOfPresident.Size = new System.Drawing.Size(234, 290);
        }
    }
}
