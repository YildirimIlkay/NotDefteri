using NotDefteri.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteri
{
    public partial class Form1 : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        Note duzenlenen;
        public Form1()
        {
            InitializeComponent();
            VerileriListele();
        }

        private void VerileriListele()
        {
            lstNotlar.DataSource = db.Notes.ToList();
            lstNotlar.DisplayMember = "Title";
            lstNotlar.ValueMember = "Id";
        }

        private void lstNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SeciliNotuAc();
        }

        private void SeciliNotuAc()
        {
            if (lstNotlar.SelectedIndex==-1)
            {
                duzenlenen = null;
                flpNotDefteri.Hide();
            }
            else
            {
                flpNotDefteri.Show();
                Note note =(Note)lstNotlar.SelectedItem;
                duzenlenen = note;
                txtBaslik.Text = note.Title;
                txtIcerik.Text = note.Content;
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            var yeniNot = new Note() { Title = "Yeni Not" };
            db.Notes.Add(yeniNot);
            db.SaveChanges();
            VerileriListele();
            lstNotlar.SelectedItem= yeniNot;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (duzenlenen == null)
            {
                return;
            }
            int id = duzenlenen.Id;
            duzenlenen.Title = txtBaslik.Text;
            duzenlenen.Content = txtIcerik.Text;
            db.SaveChanges();
            VerileriListele();
            lstNotlar.SelectedValue = id;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstNotlar.SelectedIndex ==-1)
            {
                return;
            }
            var note = (Note)lstNotlar.SelectedItem;
            db.Notes.Remove(note);
            db.SaveChanges();
            VerileriListele(); 
            lstNotlar.SelectedIndex =-1;
        }
    }
}
