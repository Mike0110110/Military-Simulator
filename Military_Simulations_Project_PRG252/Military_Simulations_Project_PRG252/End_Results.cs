using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Military_Simulations_Project_PRG252
{
    public partial class End_Results : Form
    {
       
        public End_Results(string planeType, double CountDistance)
        {
            InitializeComponent();
            lblAirplaneType.Text = planeType;
            lblDistanceTraveled.Text = Convert.ToString(CountDistance / 10 + "Km");
            lblTime.Text = Convert.ToString(CountDistance / 60 + "Min");
            lblDamage.Text = "The airplane was hit and the barracks took damage, The Armoury was destroyed";
        }

        private void End_Results_Load(object sender, EventArgs e)
        {

        }
    }
}
