﻿using DBHelperOracle;
using SqlScript_MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptService
{
    public class GenerateOracleString : GenerateSqlServiceMain
    {
        public override string GenerateSql(DataGridView dataGridView)
        {
            string rMsg = "", rSql = "";
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                string Name = item.Cells[0].Value == null ? "" : item.Cells[0].Value.ToString();
                string type = item.Cells[1].Value == null ? "" : item.Cells[1].Value.ToString();
                string msg = item.Cells[2].Value == null ? "" : item.Cells[2].Value.ToString();
                string table = item.Cells[3].Value == null ? SqlConnectionM.TableName : item.Cells[3].Value.ToString();
                string isNull = item.Cells[4].Value == null ? " NULL" : " NOT NULL";
                string def = item.Cells[5].Value == null ? "" : "DEFAULT " + item.Cells[5].Value.ToString();

                if (SqlConnectionM.Status == "1" && SqlConnectionM.ServerType=="Oracle")
                {
                    bool flag = OracleHepler.ExistsTable(table);
                    if (!flag) { throw new Exception("表" + table + "不存在"); }
                }
                if (table != "" && Name != "" && type != "")
                {
                    rSql += @"declare  cnt number;
begin
   SELECT COUNT(*) into cnt FROM cols WHERE table_name=UPPER('{0}') AND column_name=UPPER('{1}');
   if cnt=0 then
    execute immediate 'ALTER TABLE {0} ADD {1} {2} {3} {4} ';
  end if;
  cnt:=0;
end;" + "\r\n" + "";
                    rSql = string.Format(rSql, table, Name, type, isNull, def);
                    if (msg != "")
                    {
                        rMsg += @"comment  on  column  {0}.{1} is '{2}';"+ "\r\n"+"";
                        rMsg = string.Format(rMsg, table, Name, msg);
                    }
                }
            }

            return rSql + "\r\n" + rMsg;
        }
    }
}
