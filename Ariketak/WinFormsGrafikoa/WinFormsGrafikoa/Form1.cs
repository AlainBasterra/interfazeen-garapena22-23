﻿using Fromgrafikoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGrafikoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Datua> datuak = new List<Datua>();
            datuak.Add(new Datua() { Gakoa = 1, Balioa = 24 });
            datuak.Add(new Datua() { Gakoa = 2, Balioa = 31 });
            datuak.Add(new Datua() { Gakoa = 3, Balioa = 63 });
            var kontrolak =
           grafikoa1.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
            foreach (var kontrola in kontrolak)
            {
                kontrola.Titles[0].Text = "HELMUGA TURISTIKO NAGUSIAK";
                kontrola.DataSource = datuak;
                kontrola.Series[0].YValueMembers = "balioa";
                kontrola.Series[0].XValueMember = "gakoa";
                kontrola.DataBind();
            }
        }
    }
}
