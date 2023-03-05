using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class FormAllPlayer : Form
    {
        List<Player> listPlaye = new List<Player>();
        public FormAllPlayer()
        {
            InitializeComponent();

           
            dataGridView1.DataSource = listPlaye;
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo= new FormInfo();
            formInfo.ShowDialog();

            if(formInfo.DialogResult == DialogResult.OK){
                Player newPlayer= formInfo.getPlayer();
                //Add new Player to List
                this.listPlaye.Add(newPlayer );


                this.dataGridView1. DataSource = null;
                this.dataGridView1.DataSource= listPlaye;
                //Add list to Datagrid view
                formInfo.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save data from list to CSV file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT |*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName !="")
            {
                using (StreamWriter writer = new StreamWriter("output.csv"))

                   
                {
                    foreach (Player item in listPlaye)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2}"));
                        
                }
            }
        }

        private void cloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
