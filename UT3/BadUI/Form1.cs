using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            // Textbox MouseHover event
                // move location while hovering downward on Y axis.
                // If it reaches bottom, jump back to top

            // Textbox Leave event
                // deletes first and last letter of the name string in the textbox

            // Textbox key event 
                // deletes last typed letter unless it's the same letter.

            // Green button click event
                // if text is full, change button text.
                // clear the textbox.

            // Submit button click event (menu item)
                // Reverse name string.
                // Bring ub label that says "You did it, {NAME}"
                // IF checkbox IS checked, bring up label saying "You did it wrong!"

            // Exit button click event (menu item)
        }
    }
}
