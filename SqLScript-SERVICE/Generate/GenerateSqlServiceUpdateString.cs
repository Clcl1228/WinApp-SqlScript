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
    public class GenerateSqlServiceUpdateString : GenerateSqlServiceMain
    {
        SqlOrOracleFieldType fType = new SqlOrOracleFieldType();
        public override string GenerateSql(DataGridView dataGridView,string tName)
        {
            string rMsg = "", rSql = "", rUp = "";
            tName = tName.ToUpper();
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                string isDel = item.Cells["cboDel"].Value == null ? "" : item.Cells["cboDel"].Value.ToString();
                string name = item.Cells["字段名"].Value == null ? "" : item.Cells["字段名"].Value.ToString();
                string msg = item.Cells["字段描述"].Value == null ? "" : item.Cells["字段描述"].Value.ToString();
                string updateName = item.Cells["修改后字段名"].Value == null ? "" : item.Cells["修改后字段名"].Value.ToString();
                string table = item.Cells["表名"].Value == null ? tName : item.Cells["表名"].Value.ToString() == "" ? tName : item.Cells["表名"].Value.ToString().ToUpper();

                if (SqlConnectionM.Status == "1" && SqlConnectionM.ServerType == "SqlServer")
                {
                    bool flag = DbHelperSQL.TabExists(table);
                    if (!flag) { throw new Exception("表" + table + "不存在"); }
                }
                if (isDel == "True")
                {
                    
                    if (item.Cells["字段类型"].Value.ToString() != "")
                    {
                        string type = item.Cells["字段类型"].Value == null ? "" : GetFieldType(item.Cells["字段类型"].Value.ToString());
                        rSql += @"alter table {0} alter column {1} {2}"+ "\r\n";
                        rSql = String.Format(rSql, table, name, type);
                    }
                    
                    if (msg != "")
                    {
                        string sql = @"SELECT top 1  isnull(name,'')
FROM ::fn_listextendedproperty (NULL, 'user', 'dbo', 'table', '{0}', 'column',
default)
where objname = '{1}'
";
                        sql = String.Format(sql, table, name);
                        object value = DbHelperSQL.GetSingle(sql);
                        if(value!=null && value.ToString()== "MS_Description")
                        {
                            rMsg += "EXECUTE sp_updateextendedproperty 'MS_Description', '{2}', 'SCHEMA', 'dbo', 'table', '{0}', 'column', '{1}'"+ "\r\n";
                        }
                        else
                        {
                            rMsg += "EXECUTE sp_addextendedproperty 'MS_Description', '{2}', 'SCHEMA', 'dbo', 'table', '{0}', 'column', '{1}'"+ "\r\n";
                        }
                        rMsg = String.Format(rMsg, table, name, msg);
                    }
                    if (updateName != "")
                    {
                        rUp += "EXEC SP_RENAME '{0}.{1}','{2}'"+ "\r\n";
                    }
                    rUp = String.Format(rUp, table, name, updateName);
                }
            }
            if (rSql != "")
            {
                rSql = "--SqlServer修改字段类型" + "\r\n" + rSql;
            }
            if (rMsg != "")
            {
                rMsg = "--SqlServer修改注释" + "\r\n" + rMsg;
            }
            if (rUp != "")
            {
                rUp = "--SqlServer修改字段名" + "\r\n" + rUp;
            }
            return rSql + "\n\r" + rMsg + "\n\r" + rUp;
        }
        public string GetFieldType(string type)
        {
            return fType.OracleToSql(type.ToUpper());
        }
    }
}
