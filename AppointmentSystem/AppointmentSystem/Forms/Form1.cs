﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppointmentSystem.Model;


namespace AppointmentSystem
{
    public partial class Form1 : Form
    {
        DBSysAppointmentEntities1 db;

        public Form1()
        {
            InitializeComponent();
            db = new DBSysAppointmentEntities1();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DBSysAppointmentEntities1())
            {

                USER newUser = new USER
                {
                    FirstName = txtName,
                    LastName = txtLastName,
                    Contact = txtContact,
                    txtAddress = txtAddress,
                                          

                
                db.USER.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("User registered successfully!");
            }
        }



    }
}
