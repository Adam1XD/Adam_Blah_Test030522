using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Blah_Test030522
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            SQL ok = new SQL();
            List<Info> test = ok.GetAll();
            test.ForEach(info =>
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                info.datum,
                info.cislo.ToString(),
                info.odberatel,
                info.nazev,
                info.pocet,
                info.cenazakus.ToString(),
                info.celkovacena.ToString(),
                info.DPH.ToString(),
                info.cenasDPH.ToString(),
                });

                listView1.Items.Add(item);

            });
        }
    }
}
