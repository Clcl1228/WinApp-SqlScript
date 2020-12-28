﻿
namespace WinApp_SqlScript
{
    partial class SqlScript_Del
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.btnClearSql = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreateSqlO = new System.Windows.Forms.Button();
            this.groupSql = new System.Windows.Forms.GroupBox();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.groupAdd = new System.Windows.Forms.GroupBox();
            this.gvdataRow = new System.Windows.Forms.DataGridView();
            this.cboDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.字段名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.字段注释 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.表名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupSql.SuspendLayout();
            this.groupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvdataRow)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTable
            // 
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point(622, 48);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(100, 20);
            this.cboTable.TabIndex = 16;
            this.cboTable.SelectedIndexChanged += new System.EventHandler(this.cboTable_SelectedIndexChanged);
            // 
            // btnClearSql
            // 
            this.btnClearSql.AccessibleName = "表名";
            this.btnClearSql.Location = new System.Drawing.Point(622, 307);
            this.btnClearSql.Name = "btnClearSql";
            this.btnClearSql.Size = new System.Drawing.Size(100, 23);
            this.btnClearSql.TabIndex = 14;
            this.btnClearSql.Text = "清空Sql";
            this.btnClearSql.UseVisualStyleBackColor = true;
            this.btnClearSql.Click += new System.EventHandler(this.btnClearSql_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "表名";
            this.button2.Location = new System.Drawing.Point(622, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "生成SqlServer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCreateSqlO
            // 
            this.btnCreateSqlO.AccessibleName = "表名";
            this.btnCreateSqlO.Location = new System.Drawing.Point(622, 188);
            this.btnCreateSqlO.Name = "btnCreateSqlO";
            this.btnCreateSqlO.Size = new System.Drawing.Size(100, 23);
            this.btnCreateSqlO.TabIndex = 12;
            this.btnCreateSqlO.Text = "生成Oracle";
            this.btnCreateSqlO.UseVisualStyleBackColor = true;
            this.btnCreateSqlO.Click += new System.EventHandler(this.btnCreateSqlO_Click);
            // 
            // groupSql
            // 
            this.groupSql.Controls.Add(this.txtSql);
            this.groupSql.Location = new System.Drawing.Point(753, 12);
            this.groupSql.Name = "groupSql";
            this.groupSql.Size = new System.Drawing.Size(455, 397);
            this.groupSql.TabIndex = 10;
            this.groupSql.TabStop = false;
            this.groupSql.Text = "Sql语句";
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(6, 20);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSql.Size = new System.Drawing.Size(443, 371);
            this.txtSql.TabIndex = 0;
            // 
            // groupAdd
            // 
            this.groupAdd.Controls.Add(this.gvdataRow);
            this.groupAdd.Location = new System.Drawing.Point(12, 12);
            this.groupAdd.Name = "groupAdd";
            this.groupAdd.Size = new System.Drawing.Size(590, 397);
            this.groupAdd.TabIndex = 9;
            this.groupAdd.TabStop = false;
            this.groupAdd.Text = "选择删除的字段";
            // 
            // gvdataRow
            // 
            this.gvdataRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdataRow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cboDel,
            this.字段名,
            this.字段注释,
            this.表名});
            this.gvdataRow.Location = new System.Drawing.Point(6, 20);
            this.gvdataRow.Name = "gvdataRow";
            this.gvdataRow.RowTemplate.Height = 23;
            this.gvdataRow.Size = new System.Drawing.Size(573, 371);
            this.gvdataRow.TabIndex = 0;
            // 
            // cboDel
            // 
            this.cboDel.HeaderText = "勾选删除";
            this.cboDel.Name = "cboDel";
            this.cboDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cboDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cboDel.Width = 80;
            // 
            // 字段名
            // 
            this.字段名.DataPropertyName = "column_name";
            this.字段名.HeaderText = "字段名";
            this.字段名.Name = "字段名";
            this.字段名.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.字段名.Width = 120;
            // 
            // 字段注释
            // 
            this.字段注释.DataPropertyName = "column_description";
            this.字段注释.HeaderText = "字段注释";
            this.字段注释.Name = "字段注释";
            this.字段注释.Width = 200;
            // 
            // 表名
            // 
            this.表名.DataPropertyName = "table_name";
            this.表名.HeaderText = "表名";
            this.表名.Name = "表名";
            this.表名.Width = 130;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "表名";
            this.btnSave.Location = new System.Drawing.Point(622, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "保存到文件";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SqlScript_Del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 421);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboTable);
            this.Controls.Add(this.btnClearSql);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateSqlO);
            this.Controls.Add(this.groupSql);
            this.Controls.Add(this.groupAdd);
            this.Name = "SqlScript_Del";
            this.Text = "SqlScript_Del";
            this.Load += new System.EventHandler(this.SqlScript_Del_Load);
            this.groupSql.ResumeLayout(false);
            this.groupSql.PerformLayout();
            this.groupAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvdataRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.Button btnClearSql;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreateSqlO;
        private System.Windows.Forms.GroupBox groupSql;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.GroupBox groupAdd;
        private System.Windows.Forms.DataGridView gvdataRow;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cboDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn 字段名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 字段注释;
        private System.Windows.Forms.DataGridViewTextBoxColumn 表名;
        private System.Windows.Forms.Button btnSave;
    }
}