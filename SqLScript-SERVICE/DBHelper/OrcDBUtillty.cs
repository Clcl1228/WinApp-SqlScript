﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using SqlScript_MODEL;

namespace DBHelperOracle
{
    public abstract class OracleHepler
    {
        /// <summary>
        /// 在构造函数中初始化其内容
        /// </summary>
        public static string _connectionString = SqlConnectionM.OracleConnString;
        //public static SqlConnection _sqlConnection = new SqlConnection(new SqlHelper()._connectionString);new SqlHelper()
        public OracleHepler()
        {
            _connectionString = SqlConnectionM.OracleConnString;
        }

        /// <summary>
        /// 根据_connectionString生成SqlConnection
        /// </summary>
        /// <returns></returns>

        public OracleConnection GetConnection()
        {
            OracleConnection con = new OracleConnection(_connectionString);
            try
            {
                con.Open();
            }
            catch
            {
                con = null;
            }
            return con;
        }

        #region ExecuteNonQuery
        /// <summary>
        /// 对连接执行Transact-SQL语句并返回受影响的行数
        /// </summary>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="isProcedure">第一个参数是否为存储过程名,true为是,false为否</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static int ExecuteNonQuery(string commandText, bool isProcedure, params OracleParameter[] paras)
        {
            OracleConnection con = new OracleConnection(_connectionString);
            OracleCommand cmd = new OracleCommand(commandText, con);

            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }

