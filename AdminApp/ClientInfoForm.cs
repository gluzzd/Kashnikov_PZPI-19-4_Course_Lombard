﻿using LibraryPawnShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class ClientInfoForm : Form
    {
        Client Client;
        PawnShop Shop;
        List<Deposit> Deposits;
        List<Product> Products = new List<Product>();
        bool IsClient;

        public ClientInfoForm(Client client, PawnShop shop, bool isClient = false)
        {
            InitializeComponent();
            Client = client;
            Shop = shop;
            IsClient = isClient;
            productBindingSource1.DataSource = Products;
            if (IsClient == false)
            {
                InfoNameBox.Text = Client.Name;
                InfoAgeBox.Text = Convert.ToString(Client.Age);
                InfoEmailBox.Text = Client.Email;
                InfoPasswordBox.Text = Client.Password;
                InfoRankBox.Text = Convert.ToString(Client.Rank);
                BuyOutButton.Hide();
                LoanBox.Hide();
            }
            else
            {
                MainInfoBox.Hide();
                CurrentDeposit.Show();
            }
            Deposits = Shop.FindDepositsByClient(Client);
            if (Deposits.Count != 0)
            {
                depositBindingSource.DataSource = Deposits;
                productBindingSource.DataSource = Deposits[0].Products;
                DateTimeBox.Text = Deposits[0].DateTime.ToString();
                DateTimeBuyOutBox.Text = Deposits[0].DateTimeBuyOut.ToString();

            }
            else
                BuyOutButton.Enabled = false;
        }

        private void DepositComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (var dep in Deposits)
            {
                if (dep.Name == DepositComboBox.Text)
                {
                    productBindingSource.ResetBindings(false);
                    productBindingSource.DataSource = dep.Products;
                    DateTimeBox.Text = dep.DateTime.ToString();
                    DateTimeBuyOutBox.Text = dep.DateTimeBuyOut.ToString();
                }
            }

        }

        private void BuyOut_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string name = DepositComboBox.Text;
                if (DepositComboBox.Text != "")
                {
                    Shop.Deposits.RemoveAt(Shop.IndOfDepByName(name));
                    Deposits = Shop.FindDepositsByClient(Client);
                    depositBindingSource.DataSource = Deposits;
                    productBindingSource.DataSource = null;
                }
                Shop.IsDirty = true;
            }
            if (Deposits.Count == 0) BuyOutButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoanForm loan = new LoanForm(Products);
            if (loan.ShowDialog() == DialogResult.OK)
            {
                productBindingSource1.ResetBindings(false);
            }
        }

        private void ClientInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Shop.IsDirty == true)
            {
                var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        Shop.Save();
                        Application.OpenForms[0].Close();
                        break;
                    case DialogResult.No:
                        Application.OpenForms[0].Close();
                        break;
                }
            }
            else  
            {
                Application.OpenForms[0].Show();
            }
        }

        private void GetLoan_Click(object sender, EventArgs e)
        {
            if (Products.Count == 0)
            {
                MessageBox.Show("You must add at least one item!");
                return;
            }
            else if (DepositName.Text == "")
            {
                MessageBox.Show("You must enter Deposit's name!");
                return;
            }
            string name = DepositName.Text;
            Deposit dep = new Deposit(Products, Client) { Name = name};
            Shop.Deposits.Add(dep);
            Products.Clear();
            productBindingSource1.DataSource = null;
            Deposits = Shop.FindDepositsByClient(Client);
            depositBindingSource.DataSource = Deposits;
            Shop.IsDirty = true;
            BuyOutButton.Enabled = true;
        }
    }
}
