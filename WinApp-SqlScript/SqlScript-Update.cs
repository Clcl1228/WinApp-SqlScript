﻿using Oracle.ManagedDataAccess.Client;
using ScriptService;
using SqlScript_MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_SqlScript
{
    public partial class SqlScript_Update : Form
    {
        DataService dataService = new DataService();

        public SqlScript_Update()
        {
            InitializeComponent();
        }

        private void SqlScript_Update_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (SqlConnectionM.ServerType == "SqlServer")
            {
                SqlDataReader dataReader = DBUtility.DbHelperSQL.GetAllTable();
                dt.Load(dataReader);
                dataReader.Close();
            }
            else if (SqlConnectionM.ServerType == "Oracle")
            {
                OracleDataReader dataReader = dataService.GetOracleAllTable();
                dt.Load(dataReader);
                dataReader.Close();
            }

            this.cboTable.DataSource = dt;
            this.cboTable.DisplayMember = "name";
            this.cboTable.ValueMember = "name";
            this.FormBorderStyle = FormBorderStyle.None;

            BindData();
        }
        private void BindData()
        {
            if (SqlConnectionM.ServerType == "SqlServer")
            {
                DataTable dt = dataService.GetSqlServerUpdateFieldToTable(this.cboTable.SelectedValue.ToString().Trim());
                this.gvdataRow.AutoGenerateColumns = true;
                this.gvdataRow.DataSource = dt;
                //this.gvdataRow.DataMember = "FieldName";
            }
            else
            {
                DataTable dt = dataService.GetOracleUpdateFieldToTable(this.cboTable.SelectedValue.ToString().Trim());
                this.gvdataRow.DataSource = dt;
            }

        }
    }
}
