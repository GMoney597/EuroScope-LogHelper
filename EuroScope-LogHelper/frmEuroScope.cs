using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroScope_LogHelper
{
    public partial class frmEuroScope : Form
    {
        static string fileAirports = @"C:\Users\Toni\Documents\EuroScope\airports.txt";
        Dictionary<string, string> airports = new Dictionary<string, string>();
        List<string> airportICAO = new List<string>();
        FileStream file;

        public frmEuroScope()
        {
            InitializeComponent();
            ImportAirports();
        }

        private void ImportAirports()
        {
            // file = new FileStream(fileAirports, FileMode.OpenOrCreate);
            StreamReader strReader = new StreamReader(fileAirports);
            string[] airportDetails;

            try
            {
                if (strReader.Peek() > 0)
                {
                    do
                    {
                        airportDetails = strReader.ReadLine().Split(',');
                        if (!airports.ContainsKey(airportDetails[5]))
                        {
                            airports.Add(airportDetails[5], airportDetails[2]);
                        }
                    } while (true);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }

            strReader.Close();

            var airportList = new AutoCompleteStringCollection();
            airportList.AddRange(airportICAO.ToArray());

            txtDestination.AutoCompleteCustomSource = airportList;
            txtDestination.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cmdClearance_Click(object sender, EventArgs e)
        {
            string clearance = "";

            clearance += txtCallsign.Text + ", Nürnberg Ground - Good Evening";
            clearance += "\nCleared to " + txtDestination.Text + "\nvia " + txtSid.Text + " Departure";
            clearance += "\nFlight planned Route - Initial FL70";
            clearance += "\nSQUAWK: " + txtSquawk.Text;
            clearance += "\nStartup approved";

            MessageBox.Show(clearance, "CLEARANCE for " + txtCallsign.Text);
        }

        private void cmdBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
