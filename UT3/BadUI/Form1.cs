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
            // If you hover, the box loses focus.
            this.textBox1.MouseHover += new EventHandler(TextBox1__Hover);

            // Textbox Leave event
            // deletes first and last letter of the name string in the textbox
            this.textBox1.Leave += new EventHandler(TextBox1__Leave);

            // Textbox key event 
            // deletes last typed letter unless it's the same letter.
            this.textBox1.KeyPress += new KeyPressEventHandler(TextBox1__KeyPress);

            // Green button click event
            // if text is full, change button text.
            // clear the textbox.
            this.greenButton.Click += new EventHandler(GreenButton__Click);

            // Submit button click event (menu item)
            // Reverse name string.
            // Bring ub label that says "You did it, {NAME}"
            // IF checkbox IS checked, bring up label saying "You did it wrong!"
            this.submitFormToolStripMenuItem.Click += new EventHandler(Submit__Click);

            // Exit button click event (menu item)
            this.exitProgramToolStripMenuItem.Click += new EventHandler(Exit__Click);

        }

        private void TextBox1__Hover(object sender, EventArgs e)
        {
            this.textBox1.Location = new Point(this.textBox1.Location.X, this.textBox1.Location.Y + 50);
            this.greenButton.Focus();
            if(this.textBox1.Location.Y >= 400)
            {
                this.textBox1.Location = new Point(150, 50);
            }
        }
        private void TextBox1__Leave(object sender, EventArgs e)
        {
            string inputText = this.textBox1.Text;
            if(inputText.Length > 3)
            {
                this.textBox1.Text = inputText.Substring(1, inputText.Length - 2);
            }
            else
            {
                this.textBox1.Text = "";
            }
        }
        private void TextBox1__KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if(this.textBox1.Text.Length > 0)
            {
                if (c != this.textBox1.Text[this.textBox1.Text.Length - 1])
                {
                    this.textBox1.Text = this.textBox1.Text.Substring(0, this.textBox1.Text.Length - 1);
                    this.textBox1.Select(this.textBox1.Text.Length, 0);
                }
            }
            
        }
        private void GreenButton__Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text.Length > 0)
            {
                this.textBox1.Clear();
                this.greenButton.Text = "CLEAR TEXTBOX!";
                this.label1.Visible = false;
            }
            else
            {
                this.label1.Visible = true;
            }
            
        }
        private void Submit__Click(object sender, EventArgs e)
        {
            this.resultLabel.Visible = true;
            if (!this.checkBox1.Checked && this.textBox1.Text.Trim().Length > 0)
            {
                this.resultLabel.Text = "YOU DID IT, " + this.textBox1.Text + "!!!";
            }
            else if (!this.checkBox1.Checked)
            {
                this.resultLabel.Text = "WRONG! FILL IN YOUR NAME!!";
            }
            else
            {
                this.resultLabel.Text = "... Read carefully and try again.";
            }
        }
        private void Exit__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
