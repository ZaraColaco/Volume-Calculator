using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Calculator__GUI_
{
    public partial class SphereCalculator : Form
    {
        public SphereCalculator()
        {
            InitializeComponent();
        }

        double radius = 0;
        bool validRad = false;
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            while (validRad == false)
            {
                string rad = textBoxSphereRadius.Text;
                if (double.TryParse(rad, out radius) && radius > 0)//Here we try to convert the string into a double and if that is possible we check the value is not less than 0 and if these conditions are met we se thte bool value to true
                {
                    radius = Convert.ToDouble(rad);
                    validRad = true;
                }
                else//if the conditions are not met we prompt the user to enter a positive number and the bool value is set to false and we go through the loop again and again untill it breaks and proceeds to the next section which only happens when the conditions are fulfilled
                {
                    textBoxSphereRadius.Clear();
                    MessageBox.Show("please enter a positive numeric value");
                    validRad = false;

                }
            }
            double sphereVolume = 4/3.0 * Math.PI * Math.Pow(radius, 3);
            labelSVol.Text = "The Volume of this sphere is " + Math.Round(sphereVolume,3) + "cm";
            buttonReplay.Visible = true;
        }

        private void buttonReplay_Click(object sender, EventArgs e)
        { textBoxSphereRadius.Clear();
            labelSVol.Text = "";
            buttonReplay.Hide();
            radius = 0;
            validRad = false;
        }
    }   }
