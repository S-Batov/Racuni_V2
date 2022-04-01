using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rauni_V2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        OleDbConnection MainConnection = new OleDbConnection();
        String errMsg = "";
        String q = "";

        private bool ConnectLocalDatabase(string ImeBaze)
        {
            string connetionString = "";
            try
            {
                connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ImeBaze + ";" + "Mode=ReadWrite;";
                MainConnection.ConnectionString = connetionString;
                if (!OpenDatabase())
                {
                    connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ImeBaze + ";" + "Mode=ReadWrite;";
                    MainConnection.ConnectionString = connetionString;
                    if (!OpenDatabase())
                    {
                        return false;
                    }
                }

                tsm_odspojiSe.Enabled = true;
                tsm_spojiSe.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }


        private bool OpenDatabase()
        {
            try
            {
                MainConnection.Open();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        private void tsm_spojiSe_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Odaberite bazu podataka";
            ofd.Filter = "Access Database (*.mdb) |*.mdb|Access Database (*.accdb) | *.accdb";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ConnectLocalDatabase(ofd.FileName);
            }
        }

        private void tsm_odspojiSe_Click(object sender, EventArgs e)
        {
            try
            {
                MainConnection.Close();
                tsm_odspojiSe.Enabled = false;
                tsm_spojiSe.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }

}
