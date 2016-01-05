using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSOTool
{
    public partial class Form1 : Form
    {
        CSO file;
        string FileName;
        bool Lock = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file = new CSO();

            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "Xenoverse Character Sound File (*.cso)|*.cso";
            browseFile.Title = "Browse for Character Sound File";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;

            file.Load(browseFile.FileName);

            cbChar.Items.Clear();
            for (int i = 0; i < file.Data.Length; i++)
                cbChar.Items.Add(file.Data[i].Char_ID.ToString() + " / Costume " + file.Data[i].Costume_ID.ToString());
        }

        private void cbChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lock = true;
            txtInfo1.Text = file.Data[cbChar.SelectedIndex].Paths[0];
            txtInfo2.Text = file.Data[cbChar.SelectedIndex].Paths[1];
            txtInfo3.Text = file.Data[cbChar.SelectedIndex].Paths[2];
            txtInfo4.Text = file.Data[cbChar.SelectedIndex].Paths[3];
         
            Lock = false;
        }

        private void txtInfo1_TextChanged(object sender, EventArgs e)
        {
            if (!Lock)
                file.Data[cbChar.SelectedIndex].Paths[0] = txtInfo1.Text;
        }

        private void txtInfo2_TextChanged(object sender, EventArgs e)
        {
            if (!Lock)
                file.Data[cbChar.SelectedIndex].Paths[1] = txtInfo2.Text;
        }

        private void txtInfo3_TextChanged(object sender, EventArgs e)
        {
            if (!Lock)
                file.Data[cbChar.SelectedIndex].Paths[2] = txtInfo3.Text;
        }

        private void txtInfo4_TextChanged(object sender, EventArgs e)
        {
            if (!Lock)
                file.Data[cbChar.SelectedIndex].Paths[3] = txtInfo4.Text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file.Save();
        }
    }
}
