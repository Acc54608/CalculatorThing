using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alex_Casper_CPT_185_Final
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            lblAbout.Text = "This is a simple calculator made by Alex Casper. It will only do calculations once you press equals. " +
                "Once equals is pressed with a calculation loaded, it will perform the calculations in the order they were entered. " +
                "It will also store any past calculations in the listbox until the program is closed. It was fun thinking about how to make the calculator work. " +
                "I wish I could have done something else, I wanted to make tetris but I didn't even know where to start, regardless thanks for taking a look at this program! " +
                "Also if you want to click the button to the left turn the system sound up first";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCelebrate_Click(object sender, EventArgs e)
        {
            SoundPlayer tada = new SoundPlayer(Properties.Resources.tada);
            tada.Play();
        }
    }
}