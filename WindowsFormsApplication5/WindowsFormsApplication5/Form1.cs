using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myOleDbDataAdapter;

        string customerIndex;
        int shipperIndex, employeesIndex;
        bool chkCustomers = false, chkShippers = false;

        BindingSource bsOrders = new BindingSource();

        private const string myConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Kele\Documents\Visual Studio 2015\Projects\WindowsFormsApplication5\WindowsFormsApplication5\Northwind.MDB";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Orders' table. You can move, or remove it, as needed.
            // this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            // TODO: This line of code loads data into the 'northwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            //this.employeesTableAdapter.Update("All");
            // TODO: This line of code loads data into the 'northwindDataSet.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.northwindDataSet.Shippers);
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            dgwContent.DataSource = bsOrders;
            customerIndex = cbCustomers.SelectedValue.ToString();
            shipperIndex = cbShippers.SelectedIndex + 1;
            employeesIndex = cbEmployees.SelectedIndex + 1;


        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerIndex = cbCustomers.SelectedValue.ToString();
            Refresh();
        }

        private void cbShippers_SelectedIndexChanged(object sender, EventArgs e)
        {
            shipperIndex = cbShippers.SelectedIndex + 1;
            Refresh();
        }
        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeesIndex = cbEmployees.SelectedIndex + 1;
            Refresh();
        }

        private void Refresh()
        {
            using (myConnection = new OleDbConnection(myConnectionString))
            {
                myConnection.Open();

                using (myOleDbDataAdapter = new OleDbDataAdapter())
                {
                    DataSet dataSet = new DataSet();

                    if (chkCustomers == false && chkShippers == false)
                    {
                        myOleDbDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Orders WHERE CustomerID='" + customerIndex + "' AND EmployeeID=" + employeesIndex + " AND ShipVia=" + shipperIndex, myConnection);
                    }
                    if (chkCustomers == true && chkShippers == false)
                    {
                        myOleDbDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Orders WHERE EmployeeID=" + employeesIndex + " AND ShipVia=" + shipperIndex, myConnection);
                    }
                    if (chkCustomers == false && chkShippers == true)
                    {
                        myOleDbDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Orders WHERE CustomerID='" + customerIndex + "' AND EmployeeID=" + employeesIndex, myConnection);
                    }
                    if (chkCustomers == true && chkShippers ==true)
                    {
                        myOleDbDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Orders WHERE EmployeeID=" + employeesIndex, myConnection);
                    }
                    myOleDbDataAdapter.Fill(dataSet, "Orders");
                    bsOrders.DataSource = dataSet;
                    bsOrders.DataMember = "Orders";


                    myConnection.Close();

                }
            }
        }

        private void checkBoxShippers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShippers.Checked)
                chkShippers = true;
            else
                chkShippers = false;
            Refresh();
        }

        private void checkBoxCustomers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustomers.Checked)
                chkCustomers = true;
            else
                chkShippers = false;
            Refresh();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            using (myConnection = new OleDbConnection(myConnectionString))
            {
                myConnection.Open();

                using (myOleDbDataAdapter = new OleDbDataAdapter())
                {
                    DataSet dataSet = new DataSet();

                    myOleDbDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Orders", myConnection);
                    myOleDbDataAdapter.Fill(dataSet, "Orders");
                    bsOrders.DataSource = dataSet;
                    bsOrders.DataMember = "Orders";

                    myConnection.Close();
                }
            }
        }
    }
}
