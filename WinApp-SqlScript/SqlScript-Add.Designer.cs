﻿
namespace WinApp_SqlScript
{
    partial class SqlScript_Add
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
            this.components = new System.ComponentModel.Container();
            this.groupAdd = new System.Windows.Forms.GroupBox();
            this.gvdataRow = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIsNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupSql = new System.Windows.Forms.GroupBox();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnCreateSqlO = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delRow = new System.Windows.Forms.ToolStripMenuItem();
            this.添加行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearSql = new System.Windows.Forms.Button();
            this.btnClearGvData = new System.Windows.Forms.Button();
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvdataRow)).BeginInit();
            this.groupSql.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAdd
            // 
            this.groupAdd.Controls.Add(this.gvdataRow);
            this.groupAdd.Location = new System.Drawing.Point(12, 12);
            this.groupAdd.Name = "groupAdd";
            this.groupAdd.Size = new System.Drawing.Size(573, 397);
            this.groupAdd.TabIndex = 0;
            this.groupAdd.TabStop = false;
            this.groupAdd.Text = "添加字段内容";
            // 
            // gvdataRow
            // 
            this.gvdataRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdataRow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtName,
            this.txtFieldType,
            this.txtMsg,
            this.txtTable,
            this.txtIsNull,
            this.txtDefault});
            this.gvdataRow.Location = new System.Drawing.Point(6, 20);
            this.gvdataRow.Name = "gvdataRow";
            this.gvdataRow.RowTemplate.Height = 23;
            this.gvdataRow.Size = new System.Drawing.Size(553, 371);
            this.gvdataRow.TabIndex = 0;
            this.gvdataRow.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvdataRow_CellMouseDown);
            this.gvdataRow.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvdataRow_CellMouseEnter);
            this.gvdataRow.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvdataRow_RowsAdded);
            // 
            // txtName
            // 
            this.txtName.HeaderText = "字段名";
            this.txtName.Name = "txtName";
            this.txtName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtFieldType
            // 
            this.txtFieldType.HeaderText = "字段类型";
            this.txtFieldType.Name = "txtFieldType";
            this.txtFieldType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtFieldType.Width = 80;
            // 
            // txtMsg
            // 
            this.txtMsg.HeaderText = "字段注释";
            this.txtMsg.Name = "txtMsg";
            // 
            // txtTable
            // 
            this.txtTable.HeaderText = "表名(默认当前表)";
            this.txtTable.Name = "txtTable";
            this.txtTable.Width = 130;
            // 
            // txtIsNull
            // 
            this.txtIsNull.HeaderText = "是否必填";
            this.txtIsNull.Name = "txtIsNull";
            this.txtIsNull.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtIsNull.Width = 70;
            // 
            // txtDefault
            // 
            this.txtDefault.HeaderText = "默认值";
            this.txtDefault.Name = "txtDefault";
            // 
            // groupSql
            // 
            this.groupSql.Controls.Add(this.txtSql);
            this.groupSql.Location = new System.Drawing.Point(753, 12);
            this.groupSql.Name = "groupSql";
            this.groupSql.Size = new System.Drawing.Size(455, 397);
            this.groupSql.TabIndex = 1;
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
            this.txtSql.WordWrap = false;
            // 
            // btnAddRow
            // 
            this.btnAddRow.AccessibleName = "表名";
            this.btnAddRow.Location = new System.Drawing.Point(615, 93);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(100, 23);
            this.btnAddRow.TabIndex = 2;
            this.btnAddRow.Text = "添加行";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnCreateSqlO
            // 
            this.btnCreateSqlO.AccessibleName = "表名";
            this.btnCreateSqlO.Location = new System.Drawing.Point(615, 186);
            this.btnCreateSqlO.Name = "btnCreateSqlO";
            this.btnCreateSqlO.Size = new System.Drawing.Size(100, 23);
            this.btnCreateSqlO.TabIndex = 4;
            this.btnCreateSqlO.Text = "生成Oracle";
            this.btnCreateSqlO.UseVisualStyleBackColor = true;
            this.btnCreateSqlO.Click += new System.EventHandler(this.btnCreateSqlO_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "表名";
            this.button2.Location = new System.Drawing.Point(615, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "生成SqlServer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCreateSqlS);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delRow,
            this.添加行ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // delRow
            // 
            this.delRow.Name = "delRow";
            this.delRow.Size = new System.Drawing.Size(112, 22);
            this.delRow.Text = "删除";
            this.delRow.Click += new System.EventHandler(this.delRow_Click);
            // 
            // 添加行ToolStripMenuItem
            // 
            this.添加行ToolStripMenuItem.Name = "添加行ToolStripMenuItem";
            this.添加行ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.添加行ToolStripMenuItem.Text = "添加行";
            this.添加行ToolStripMenuItem.Click += new System.EventHandler(this.添加行ToolStripMenuItem_Click);
            // 
            // btnClearSql
            // 
            this.btnClearSql.AccessibleName = "表名";
            this.btnClearSql.Location = new System.Drawing.Point(615, 282);
            this.btnClearSql.Name = "btnClearSql";
            this.btnClearSql.Size = new System.Drawing.Size(100, 23);
            this.btnClearSql.TabIndex = 6;
            this.btnClearSql.Text = "清空Sql";
            this.btnClearSql.UseVisualStyleBackColor = true;
            this.btnClearSql.Click += new System.EventHandler(this.btnClearSql_Click);
            // 
            // btnClearGvData
            // 
            this.btnClearGvData.AccessibleName = "表名";
            this.btnClearGvData.Location = new System.Drawing.Point(615, 331);
            this.btnClearGvData.Name = "btnClearGvData";
            this.btnClearGvData.Size = new System.Drawing.Size(100, 23);
            this.btnClearGvData.TabIndex = 7;
            this.btnClearGvData.Text = "清空字段内容";
            this.btnClearGvData.UseVisualStyleBackColor = true;
            this.btnClearGvData.Click += new System.EventHandler(this.btnClearGvData_Click);
            // 
            // cboTable
            // 
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point(591, 44);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(156, 20);
            this.cboTable.TabIndex = 8;
            this.cboTable.SelectedValueChanged += new System.EventHandler(this.cboTable_SelectedValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "表名";
            this.btnSave.Location = new System.Drawing.Point(615, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "保存到文件";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SqlScript_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 421);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboTable);
            this.Controls.Add(this.btnClearGvData);
            this.Controls.Add(this.btnClearSql);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateSqlO);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.groupSql);
            this.Controls.Add(this.groupAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SqlScript_Add";
            this.Load += new System.EventHandler(this.SqlScript_Add_Load);
            this.groupAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvdataRow)).EndInit();
            this.groupSql.ResumeLayout(false);
            this.groupSql.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAdd;
        private System.Windows.Forms.GroupBox groupSql;
        private System.Windows.Forms.DataGridView gvdataRow;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnCreateSqlO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem delRow;
        private System.Windows.Forms.Button btnClearSql;
        private System.Windows.Forms.Button btnClearGvData;
        private System.Windows.Forms.ToolStripMenuItem 添加行ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFieldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn txtIsNull;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDefault;
    }
}