using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RAM_and_CPU.Program;

namespace RAM_and_CPU
{
    public partial class BookEmails : Form
    {
        public BookEmails()
        {
            InitializeComponent();
            
        }
        public void Reflesh()
        {
            using (var db = new DataProgramContext())
            {
                var query = from c in db.ListEmailsDB

                            select new { Id = c.ListEmailsId, Adres_Email = c.AdresseEmail };

                var results = query.OrderByDescending(x => x.Id).ToList();

                dataGridView2.DataSource = results;
                this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void TBAddEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BAddEmail_Click(sender, null);
            }
        }

        private void BAddEmail_Click(object sender, EventArgs e)
        {
            if (tBAddEmail.Text.Trim() != string.Empty)
            {
                string text = tBAddEmail.Text;

                if (true == IsValid(tBAddEmail.Text))
                {
                    using (var db = new DataProgramContext())
                    {
                        var query = from c in db.ListEmailsDB
                                    where c.AdresseEmail == text
                                    select new { c.ListEmailsId, c.AdresseEmail };

                        if (query.ToList().Count < 1)
                        {
                            var UserFolderSave = new ListEmails { AdresseEmail = text };

                            db.ListEmailsDB.Add(UserFolderSave);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Dany adres już isnieje, żądanie nie zostało wprowadzone", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    Reflesh();
                }
                else
                {
                    MessageBox.Show("Zły format adresu email", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
          
            }
            else
            {
                MessageBox.Show("Wpisano pusty adres email", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void TBAdresDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BEdit_Click(sender, null);
            }
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            if (tBAdresEdit.Text.Trim() != string.Empty || tBAdresEdit.Text.Trim() != "")
            {
                int id = Convert.ToInt32(tBIDEdit.Text);
                string text = tBAdresEdit.Text;



                using (var db = new DataProgramContext())
                {
                    var result = db.ListEmailsDB.SingleOrDefault(b => b.ListEmailsId == id);
                    if (result != null)
                    {
                        db.Entry(result).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                    }
                }
            }

            Reflesh();
            this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            tBAdresDelete.Text = "";
            tBIDDelete.Text = "";
            tBIDEdit.Text = "";
            tBAdresEdit.Text = "";
        }

        private void TBAdresEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BEdit_Click(sender, null);
            }
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            if (tBAdresEdit.Text.Trim() != string.Empty)
            {
                string text = tBAdresEdit.Text;
                int id = Convert.ToInt32(tBIDEdit.Text);

                if (true == IsValid(tBAdresEdit.Text))
                {
                    using (var db = new DataProgramContext())
                    {
                        var result = db.ListEmailsDB.SingleOrDefault(b => b.ListEmailsId == id);
                        if (result != null)
                        {
                            result.AdresseEmail = tBAdresEdit.Text;
                            db.SaveChanges();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Zły format adresu email", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                Reflesh();

            }
            else
            {
                MessageBox.Show("Wpisano pusty adres email", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            tBAdresDelete.Text = tBAdresEdit.Text;
            this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bEdit.Enabled = true;
                bDelete.Enabled = true;

                tBIDEdit.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
                tBIDDelete.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();

                tBAdresEdit.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
                tBAdresDelete.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookEmails_Load(object sender, EventArgs e)
        {
            Reflesh();
        }
    }
    }

