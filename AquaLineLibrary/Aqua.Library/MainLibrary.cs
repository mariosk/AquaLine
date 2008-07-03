using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Drawing;
using System.Diagnostics;
using Microsoft.Win32;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Resources;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections;
using System.Security;
using System.Security.Cryptography;
using System.Drawing.Printing;

using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.IO.Compression;

namespace Aqua.Library
{
    #region -->MainLibrary->DUMMYFORM
    public partial class DummyForm : Form
    {
        private SerialPort serialPort;
        private IContainer components;
        private TextBox appTextBox;
        private Form appForm;
        private bool cleanTextBox;

        public DummyForm()
        {
            this.InitializeComponent();
        }

        public void InitializeCOMPort(string comPort)
        {
            try
            {
                MainLibrary.logger.info("MainLibrary", String.Join(",", System.IO.Ports.SerialPort.GetPortNames()) + " are found on your machine.");
                this.serialPort.Close();
                this.serialPort.PortName = comPort;
                this.serialPort.Open();
            }
            catch (Exception ex)
            {
                MainLibrary.dummyFrm.MsgBoxError("Δυστυχώς ήταν αδύνατο να γίνει σύνδεση με την " + comPort + ". Συνδέστε το scanner!");
                MainLibrary.logger.error("MainLibrary", ex.Message);
                return;
            }
        }

        public bool IsTextBoxReady()
        {
            if (this.serialPort.IsOpen)
                return (this.serialPort.BytesToRead == 0);
            else
                return true;
        }

        public void SetAppTextBoxCallback(TextBox c, Form f)
        {
            this.appTextBox = c;
            this.appForm = f;
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SetText(this.serialPort.ReadExisting());
        }

        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.            
            if (this.appTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.appForm.Invoke(d, new object[] { text });
            }
            else
            {
                if (cleanTextBox)
                    this.appTextBox.Text = "";
                this.appTextBox.Text += text;
                if (this.serialPort.BytesToRead == 0)
                {
                    cleanTextBox = true;
                }
                else
                {
                    cleanTextBox = false;
                }
            }
        }

