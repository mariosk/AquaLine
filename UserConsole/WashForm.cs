using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aqua.Library;

namespace Aqua.User
{
    public partial class WashForm : Form
    {
        private MainLibrary library;
        private List<OffersObject> offers;
        private int selectedOffer;
        private bool readOnly;

        public WashForm(MainLibrary library, bool readOnly)
        {
            InitializeComponent();
            this.library = library;
            this.library.SetAppTextBoxCallBack(this.textBoxBarCode, this);
            this.offers = this.library.GetAllOffers();
            this.readOnly = readOnly;
        }

        private void WashForm_Load(object sender, EventArgs e)
        {
            this.comboBoxLicensePlates.DropDownStyle = ComboBoxStyle.DropDownList;            
            this.labelDateTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            this.pictureBoxClock.Image = library.getClockImage();
            this.pictureBoxBarcode.Image = library.getBarcodeImage();
            this.pictureBoxCustomer.Image = library.getCustImage();
            this.buttonWash.Visible = !this.readOnly;
        }

        private bool FindUserInDatabase()
        {
            BarcodeCustomerObject barcodeCust;
            CustomerObject customerO;

            barcodeCust.OfferId = null;
            barcodeCust.DateRegistered = DateTime.Today;
            barcodeCust.BarcodeId = "";
            customerO.Name = null;
            customerO.LicensePlates = null;

            Object[] custObjects = this.library.GetCustomerWithBarcodeId(this.textBoxBarCode.Text.Trim());
            if (custObjects == null || (custObjects[0] == null && custObjects[1] == null))
            {
                MainLibrary.dummyFrm.MsgBoxError("Δεν υπάρχει πελάτης με αυτή τη κάρτα! Πρέπει να ενεργοποιήσετε τη κάρτα σας.");
                return false;
            }

            if (custObjects[0] != null)
                barcodeCust = (BarcodeCustomerObject)custObjects[0];

            if (custObjects[1] != null)
                customerO = (CustomerObject)custObjects[1];

            if (barcodeCust.OfferId != null)
            {                
                // select the appropriate offer combo item
                for (int i = 0; i < this.offers.Count; i++)
                {
                    if (this.offers[i].Id.Equals(barcodeCust.OfferId))
                    {
                        this.textBoxOffer.Text = this.offers[i].Desc;
                        this.selectedOffer = i;
                        break;
                    }
                }
                this.textBoxDateRegistered.Text = barcodeCust.DateRegistered.ToLongDateString();
                this.textBoxDateRegistered.Text += ", ";
                this.textBoxDateRegistered.Text += barcodeCust.DateRegistered.ToLongTimeString();
                this.textBoxBarCode.Text = barcodeCust.BarcodeId;
            }

            if (customerO.Name != null)
                this.textBoxCustomerName.Text = customerO.Name;

            if (customerO.LicensePlates != null)
            {
                for (int i = 0; i < customerO.LicensePlates.Length; i++)
                    this.comboBoxLicensePlates.Items.Add(customerO.LicensePlates[i]);

                if (this.comboBoxLicensePlates.Items.Count > 0)
                    this.comboBoxLicensePlates.SelectedIndex = 0;
            }

            return true;
        }

        private void ClearAllTextBoxes(bool clearBarcodeToo)
        {
            if (clearBarcodeToo)
                this.textBoxBarCode.Text = "";
            this.textBoxCustomerName.Text = "";
            this.textBoxDateRegistered.Text = "";
            this.textBoxWashesLeft.Text = "";
            this.comboBoxLicensePlates.Text = "";
            this.textBoxOffer.Text = "";
            this.comboBoxLicensePlates.Items.Clear();
            this.dataGridViewHistory.DataSource = null;
            this.dataGridViewHistory.Refresh();
        }

        private void textBoxBarCode_TextChanged(object sender, EventArgs e)
        {            
            //MainLibrary.dummyFrm.MsgBox("changed to " + this.textBoxBarCode.Text);
            if (MainLibrary.dummyFrm.IsTextBoxReady())
            {
                this.ClearAllTextBoxes(false);
                if (!this.textBoxBarCode.Text.Trim().Equals(""))
                {
                    if (FindUserInDatabase())
                    {
                        DataTable dbTable = library.GetCustomerHistory(textBoxBarCode.Text.Trim());
                        this.dataGridViewHistory.DataSource = dbTable;
                        dataGridViewHistory.Columns[dbTable.Columns.IndexOf("BARCODEID")].Visible = false;
                        dataGridViewHistory.Columns[dbTable.Columns.IndexOf("OFFERID")].Visible = false;
                        dataGridViewHistory.Columns[dbTable.Columns.IndexOf("VISITDATE")].HeaderText = "Ημερομηνία";
                        dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        int offerVisits = this.library.GetNumberOfVisits(this.offers[this.selectedOffer].Id);
                        int visitsLeft = offerVisits - dbTable.Rows.Count;                        
                        this.textBoxWashesLeft.Text = visitsLeft.ToString();
                        if (visitsLeft <= 0)
                        {
                            this.buttonWash.Enabled = false;
                            MainLibrary.dummyFrm.MsgBoxError("Δυστυχώς δεν έχετε άλλες πλύσεις. Πρέπει να ανανεώσετε τη κάρτα σας!");
                        }
                        else
                        {
                            this.buttonWash.Enabled = true;
                        }
                    }
                }
            }
        }

        private void buttonWash_Click(object sender, EventArgs e)
        {
            if (textBoxBarCode.Text.Trim().Equals(""))
            {
                MainLibrary.dummyFrm.MsgBoxError("Πρέπει να περάσετε μια κάρτα από το scanner!");
                return;
            }

            DialogResult dr = MainLibrary.dummyFrm.MsgBoxQuestion("Είστε σίγουροι για το πλύσιμο;");
            if (dr == DialogResult.Yes)
            {
                if (this.library.InsertIntoBarcodeHistory(textBoxBarCode.Text.Trim(), this.offers[this.selectedOffer].Id))                    
                    MainLibrary.dummyFrm.MsgBoxInformation("Καταχωρήθηκε μια πλύση με επιτυχία!", "Καταχώρηση");
            }
            else
            {
                return;
            }
            this.ClearAllTextBoxes(true);
        }
      
        private void timer_Tick(object sender, EventArgs e)
        {
            this.labelDateTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
    }
}