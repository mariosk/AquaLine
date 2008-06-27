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

        public WashForm(MainLibrary library)
        {
            InitializeComponent();
            this.library = library;
            this.library.SetAppTextBoxCallBack(this.textBoxBarCode, this);
            this.offers = this.library.GetAllOffers();
        }

        private void WashForm_Load(object sender, EventArgs e)
        {
            this.labelDateTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            this.pictureBoxClock.Image = library.getClockImage();
            this.pictureBoxBarcode.Image = library.getBarcodeImage();
            this.pictureBoxCost.Image = library.getCostImage();
            this.pictureBoxCustomer.Image = library.getCustImage();
        }

        private void FindUserInDatabase()
        {
            BarcodeCustomerObject barcodeCust;
            CustomerObject customerO;

            barcodeCust.OfferId = null;
            barcodeCust.DateRegistered = DateTime.Today;
            barcodeCust.BarcodeId = "";
            customerO.Name = null;
            customerO.LicensePlates = null;

            Object[] custObjects = this.library.GetCustomerWithBarcodeId(this.textBoxBarCode.Text.Trim());
            if (custObjects == null)
            {
                MainLibrary.dummyFrm.MsgBoxError("Δεν υπάρχει πελάτης με αυτή τη κάρτα! Πρέπει να ενεργοποιήσετε τη κάρτα σας.");
                return;
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
        }

        private void textBoxBarCode_TextChanged(object sender, EventArgs e)
        {
            if (MainLibrary.dummyFrm.IsTextBoxReady())
            {
                FindUserInDatabase();
                //MainLibrary.dummyFrm.MsgBox("changed to " + this.textBoxBarCode.Text);
            }
        }
    }
}