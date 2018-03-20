using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTimer
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            MenuItem exit = new MenuItem();
           // Show(m); 
            
        }
        
    
        private void Form1_Load(object sender, EventArgs e)
        {
            //timer interval
            t.Interval = 100;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //get current time 
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            int ms = DateTime.Now.Millisecond;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            time += ":";

            if (ms < 10)
            {
                time += "0" + ms;
            }
            else
            {
                time += ms;
            }

            label1.Text = time;
        }
        
    }
}