        #region MESSAGE_BOXES
        public void MsgBox(string message)
        {
            MsgBoxInformation(message, "Πληροφορίες");
        }
        public void MsgBoxInformation(string message, string infoMessage)
        {
            MessageBox.Show(message, infoMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MsgBoxWarning(string message)
        {
            MessageBox.Show(message, "Προσοχή", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void MsgBoxError(string message)
        {
            MessageBox.Show(message, "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult MsgBoxQuestion(string message)
        {
            return MessageBox.Show(message, "Ερώτηση", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void MsgBox(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, buttons, icon);
        }
        #endregion

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 38400;
            this.serialPort.PortName = "COM2";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // DummyForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "DummyForm";
            this.ResumeLayout(false);

        }
    }
    #endregion

    public struct OffersObject
    {
        public String Id;
        public String Desc;
        public double Cost;
        public uint Visits;
    }

    public struct CustomerObject
    {
        public String Name;
        public String[] LicensePlates;
    }

    public struct BarcodeCustomerObject
    {
        public String BarcodeId;
        public String OfferId;
        public DateTime DateRegistered;
    }

    public class MainLibrary
    {
        #region --> Enumerators
        private enum Months
        {
            Ιανουάριος = 1,
            Φεβρουάριος = 2,
            Μάρτιος = 3,
            Απρίλιος = 4,
            Μάϊος = 5,
            Ιούνιος = 6,
            Ιούλιος = 7,
            Αύγουστος = 8,
            Σεπτέμβριος = 9,
            Οκτώβριος = 10,
            Νοέμβριος = 11,
            Δεκέμβριος = 12
        }
        #endregion

        #region --> Properties.Resources
        // Properties.Resources 
        // Strings
        public static String ResourcesCustomersTable = Properties.Resources.CustomersTable;
        #endregion

        #region --> Variables
        // Other        
        public static Logger logger;
        // Forms of the Application
        public static DummyForm dummyFrm;       
        // SQL SERVER Objects
        public SqlConnection globalSQLConnection;
        private SqlDataAdapter globalSQLAdapter;
        private DataSet globalSQLDataSet;
        private SqlDataAdapter globalLicensePlatesSQLAdapter;
        private DataSet globalLicensePlatesSQLDataSet;
        private SqlDataAdapter globalSQLOffersAdapter;
        private DataSet globalSQLOffersDataSet;

        #endregion        

        public DataTable RefreshLicensePlatesSQLConnection(string SQLQuery, string DBTable)
        {
            DataTable dataTable = null;
            try
            {
                this.globalLicensePlatesSQLDataSet.Clear();
                this.globalLicensePlatesSQLAdapter.Dispose();
                this.globalLicensePlatesSQLAdapter = null;
                this.globalLicensePlatesSQLAdapter = new SqlDataAdapter(SQLQuery, this.globalSQLConnection);
                this.globalLicensePlatesSQLAdapter.Fill(this.globalLicensePlatesSQLDataSet, DBTable);
                dataTable = this.globalLicensePlatesSQLDataSet.Tables[DBTable];
            }
            catch (Exception e)
            {
                logger.log(0, "RefreshLicensePlatesSQLConnection", e.Message);
            }

            return dataTable;
        }

        public DataTable RefreshSQLConnection(string SQLQuery, string DBTable)
        {
            DataTable dataTable = null;
            try
            {
                this.globalSQLDataSet.Clear();
                this.globalSQLAdapter.Dispose();
                this.globalSQLAdapter = null;
                this.globalSQLAdapter = new SqlDataAdapter(SQLQuery, this.globalSQLConnection);
                this.globalSQLAdapter.Fill(this.globalSQLDataSet, DBTable);
                dataTable = this.globalSQLDataSet.Tables[DBTable];
            }
            catch (Exception e)
            {
                logger.log(0, "RefreshSQLConnection", e.Message);
            }

            return dataTable;
        }

        public DataTable RefreshSQLOffersConnection(string SQLQuery, string DBTable)
        {
            DataTable dataTable = null;
            try
            {
                this.globalSQLOffersDataSet.Clear();
                this.globalSQLOffersAdapter.Dispose();
                this.globalSQLOffersAdapter = null;
                this.globalSQLOffersAdapter = new SqlDataAdapter(SQLQuery, this.globalSQLConnection);
                this.globalSQLOffersAdapter.Fill(this.globalSQLOffersDataSet, DBTable);
                dataTable = this.globalSQLOffersDataSet.Tables[DBTable];
            }
            catch (Exception e)
            {
                logger.log(0, "RefreshSQLOffersConnection", e.Message);
            }

            return dataTable;
        }

        #region Accessors of Images in public resources...
        public Bitmap getAquaImage()
        {
            return Properties.Resources.aquaImage;
        }
        
        public Bitmap getSaveImage()
        {
            return Properties.Resources.SaveImg;
        }

        public Bitmap getCostImage()
        {
            return Properties.Resources.CashImg;
        }

        public Bitmap getCustImage()
        {
            return Properties.Resources.CustomerImg;
        }

        public Bitmap getBarcodeImage()
        {
            return Properties.Resources.BarcodeImg;
        }

        public Bitmap getClockImage()
        {
            return Properties.Resources.ClockImg;
        }
        #endregion

        public Object[] GetCustomerWithBarcodeId(string barcodeId)
        {
            Object[] custObjects = new Object[2];
            CustomerObject customerO = new CustomerObject();
            BarcodeCustomerObject barcodeCust = new BarcodeCustomerObject();

            String SQLQuery = "SELECT * FROM " + Properties.Resources.BarcodeCustomersTable;            
            SQLQuery += " WHERE BARCODEID = '" + barcodeId + "'";
            DataTable DBTable = this.RefreshSQLConnection(SQLQuery, Properties.Resources.BarcodeCustomersTable);

            // there is no customer in barcodecust table...
            if (DBTable == null)
            {
                custObjects[0] = null;
                return custObjects;
            }

            if (DBTable.Rows.Count > 0)
            {
                barcodeCust.BarcodeId = DBTable.Rows[0]["BARCODEID"].ToString();
                barcodeCust.OfferId = DBTable.Rows[0]["OFFERID"].ToString();
                barcodeCust.DateRegistered = Convert.ToDateTime(DBTable.Rows[0]["DATEREGISTERED"].ToString());

                custObjects[0] = barcodeCust;                
                // find customer in SINGULAR's tables...               
                customerO = this.GetCustomerWithAbbreviation(DBTable.Rows[0]["ABBREVIATION"].ToString());
                if (customerO.Name != null)
                {
                    custObjects[1] = customerO;   
                }                                
                DBTable.Clear();
            }
           
            return custObjects;
        }

        public Object[] GetCustomerWithAbbreviationOrBarcodeId(string abbreviationId, string barcodeId)
        {
            Object[] custObjects = new Object[2];
            CustomerObject customerO = new CustomerObject();
            BarcodeCustomerObject barcodeCust = new BarcodeCustomerObject();

            // find customer in SINGULAR's tables...               
            customerO = this.GetCustomerWithAbbreviation(abbreviationId);
            if (customerO.Name == null)
            {
                return null;
            }
            custObjects[1] = customerO;
            
            String SQLQuery = "SELECT * FROM " + Properties.Resources.BarcodeCustomersTable;

            if (abbreviationId.Equals("") && !barcodeId.Equals(""))
                SQLQuery += " WHERE BARCODEID = '" + barcodeId + "'";
            if (!abbreviationId.Equals("") && barcodeId.Equals(""))
                SQLQuery += " WHERE ABBREVIATION = '" + barcodeId + "'";
            if (!abbreviationId.Equals("") && !barcodeId.Equals(""))
                SQLQuery += " WHERE ABBREVIATION = '" + abbreviationId + "' AND BARCODEID = '" + barcodeId + "'";               

            DataTable DBTable = this.RefreshSQLConnection(SQLQuery, Properties.Resources.BarcodeCustomersTable);            

            // there is no customer in barcodecust table...
            if (DBTable == null)
            {                
                custObjects[0] = null;                
                return custObjects;
            }

            if (DBTable.Rows.Count > 0)
            {
                barcodeCust.BarcodeId = DBTable.Rows[0]["BARCODEID"].ToString();
                barcodeCust.OfferId = DBTable.Rows[0]["OFFERID"].ToString();
                barcodeCust.DateRegistered = Convert.ToDateTime(DBTable.Rows[0]["DATEREGISTERED"].ToString());

                custObjects[0] = barcodeCust;
                custObjects[1] = customerO;

                DBTable.Clear();
            }

            return custObjects;
        }

        private CustomerObject GetCustomerWithAbbreviation(string abbreviationId)
        {
            CustomerObject customerO = new CustomerObject();

            String SQLQuery = "SELECT ID, NAME FROM " + Properties.Resources.CustomersTable +
                              " WHERE ABBREVIATION = '" + abbreviationId + "'";
            DataTable DBTable = this.RefreshSQLConnection(SQLQuery, Properties.Resources.CustomersTable);

            if (DBTable == null)
                return customerO;

            if (DBTable.Rows.Count > 0)
            {
                // find customer                
                customerO.Name = DBTable.Rows[0]["NAME"].ToString();

                // find license plates
                String SQLQueryL = "SELECT NAME FROM " + Properties.Resources.LicensePlatesTable +
                                   " WHERE CUAID = '" + DBTable.Rows[0]["ID"] + "'";
                DataTable DBTableL = this.RefreshLicensePlatesSQLConnection(SQLQueryL, Properties.Resources.LicensePlatesTable);

                if (DBTableL.Rows.Count > 0)
                {
                    customerO.LicensePlates = new String[DBTableL.Rows.Count];
                    int i = 0;
                    foreach (DataRow row in DBTableL.Rows)
                    {
                        customerO.LicensePlates[i] = row["NAME"].ToString();
                        i++;
                    }
                }

                DBTable.Clear();
                DBTableL.Clear();
            }

            return customerO;            
        }

        public List<OffersObject> GetAllOffers()
        {
            List<OffersObject> offersObjects = null;
            String SQLQuery = "SELECT * FROM " + Properties.Resources.BarcodeOffersTable;
            DataTable DBTable = this.RefreshSQLConnection(SQLQuery, Properties.Resources.BarcodeOffersTable);
            
            if (DBTable == null)
                return null;

            if (DBTable.Rows.Count > 0)
            {
                offersObjects = new List<OffersObject>(DBTable.Rows.Count);
                foreach (DataRow dataRow in DBTable.Rows)
                {
                    OffersObject o = new OffersObject();
                    o.Id = dataRow["ID"].ToString();
                    o.Desc = dataRow["DESCRIPTION"].ToString();
                    o.Cost = Convert.ToDouble(dataRow["COST"].ToString());
                    o.Visits = Convert.ToUInt16(dataRow["VISITS"].ToString());
                    offersObjects.Add(o);
                }                                
                DBTable.Clear();
            }

            return offersObjects;            
        }

        public DataTable GetAllCustomers()
        {
            String SQLQuery = "SELECT * FROM " + Properties.Resources.CustomersTable;
            return this.RefreshSQLConnection(SQLQuery, Properties.Resources.CustomersTable);
        }

        public int GetNumberOfVisits(string offerId)
        {
            String SQLQuery = "SELECT VISITS FROM ";
            SQLQuery += Properties.Resources.BarcodeOffersTable;
            SQLQuery += " WHERE ID = '" + offerId + "'";
            DataTable dbTable = this.RefreshSQLOffersConnection(SQLQuery, Properties.Resources.BarcodeCustomersHistoryTable);
            return Convert.ToInt32(dbTable.Rows[0]["VISITS"].ToString());
        }

        public DataTable GetCustomerHistory(string barcodeid)
        {
            String SQLQuery = "SELECT * FROM ";
            SQLQuery += Properties.Resources.BarcodeCustomersHistoryTable;
            SQLQuery += " WHERE BARCODEID = '" + barcodeid + "'";
            return this.RefreshSQLConnection(SQLQuery, Properties.Resources.BarcodeCustomersHistoryTable);
        }

        /*
        public int GetNextCustomerID()
        {
            String SQLQuery = "SELECT * FROM " + Properties.Resources.BarcodeCustomersTable;
            DataTable dataTable = this.RefreshSQLConnection(SQLQuery, Properties.Resources.BarcodeCustomersTable);
            if (dataTable != null)
            {
                return (dataTable.Rows.Count + 1);
            }
            return 1;
        }
        */

        public bool IsCustomerAlreadyRegistered(String barcodeId, String abbreviationId)
        {
            String SQLQuery = "SELECT * FROM " + Properties.Resources.BarcodeCustomersTable +
                              " WHERE BARCODEID = '" + barcodeId + "' AND ABBREVIATION = '" + abbreviationId + "'";
            DataTable dataTable = this.RefreshSQLConnection(SQLQuery, Properties.Resources.BarcodeCustomersTable);
            if (dataTable != null)
            {
                if (dataTable.Rows.Count >= 1)
                    return true;
            }
            return false;
        }

        public void UpdateBarcodeCustomers(String barcodeId, String abbreviationId, double cost)
        {
            String UpdateSQLQuery = "UPDATE " +
                        Properties.Resources.BarcodeCustomersTable +
                        " SET MONEYLEFT = @MONEYLEFT" +
                        " WHERE BARCODEID = '" + barcodeId + "' AND ABBREVIATION = '" + abbreviationId + "'";

            SqlCommand mySqlCommand = this.globalSQLConnection.CreateCommand();
            mySqlCommand.CommandText = UpdateSQLQuery;

            mySqlCommand.Parameters.Add("@MONEYLEFT", SqlDbType.Money);
            mySqlCommand.Parameters["@MONEYLEFT"].Value = cost;

            mySqlCommand.ExecuteNonQuery();
            mySqlCommand.Dispose();
        }

        public bool InsertIntoBarcodeCustomers(String barcodeId, String abbreviationId, String OfferId, DateTime dateRegistered, double cost)
        {
            String InsertSQLQuery = "INSERT INTO " +
                           Properties.Resources.BarcodeCustomersTable +
                           "(BARCODEID, ABBREVIATION, OFFERID, DATEREGISTERED, MONEYLEFT) VALUES(" +
                           "@BARCODEID, @ABBREVIATION, @OFFERID, @DATEREGISTERED, @MONEYLEFT)";

            SqlCommand mySqlCommand = this.globalSQLConnection.CreateCommand();
            mySqlCommand.CommandText = InsertSQLQuery;
            
            mySqlCommand.Parameters.Add("@BARCODEID", SqlDbType.VarChar);
            mySqlCommand.Parameters.Add("@ABBREVIATION", SqlDbType.VarChar);
            mySqlCommand.Parameters.Add("@OFFERID", SqlDbType.VarChar);
            mySqlCommand.Parameters.Add("@DATEREGISTERED", SqlDbType.DateTime);
            mySqlCommand.Parameters.Add("@MONEYLEFT", SqlDbType.Money);

            mySqlCommand.Parameters["@BARCODEID"].Value = barcodeId;
            mySqlCommand.Parameters["@ABBREVIATION"].Value = abbreviationId;
            mySqlCommand.Parameters["@OFFERID"].Value = OfferId;
            mySqlCommand.Parameters["@DATEREGISTERED"].Value = dateRegistered;
            mySqlCommand.Parameters["@MONEYLEFT"].Value = cost;

            try
            {
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Dispose();
            }
            catch (Exception)
            {
                MainLibrary.dummyFrm.MsgBoxError("Απέτυχε η εισαγωγή νέου πελάτη. Μήπως έχετε εισάγει ξανά με τον ίδιο κωδικό κάρτας;");
                return false;
            }
            return true;
        }

        public bool InsertIntoBarcodeHistory(string barcodeId, string offerId)
        {
            String InsertSQLQuery = "INSERT INTO " +
                           Properties.Resources.BarcodeCustomersHistoryTable +
                           "(BARCODEID, VISITDATE, OFFERID) VALUES(" +
                           "@BARCODEID, @VISITDATE, @OFFERID)";

            SqlCommand mySqlCommand = this.globalSQLConnection.CreateCommand();
            mySqlCommand.CommandText = InsertSQLQuery;

            mySqlCommand.Parameters.Add("@BARCODEID", SqlDbType.VarChar);
            mySqlCommand.Parameters.Add("@VISITDATE", SqlDbType.DateTime);
            mySqlCommand.Parameters.Add("@OFFERID", SqlDbType.VarChar);

            mySqlCommand.Parameters["@BARCODEID"].Value = barcodeId;
            mySqlCommand.Parameters["@VISITDATE"].Value = DateTime.Now;
            mySqlCommand.Parameters["@OFFERID"].Value = offerId;

            try
            {
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                MainLibrary.dummyFrm.MsgBoxError("Απέτυχε η εισαγωγή νέας πλύσης: " + ex.Message);
                return false;
            }
            return true;
        }

        public void DeleteBarcodeCustomer(string barcodeId, string abbreviationId)
        {
            String DeleteSQLQuery = "DELETE FROM " +
                                    Properties.Resources.BarcodeCustomersTable +
                                    " WHERE BARCODEID = '" + barcodeId + "' AND ABBREVIATION = '" + abbreviationId + "'";

            this.RefreshSQLConnection(DeleteSQLQuery, Properties.Resources.BarcodeCustomersTable);
        }

        public void DeleteBarcodeHistory(string barcodeId)
        {
            String DeleteSQLQuery = "DELETE FROM " +
                                    Properties.Resources.BarcodeCustomersHistoryTable +
                                    " WHERE BARCODEID = '" + barcodeId + "'";

            this.RefreshSQLConnection(DeleteSQLQuery, Properties.Resources.BarcodeCustomersHistoryTable);
        }

        public void InitializeSQLConnections(string IPAddress, string dbName)
        {
            this.globalSQLConnection = new SqlConnection(@"Data Source=" + IPAddress + @"\SQLEXPRESS;Initial Catalog=" + dbName + @";User ID=sa;Password=singular;Connect Timeout=10");            
            this.globalSQLAdapter = new SqlDataAdapter();
            this.globalSQLDataSet = new DataSet();
            this.globalLicensePlatesSQLAdapter = new SqlDataAdapter();
            this.globalLicensePlatesSQLDataSet = new DataSet();
            this.globalSQLOffersAdapter = new SqlDataAdapter();
            this.globalSQLOffersDataSet = new DataSet();
            try
            {
                this.globalSQLConnection.Open();
            }
            catch (Exception ex)
            {
                logger.log(1, "DCSLibrary", "Σφάλμα SQL Server - Η εφαρμογή θα τερματήσει" + ex.Message);
                dummyFrm.MsgBox(ex.Message, "Σφάλμα SQL Server - Η εφαρμογή θα τερματήσει", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        public void SetAppTextBoxCallBack(TextBox c, Form f)
        {
            dummyFrm.SetAppTextBoxCallback(c, f);
        }

        // base Constructor of my DLL library
        public MainLibrary(string LogFileName, string IpAddress, string dbName, string comPort)
        {
            logger = Logger.getInstance();
            logger.initialize(false, LogFileName);
            logger.info("MainLibrary", "Logger initialized");

            //this.Version = Process.GetCurrentProcess().MainModule.FileVersionInfo.FileVersion;            
            dummyFrm = new DummyForm();
            dummyFrm.InitializeCOMPort(comPort);
            InitializeSQLConnections(IpAddress, dbName);

            string ProcessName = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(ProcessName);
            if (processes.Length > 1)
            {
                dummyFrm.MsgBoxError("Η εφαρμογή εκτελείται ήδη!");
                Process.GetCurrentProcess().Kill();
            }
        }

    }
}