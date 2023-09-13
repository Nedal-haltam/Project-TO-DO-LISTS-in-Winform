using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_TO_DO_LISTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private ListViewItem getitem(string title)
        {
            ListViewItem item = new ListViewItem(title);
            item.Group = getgroup(cbcatigory.Text);
            
            item.SubItems.Add(cbcatigory.SelectedItem.ToString());
            
            item.SubItems.Add(dtp.SelectionStart.ToString("dddd, dd MMMM yyyy"));

            return item;
        }


        private ListViewGroup getgroup(string s)
        {
            foreach(ListViewGroup group in listView1.Groups)
            {
                if (s.ToLower() == group.Header.ToLower())
                    return group;
            }

            return null;
        }

        private void load_groups()
        {
            foreach(string item in cbcatigory.Items)
            {
                add_new_group(item);
            }
        }


        public bool check_if_listed(string title)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if(item.Text == title)
                {
                    return true;
                }
            }

            return false;
        }




        private void add_new_group(string header)
        {
            ListViewGroup g = new ListViewGroup();
            g.Name = header;
            g.Header = header;
            listView1.Groups.Add(g);
        }



        private void updateprogress()
        {


            if (listView1.Items.Count == 0)
            {
                progressBar1.Value = 0;
                return;
            }


            progressBar1.Value = (int)((float)listView1.CheckedItems.Count / listView1.Items.Count * 100);
        }



        private bool not_valid()
        {
            return string.IsNullOrEmpty(gunaTextBox1.Text) || string.IsNullOrWhiteSpace(gunaTextBox1.Text) || check_if_listed(gunaTextBox1.Text)
                || !cbcatigory.Items.Contains(cbcatigory.Text) || !cbpriority.Items.Contains(cbpriority.Text);
        }



        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(not_valid())
            {
                MessageBox.Show("Item Already Added or Not Valid Item", "Invalid", MessageBoxButtons.OK);
                return;
            }


            ListViewItem item = getitem(gunaTextBox1.Text);


            listView1.Items.Add(item);
            item.ImageIndex = cbpriority.SelectedIndex;

            gunaTextBox1.Clear();
            cbcatigory.ResetText();
            cbpriority.ResetText();


            updateprogress();
        }



        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                e.Item.ForeColor = Color.DarkRed;
                e.Item.Text += " (Done)";
            }
            else
            {
                e.Item.ForeColor = default;
                e.Item.Text = e.Item.Text.Replace(" (Done)", "");
            }

            updateprogress();
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

            foreach(ListViewItem item in listView1.CheckedItems)
            {
                listView1.Items.Remove(item);
            }

            updateprogress();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cbcatigory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            load_groups();
        }



        private void btnmxmn_Click(object sender, EventArgs e)
        {
            if(WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                MinimumSize = Size;
                MaximumSize = Size;
            }

            else
            {
                WindowState = FormWindowState.Normal;
                MinimumSize = new Size(1373, 655);
                MaximumSize = new Size(1373, 655);
            }
        }

        private void editEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_title();

            if (item.Text == "no change")
                return;



            listView1.SelectedItems[0].Text = item.Text;
            listView1.SelectedItems[0].SubItems[1] = item.SubItems[1];
            listView1.SelectedItems[0].Group = getgroup(item.SubItems[1].Text);
            listView1.SelectedItems[0].SubItems[2] = item.SubItems[2];
            listView1.SelectedItems[0].ImageIndex = item.ImageIndex;

        }

        public static ListViewItem item;

        private void  change_title()
        {
            item = listView1.SelectedItems[0];

            Form2 frm2 = new Form2(item);
            frm2.ShowDialog();
        }




    }
}
