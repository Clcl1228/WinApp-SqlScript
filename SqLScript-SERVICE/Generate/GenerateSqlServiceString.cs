﻿using DBUtility;
using SqlScript_MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptService
{
    public class GenerateSqlServiceString : GenerateSqlServiceMain
    {
        public override string GenerateSql(DataGridView dataGridView)
        {
            string rMsg = "", rSql = "";
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                string Name = item.Cells[0].Value==null?"":item.Cells[0].Value.ToString();
                string type = item.Cells[1].Value == null ? "" : item.Cells[1].Value.ToString();
                string msg = item.Cells[2].Value == null ? "" : item.Cells[2].Value.ToString();
                string table = item.Cells[3].Value == null ? SqlConnectionM.TableName : item.Cells[3].Value.ToString();
                string isNull = item.Cells[4].Value == null ? " NULL" : " NOT NULL";
                string def = item.Cells[4].Value == null ? "" : "DEFAULT "+item.Cells[4].Value.ToString();

                if (SqlConnectionM.Status=="1")
                {
                    bool flag = DbHelperSQL.TabExists(table);
                    if (!flag) { throw new Exception("表" + table + "不存在"); }
                }
                if(table!="" && Name!="" && type!="" && msg != "")
                {
                    rSql += @"IF NOT EXISTS (select name from syscolumns where id=object_id(N'{0}') AND NAME='{1}')
BEGIN
  ALTER TABLE {0} ADD {1} {2} {3} {4}
END" + "\r\n" + "";
                    rSql = string.Format(rSql,table, Name, type,isNull, def);
                    rMsg += @"execute sp_addextendedproperty N'MS_Description', '{2}', N'" + SqlConnectionM.LoginName + "', N'dbo', N'table', N'{0}', N'column', N'{1}' \r\n";
                    rMsg = string.Format(rMsg, table, Name, msg);
                }
            }

            return rSql+"\r\n"+rMsg;
        }
    }
}