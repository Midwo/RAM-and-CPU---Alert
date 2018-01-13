using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAM_and_CPU
{
    public partial class Form1 : Form
    { 
      private PerformanceCounter cpuValue;
      private PerformanceCounter ramValue;
    
        public Form1()
        {
            InitializeComponent();
            InitialiseCPU();
            InitialiseRAM();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void InitialiseCPU()
        {
            cpuValue = new PerformanceCounter("Processor",
                "% Processor Time",
                "_Total",
                true
                );
        }

        private void InitialiseRAM()
        {
            ramValue = new PerformanceCounter("Memory", "Available MBytes", true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "CPU Usage: " + Convert.ToInt32(cpuValue.NextValue()).ToString() +
         "%";
            textBox2.Text = Convert.ToUInt32(ramValue.NextValue()).ToString() + "MB";

        }

        private void konfiguracjaKontaEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailConfigurations m = new EmailConfigurations();
            m.Show();
        }

        private void ListaEmailOdbiorcówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookEmails m = new BookEmails();
            m.Show();
        }

        private void informacjaOAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dane kontaktowe i informacje o autorze znajdziesz na stronie www.mdwojak.pl. Czy odwiedzić teraz tę stronę?", "Informacja - autor", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("www.mdwojak.pl");
            }
        }

        private void grafikaUżytaWProjekcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Elementy graficzne należą do www.icons8.com i oparte są na licencji: Creative Commons Attribution-NoDerivs 3.0 Unported. Czy chcesz wejść na stronę icons8.com?", "Informacja - grafika", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://icons8.com");
            }
        }
    }
}
