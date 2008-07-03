using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Aqua.Library;

namespace Aqua.Admin
{
    public partial class MainForm : Form
    {        
        private MainLibrary library;
        private List<OffersObject> offers;

        public MainForm(MainLibrary library)
        {
            InitializeComponent();
            this.library = library;
            this.library.SetAppTextBoxCallBack(this.textBoxBarCode, this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
            DataTable dbTable = this.library.GetCustomersFromDB();
            if (dbTable.Rows.Count > 0)
            {
                this.dataGridViewCustHistory.DataSource = dbTable;
                this.dataGridViewCustHistory.Refresh();
            }
            */

            this.labelDateTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();            
            this.pictureBoxClock.Image = library.getClockImage();
            this.pictureBoxBarcode.Image = library.getBarcodeImage();
            this.pictureBoxCost.Image = library.getCostImage();
            this.pictureBoxCustomer.Image = library.getCustImage();
            //this.buttonSaveCust.Image = library.getSaveImage();

        }

        private void buttonNewCust_Click(object sender, EventArgs e)        
        {
            this.textBoxBarCode.Text = "";
            this.textBoxAbbreviation.Text = "";
            this.textBoxCustomerName.Text = "";
            this.textBoxDateRegistered.Text = "";
            this.comboBoxLicensePlates.Items.Clear();         
            this.comboBoxLicensePlates.Text = "";
            //this.textBoxCost.Text = "";
            //this.textBoxWashes.Text = "";

            this.buttonSaveCust.Enabled = true;
            this.comboBoxOffers.Enabled = true;
            this.textBoxBarCode.Enabled = true;
            this.textBoxAbbreviation.Enabled = true;            
            offers = this.library.GetAllOffers();
            if (offers == null) 
            {
                MainLibrary.dummyFrm.MsgBoxError("Υπάρχει σημαντικό πρόβλημα με τον πίνακα προσφορών!");
                return;
            }

            foreach (OffersObject offerObj in offers)
            {
                this.comboBoxOffers.Items.Add(offerObj.Desc);
            }
            if (this.comboBoxOffers.Items.Count > 0)
                this.comboBoxOffers.SelectedIndex = 0;

            this.textBoxAbbreviation.Focus();
        }

        private void EnterPressed()
        {
            BarcodeCustomerObject barcodeCust;
            CustomerObject customerO;

            customerO.Name = null;
            customerO.LicensePlates = null;
            barcodeCust.DateRegistered = DateTime.Today;
            barcodeCust.OfferId = null;
            barcodeCust.BarcodeId = null;

            Object[] custObjects = this.library.GetCustomerWithAbbreviationOrBarcodeId(this.textBoxAbbreviation.Text.Trim(), this.textBoxBarCode.Text.Trim());
            if (custObjects == null)
            {
                MainLibrary.dummyFrm.MsgBoxError("Δεν υπάρχει πελάτης με αυτή τη συντομογραφία!");
                return;
            }

            if (custObjects[1] != null)
                customerO = (CustomerObject)custObjects[1];

            if (customerO.Name == null || customerO.Name.Trim().Equals(""))
            {
                MainLibrary.dummyFrm.MsgBoxError("Δεν υπάρχει πελάτης με αυτή τη συντομογραφία!");
                return;
            }

            if (custObjects[0] != null)
                barcodeCust = (BarcodeCustomerObject)custObjects[0];

            if (barcodeCust.OfferId != null)
            {
                MainLibrary.dummyFrm.MsgBoxInformation("Αυτός ο πελάτης έχει ήδη καταχωρηθεί!", "Πελάτης");
                // select the appropriate offer combo item
                for (int i = 0; i < this.offers.Count; i++)
                {
                    if (this.offers[i].Id.Equals(barcodeCust.OfferId))
                    {
                        this.comboBoxOffers.SelectedIndex = i;
                        break;
                    }
                }
                this.textBoxDateRegistered.Text = barcodeCust.DateRegistered.ToLongDateString();
                this.textBoxDateRegistered.Text += ", ";
                this.textBoxDateRegistered.Text += barcodeCust.DateRegistered.ToLongTimeString();
                this.textBoxBarCode.Text = barcodeCust.BarcodeId;

                DataTable dbTable = library.GetCustomerHistory(textBoxBarCode.Text.Trim());
                this.dataGridViewHistory.DataSource = dbTable;
                dataGridViewHistory.Columns[dbTable.Columns.IndexOf("BARCODEID")].Visible = false;
                dataGridViewHistory.Columns[dbTable.Columns.IndexOf("OFFERID")].Visible = false;
                dataGridViewHistory.Columns[dbTable.Columns.IndexOf("VISITDATE")].HeaderText = "Ημερομηνία";
                dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                int offerVisits = this.library.GetNumberOfVisits(this.offers[this.comboBoxOffers.SelectedIndex].Id);
                int visitsLeft = offerVisits - dbTable.Rows.Count;
                this.textBoxWashesLeft.Text = visitsLeft.ToString();
                if (visitsLeft <= 0)
                {                   
                    MainLibrary.dummyFrm.MsgBoxError("Δυστυχώς δεν έχετε άλλες πλύσεις. Πρέπει να ανανεώσετε τη κάρτα σας!");
                }
            }
            this.textBoxCustomerName.Text = customerO.Name;
            for (int i = 0; i < customerO.LicensePlates.Length; i++)
                this.comboBoxLicensePlates.Items.Add(customerO.LicensePlates[i]);

            if (this.comboBoxLicensePlates.Items.Count > 0)
                this.comboBoxLicensePlates.SelectedIndex = 0;
        }

        private void textBoxAbbreviation_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Enter is pressed
            if (e.KeyChar == (Char)Keys.Enter)
            {
                EnterPressed();
            }
        }

