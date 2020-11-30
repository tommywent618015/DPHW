using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_1
{
    public partial class ReisInfoDisplay : Form , ITreinDisplay
    {
        TreinReis Reis;
        public ReisInfoDisplay(TreinReis reis)
        {
            InitializeComponent();
            this.Reis = reis;
            this.Reis.AddObserver(this);
            Show();
            this.Reis.VolgendStation();
        }

        public void Update(TreinStation station)
        {
            lbl_station.Text = station.Naam;
            lbl_spoor.Text = station.AankomstSpoor;
        }

        private void ReisInfoDisplay_Load(object sender, EventArgs e)
        {
            lbl_station.Text = "station";
            lbl_spoor.Text = "spoor";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
