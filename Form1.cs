using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Class_Project_Chapter_9
{
    public partial class Form1 : Form
    {
        //Calling the form object
        public Form1()
        {
            InitializeComponent();
        }

        //Toss Button Event Handler
        private void tossButton_Click(object sender, EventArgs e)
        {
            //Create a new coin object
            Coin myCoin = new Coin();

            //Clear the list box
            outputListBox.Items.Clear();

            //Toss the coin five times
            for (int count = 0; count < 5; count++)
            {
                //Toss the coin
                myCoin.Toss();

                //Display the side up
                outputListBox.Items.Add(myCoin.GetSideUp());
            }

        }

        //Exit Button Event Handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