            cmd.Parameters.Clear();
            foreach (OracleParameter para in paras)
            {
                cmd.Parameters.Add(para);
            }
            try
            {
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// 对连接执行Transact-SQL语句并返回受影响的行数
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static int ExecuteNonQuery(string commandText, params OracleParameter[] paras)
        {
            return ExecuteNonQuery(commandText, false, paras);
        }

        /// <summary>
        /// 对连接执行Transact-SQL语句并返回受影响的行数
        /// </summary>
        /// <param name="trans">传递事务对象</param>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="isProcedure">第二个参数是否为存储过程名,true为是,false为否</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static int ExecuteNonQuery(OracleTransaction trans, string commandText, bool isProcedure, params OracleParameter[] paras)
        {

            OracleConnection con = trans.Connection;
            OracleCommand cmd = new OracleCommand(commandText, con);

            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }

            cmd.Parameters.Clear();
            foreach (OracleParameter para in paras)
            {
                cmd.Parameters.Add(para);
            }

            if (trans != null)
            {
                cmd.Transaction = trans;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (trans == null)
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// 对连接执行Transact-SQL语句并返回受影响的行数
        /// </summary>
        /// <param name="trans">传递事务对象</param>
        /// <param name="commandText">SQL语句</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public int ExecuteNonQuery(OracleTransaction trans, string commandText, params OracleParameter[] paras)
        {
            return ExecuteNonQuery(trans, commandText, false, paras);
        }
        #endregion

        #region ExecuteQueryScalar
        /// <summary>
        /// 执行查询，并返回查询结果集中的第一行第一列，忽略其它行或列
        /// </summary>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="isProcedure">第一个参数是否为存储过程名,true为是,false为否</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static object ExecuteQueryScalar(string commandText, bool isProcedure, params OracleParameter[] paras)
        {
            OracleConnection con = new OracleConnection(_connectionString);
            OracleCommand cmd = new OracleCommand(commandText, con);

            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }

            foreach (OracleParameter para in paras)
            {
                cmd.Parameters.Add(para);
            }

            try
            {
                con.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// 执行查询，并返回查询结果集中的第一行第一列，忽略其它行或列
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static object ExecuteQueryScalar(string commandText, params OracleParameter[] paras)
        {
            return ExecuteQueryScalar(commandText, false, paras);
        }

        /// <summary>
        /// 执行查询，并返回查询结果集中的第一行第一列，忽略其它行或列
        /// </summary>
        /// <param name="trans">传递事务对象</param>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="isProcedure">第二个参数是否为存储过程名,true为是,false为否</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>
        public static object ExecuteQueryScalar(OracleTransaction trans, string commandText, bool isProcedure, params OracleParameter[] paras)
        {
            OracleConnection con = trans.Connection;
            OracleCommand cmd = new OracleCommand(commandText, con);

            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }
            cmd.Parameters.Clear();
            foreach (OracleParameter para in paras)
            {
                cmd.Parameters.Add(para);
            }

            if (trans != null)
            {
                cmd.Transaction = trans;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (trans == null)
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// 执行查询，并返回查询结果集中的第一行第一列，忽略其它行或列
        /// </summary>
        /// <param name="trans">传递事务对象</param>
        /// <param name="commandText">SQL语句</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static object ExecuteQueryScalar(OracleTransaction trans, string commandText, params OracleParameter[] paras)
        {
            return ExecuteQueryScalar(trans, commandText, false, paras);
        }
        #endregion

        #region ExecuteDataReader
        /// <summary>
        /// 执行SQL，并返回结果集的只前进数据读取器
        /// </summary>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="isProcedure">第一个参数是否为存储过程名,true为是,false为否</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static OracleDataReader ExecuteDataReader(string commandText, bool isProcedure)
        {
            OracleConnection con = new OracleConnection(_connectionString);
            OracleCommand cmd = new OracleCommand(commandText, con);

            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                con.Close();
                throw;
            }

        }

        /// <summary>
        /// 执行SQL，并返回结果集的只前进数据读取器
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public OracleDataReader ExecuteDataReader(string commandText)
        {
            return ExecuteDataReader(commandText, false);
        }

        /// <summary>
        /// 执行SQL，并返回结果集的只前进数据读取器
        /// </summary>
        /// <param name="trans">传递事务对象</param>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="isProcedure">第二个参数是否为存储过程名,true为是,false为否</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static OracleDataReader ExecuteDataReader(OracleTransaction trans, string commandText, bool isProcedure, params OracleParameter[] paras)
        {
            OracleConnection con = trans.Connection;
            OracleCommand cmd = new OracleCommand(commandText, con);

            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }

            cmd.Parameters.Clear();
            foreach (OracleParameter para in paras)
            {
                cmd.Parameters.Add(para);
            }

            if (trans != null)
            {
                cmd.Transaction = trans;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                if (trans == null)
                {
                    con.Close();
                }
                throw;
            }

        }

        /// <summary>
        /// 执行SQL，并返回结果集的只前进数据读取器
        /// </summary>
        /// <param name="trans">传递事务对象</param>
        /// <param name="commandText">SQL语句</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static OracleDataReader ExecuteDataReader(OracleTransaction trans, string commandText, params OracleParameter[] paras)
        {
            return ExecuteDataReader(trans, commandText, false, paras);
        }
        #endregion

        #region ExecuteDataSet
        /// <summary>
        /// 执行SQL，并返回DataSet结果集
        /// </summary>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="isProcedure">第一个参数是否为存储过程名,true为是,false为否</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static DataSet ExecuteDataSet(string commandText, bool isProcedure, params OracleParameter[] paras)
        {
            OracleConnection con = new OracleConnection(_connectionString);
            OracleCommand cmd = new OracleCommand(commandText, con);

            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }

            foreach (OracleParameter para in paras)
            {
                cmd.Parameters.Add(para);
            }

            try
            {
                con.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// 执行SQL，并返回DataSet结果集
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static DataSet ExecuteDataSet(string commandText, params OracleParameter[] paras)
        {
            return ExecuteDataSet(commandText, false, paras);
        }

        /// <summary>
        /// 执行SQL，并返回DataSet结果集
        /// </summary>
        /// <param name="trans">传递事务对象</param>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="isProcedure">第二个参数是否为存储过程名,true为是,false为否</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static DataSet ExecuteDataSet(OracleTransaction trans, string commandText, bool isProcedure, params OracleParameter[] paras)
        {
            OracleConnection con = trans.Connection;
            OracleCommand cmd = new OracleCommand(commandText, con);

            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }

            cmd.Parameters.Clear();
            foreach (OracleParameter para in paras)
            {
                cmd.Parameters.Add(para);
            }

            if (trans != null)
            {
                cmd.Transaction = trans;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (trans == null)
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// 执行SQL，并返回DataSet结果集
        /// </summary>
        /// <param name="trans">传递事务对象</param>
        /// <param name="commandText">SQL语句</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static DataSet ExecuteDataSet(OracleTransaction trans, string commandText, params OracleParameter[] paras)
        {
            return ExecuteDataSet(trans, commandText, false, paras);
        }
        #endregion

        #region ExecuteDataTable

        /// <summary>
        /// 执行SQL，并返回DataTable结果集
        /// </summary>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="isProcedure">第一个参数是否为存储过程名,true为是,false为否</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        
        public static DataTable ExecuteDataTable(string commandText, bool isProcedure)
        {
            OracleConnection con = new OracleConnection(_connectionString);
            OracleCommand cmd = new OracleCommand(commandText, con);
            cmd.CommandTimeout = 1800;

            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// 执行SQL，并返回DataTable结果集
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static DataTable ExecuteDataTable(string commandText)
        {
            return ExecuteDataTable(commandText, false);
        }

        /// <summary>
        /// 执行SQL，并返回DataTable结果集
        /// </summary>
        /// <param name="trans">传递事务对象</param>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="isProcedure">第二个参数是否为存储过程名,true为是,false为否</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static DataTable ExecuteDataTable(OracleTransaction trans, string commandText, bool isProcedure, params OracleParameter[] paras)
        {
            OracleConnection con = trans.Connection;
            OracleCommand cmd = new OracleCommand(commandText, con);
            cmd.CommandTimeout = 1800;

            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }

            cmd.Parameters.Clear();
            foreach (OracleParameter para in paras)
            {
                cmd.Parameters.Add(para);
            }

            if (trans != null)
            {
                cmd.Transaction = trans;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (trans == null)
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// 执行SQL，并返回DataTable结果集
        /// </summary>
        /// <param name="trans">传递事务对象</param>
        /// <param name="commandText">SQL语句</param>
        /// <param name="paras">SqLParameter参数列表，0个或多个参数</param>
        /// <returns></returns>

        public static DataTable ExecuteDataTable(OracleTransaction trans, string commandText, params OracleParameter[] paras)
        {
            return ExecuteDataTable(trans, commandText, false, paras);
        }

        #endregion

        #region GetRowData

        public static DataRow GetRowData(string Sql)
        {
            DataRow DR = null;
            try
            {
                DataTable DT = ExecuteDataTable(Sql);
                if (DT.Rows.Count > 0)
                {
                    DR = DT.Rows[0];
                }
                return DR;
            }
            catch
            {
                return DR;
            }
        }
        #endregion


        public static bool ExistsTable(string tableName)
        {
            string sql = @"select count(1) from tab where tname ='"+ tableName + "'";
            object num=ExecuteQueryScalar(sql, new OracleParameter[] { new OracleParameter() });
            if (num.ToString() == "1")
                return true;
            else
                return false;
        }
    }
}