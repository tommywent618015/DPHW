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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TreinReis reis = new TreinReis();      
        private void Btn_volgendstation_Click(object sender, EventArgs e)
        {
            TreinController controller = new TreinController(reis);
            controller.VolgendStation(reis);
            
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            ITreinDisplay display1 = new ReisInfoDisplay(reis);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
