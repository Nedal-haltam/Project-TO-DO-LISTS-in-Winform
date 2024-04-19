using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TO_DO_LISTS
{
    public partial class Form2 : Form
    {
        public Form2(ListViewItem item)
        {
            InitializeComponent();

            textBox1.Text = item.Text;
            cbcatigory.Text = item.SubItems[1].Text;
            dtp.SelectionStart = DateTime.Parse(item.SubItems[2].Text);
            cbdificulty.SelectedIndex = item.ImageIndex;
        }




        private bool not__valid(string t)
        {
            if(string.IsNullOrEmpty(t) || string.IsNullOrWhiteSpace(t))
            {
                return true;
            }
            return false;
        }



        private bool not_valid()
        {
            return not__valid(textBox1.Text) || not__valid(cbcatigory.Text) || not__valid(dtp.SelectionStart.ToString("dddd, dd MMMM yyyy"));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (not_valid())
            {
                MessageBox.Show("Item Already Added or Not Valid Item", "Invalid", MessageBoxButtons.OK);
                return;
            }

            ListViewItem item = new ListViewItem(textBox1.Text);

            item.SubItems.Add(cbcatigory.Text);
            item.SubItems.Add(dtp.SelectionStart.ToString("dddd, dd MMMM yyyy"));
            item.ImageIndex = cbdificulty.SelectedIndex;


            Form1.item = item;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.item = new ListViewItem("no change");
            this.Close();
        }

    }
}