        private void comboBoxOffers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxOffers.SelectedIndex >= 0 && this.comboBoxOffers.SelectedIndex < this.offers.Count) 
            {
                this.textBoxCost.Text = this.offers[this.comboBoxOffers.SelectedIndex].Cost.ToString() + " EUR";
                this.textBoxWashesLeft.Text = this.offers[this.comboBoxOffers.SelectedIndex].Visits.ToString();
            }
            else 
            {
                this.textBoxCost.Text = "";
                this.textBoxWashesLeft.Text = "";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSaveCust_Click(object sender, EventArgs e)
        {
            if (textBoxBarCode.Text.Trim().Equals(""))
            {
                MainLibrary.dummyFrm.MsgBoxError("Πρέπει να δώσετε και ένα κωδικό κάρτας!");                    
                return;
            }

            if (this.library.IsCustomerAlreadyRegistered(textBoxBarCode.Text.Trim(), textBoxAbbreviation.Text.Trim()))
            {
                MainLibrary.dummyFrm.MsgBoxError("Δυστυχώς ο πελάτης υπήρχε. Αν θέλετε να αλλάξετε πακέτο προσφοράς πρέπει πρώτα να τον διαγράψετε!");
                return;
            }

            DialogResult dr = MainLibrary.dummyFrm.MsgBoxQuestion("Είστε σίγουροι για την αποθήκευση;");
            if (dr == DialogResult.Yes)
            {
                if (this.library.InsertIntoBarcodeCustomers(textBoxBarCode.Text.Trim(), textBoxAbbreviation.Text.Trim(),
                    this.offers[this.comboBoxOffers.SelectedIndex].Id.ToString(), DateTime.Now,
                    Convert.ToDouble(this.offers[this.comboBoxOffers.SelectedIndex].Cost.ToString())))
                    MainLibrary.dummyFrm.MsgBoxInformation("Αποθηκεύτηκε με επιτυχία!", "Αποθήκευση");
            }
            else
            {
                return;
            }
        }

        private void buttonDeleteCust_Click(object sender, EventArgs e)
        {
            if (textBoxBarCode.Text.Trim().Equals("") || textBoxAbbreviation.Text.Trim().Equals(""))
            {
                MainLibrary.dummyFrm.MsgBoxInformation("Βεβαιωθείτε οτι έχετε δώσει σωστό κωδικό κάρτας και συντομογραφίας!", "Διαγραφή");
                return;
            }

            if (!this.library.IsCustomerAlreadyRegistered(textBoxBarCode.Text.Trim(), textBoxAbbreviation.Text.Trim()))
            {
                MainLibrary.dummyFrm.MsgBoxError("Δυστυχώς ο πελάτης δεν υπάρχει για να διαγραφεί!");
                return;
            }

            DialogResult dr = MainLibrary.dummyFrm.MsgBoxQuestion("Είστε σίγουροι για την διαγραφή;");
            if (dr == DialogResult.Yes)
            {
                this.library.DeleteBarcodeCustomer(textBoxBarCode.Text.Trim(), textBoxAbbreviation.Text.Trim());
                this.library.DeleteBarcodeHistory(textBoxBarCode.Text.Trim());
                MainLibrary.dummyFrm.MsgBoxInformation("Διεγράφη με επιτυχία!", "Διαγραφή");
                this.buttonNewCust_Click(sender, e);
            }
            else
            {
                return;
            }
        }

        private void comboBoxLicensePlates_KeyPress(object sender, KeyPressEventArgs e)
        {
            MainLibrary.dummyFrm.MsgBox("test");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.labelDateTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}