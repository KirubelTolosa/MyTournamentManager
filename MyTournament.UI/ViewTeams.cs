﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTournament.UI
{
    public partial class frmViewTeams : Form
    {
        public frmViewTeams()
        {
            InitializeComponent();
        }

        private void ViewTeams_Load(object sender, EventArgs e)
        {
            LoadTeams();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTeams();
        }

        private void LoadTeams()
        {
            //load it to listViews
            listViewTeams.Items.Clear();
            foreach (var curr in Program.teamDirectory)
            {
                listViewTeams.Items.Add(curr.Id + "-" + curr.Name);
            }

            //Grid view binding option 1
            //load it to the grid view

            var dt = new DataTable();
           dt.Columns.Add(new DataColumn("Team Id", typeof(int)));
           dt.Columns.Add(new DataColumn("Team Name", typeof(string)));

            foreach(Team team in Program.teamDirectory)
            {
                var row = dt.NewRow();
                row["Team Name"] = team.Name;
                row["Team Id"] = team.Id;
                dt.Rows.Add(row);
            }

            gridViewTeams.DataSource = dt;
            
            //Grid view binding option 2

       
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            var frmAddTeam = new AddTeam();
            frmAddTeam.Show();
        }

      
    }
}
