using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RAM_and_CPU.Program;

namespace RAM_and_CPU
{
    public partial class Form1 : Form
    { 
      private PerformanceCounter cpuValue;
      private PerformanceCounter ramValue;
      int CPUTimerValue;
      int RAMTimerValue;
      int BookEmails;
      int IDValue;
      bool TimerActiveButton = false;
      DateTime DateMonit;
      DateTime Reflesh;

        public Form1()
        {
            InitializeComponent();
            InitialiseCPU();
            InitialiseRAM();
            timer1.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new DataProgramContext())
            {

                var query = from c in db.ListEmailsDB

                            select new { c.AdresseEmail };

                BookEmails = query.Count();
            }
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - RAM CPU");
            object o = key.GetValue("Password");
            key.Close();

            if (o == null)
            {
                MessageBox.Show("Musisz skonfigurować ustawienia konta email wysyłającego wiadomości", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            else if (BookEmails < 1)
            {
                MessageBox.Show("Musisz wprowadzić listę osób odbierających wiadomość - użyj menu", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                TimerActiveButton = true;
                DateMonit = DateTime.Now.AddSeconds(Convert.ToDouble(nUDCoIleSecond.Value));
                button1.Text = "Uruchomiony";

  
                toolStripStatusLabel1.Text = "Status: Uruchomiony";
                DateMonit = DateTime.Now;
                Reflesh = DateMonit.AddSeconds(Convert.ToInt32(nUDCoIleSecond.Value));
            }



            timer1.Start();
        }

        private void InitialiseCPU()
        {
            cpuValue = new PerformanceCounter("Processor",
                "% Processor Time",
                "_Total",
                true
                );

            RefleshDataInformation();
        }

        public void RefleshDataInformation()
        {
            using (var db = new DataProgramContext())
            {
                var query = from c in db.RAMCPUSAVE

                            select new { Id = c.ValueCpuAndRamId, c.Cpu, c.Ram, c.Time };

                var results = query.ToList();
                foreach (var item in results)
                {
                    numericUpDownCPU.Value = item.Cpu;
                    numericUpDownRAM.Value = item.Ram;
                    nUDCoIleSecond.Value = item.Time;
                    IDValue = item.Id;
                }

            }
        }


        private void InitialiseRAM()
        {
            ramValue = new PerformanceCounter("Memory", "Available MBytes", true);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            lczas.Text = DateTime.Now.ToLongTimeString();


            CPUTimerValue = Convert.ToInt32(cpuValue.NextValue());
            textBox1.Text = "CPU Usage: " + CPUTimerValue.ToString() +
            "%";
            RAMTimerValue = Convert.ToInt32(ramValue.NextValue());
            textBox2.Text = RAMTimerValue.ToString() + "MB";



            if (TimerActiveButton == true)
            {
               if (DateTime.Now >= Reflesh)
                {
                    Reflesh = DateTime.Now.AddSeconds(Convert.ToInt32(nUDCoIleSecond.Value));
  

                    if (RAMTimerValue < numericUpDownRAM.Value)

                    {
                        Microsoft.Win32.RegistryKey key;
                        key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - RAM CPU");
                        try
                        {

                            int port = Int32.Parse(key.GetValue("Port").ToString());
                            SmtpClient mailServer = new SmtpClient(key.GetValue("SMTP").ToString(), port);
                            mailServer.EnableSsl = true;

                            mailServer.Credentials = new System.Net.NetworkCredential(key.GetValue("Name").ToString(), key.GetValue("Password").ToString());

                            MailMessage msg = new MailMessage();
                            msg.From = new MailAddress(key.GetValue("Name").ToString(), key.GetValue("Signature").ToString());


                            using (var db = new DataProgramContext())
                            {

                                var query = from c in db.ListEmailsDB
                                            select new { c.AdresseEmail };

                                foreach (var item in query)
                                {

                                    msg.To.Add(item.AdresseEmail);
                                }

                            }
                            msg.IsBodyHtml = true;

                            msg.Subject = "Ticket - Wykryto zbyt małą dostępną ilość RAM, data: " + DateTime.Now.ToString() + "";
                            msg.Body = "Wykryto zbyt mała ilość dostępnej pamięci RAM: " + RAMTimerValue.ToString() + " MB  <br><br>";
                           

                            mailServer.Send(msg);
                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        key.Close();

                    }

                    if (CPUTimerValue > numericUpDownCPU.Value)
                    {
                        Microsoft.Win32.RegistryKey key;
                        key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - RAM CPU");
                        try
                        {

                            int port = Int32.Parse(key.GetValue("Port").ToString());
                            SmtpClient mailServer = new SmtpClient(key.GetValue("SMTP").ToString(), port);
                            mailServer.EnableSsl = true;

                            mailServer.Credentials = new System.Net.NetworkCredential(key.GetValue("Name").ToString(), key.GetValue("Password").ToString());

                            MailMessage msg = new MailMessage();
                            msg.From = new MailAddress(key.GetValue("Name").ToString(), key.GetValue("Signature").ToString());


                            using (var db = new DataProgramContext())
                            {

                                var query = from c in db.ListEmailsDB
                                            select new { c.AdresseEmail };

                                foreach (var item in query)
                                {

                                    msg.To.Add(item.AdresseEmail);
                                }

                            }
                            msg.IsBodyHtml = true;

                            msg.Subject = "Ticket - Wykryto zbyt duże obciążenie CPU, data: " + DateTime.Now.ToString() + "";
                            msg.Body = "Wykryto zbyt duże obciązenie: " + textBox1.Text + "<br><br>";


                            mailServer.Send(msg);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        key.Close();

                    }


                }

            }



        }

        private void KonfiguracjaKontaEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailConfigurations m = new EmailConfigurations();
            m.Show();
        }

        private void ListaEmailOdbiorcówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookEmails m = new BookEmails();
            m.Show();
        }

        private void InformacjaOAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dane kontaktowe i informacje o autorze znajdziesz na stronie www.mdwojak.pl. Czy odwiedzić teraz tę stronę?", "Informacja - autor", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("www.mdwojak.pl");
            }
        }

        private void GrafikaUżytaWProjekcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Elementy graficzne należą do www.icons8.com i oparte są na licencji: Creative Commons Attribution-NoDerivs 3.0 Unported. Czy chcesz wejść na stronę icons8.com?", "Informacja - grafika", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://icons8.com");
            }
        }

        private void BEditExt_Click(object sender, EventArgs e)
        {
            if (nUDCoIleSecond.Value >=10 || numericUpDownCPU.Value >= 1 || numericUpDownRAM.Value >= 1)
            {

                using (var db = new DataProgramContext())
                {
                    var result = db.RAMCPUSAVE.SingleOrDefault(b => b.ValueCpuAndRamId == IDValue);
                    if (result != null)
                    {
                        result.Cpu = Convert.ToInt32(numericUpDownCPU.Value);
                        result.Time = Convert.ToInt32(nUDCoIleSecond.Value);
                        result.Ram = Convert.ToInt32(numericUpDownRAM.Value);
                        db.SaveChanges();
                    }
                    else
                    {
                        var Record = new ValueCpuAndRam
                        {
                            Cpu = Convert.ToInt32(numericUpDownCPU.Value),
                            Ram = Convert.ToInt32(numericUpDownRAM.Value),
                            Time = Convert.ToInt32(nUDCoIleSecond.Value)
                        };
                        db.RAMCPUSAVE.Add(Record);
                        db.SaveChanges();

                    };
                }
                MessageBox.Show("Zapisano ustawienia!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie zapisano ustawień - podano niepoprawne wartości", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        }
    }

