/**
 * author:lcknight
 * repo:https://github.com/LcKnight/.Net-ProjectDuringTheClass
 * email:819818746@qq.com
 * */
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
/*
 * Reference:https://blog.csdn.net/sl1990129/article/details/79559438
 */
namespace StuManageSys
{
    class SqliteOp
    {
        private int Existflag=0;

        //Connection
        public SQLiteConnection dbConnection;
        //Command
        private SQLiteCommand dbCommand;
        //dataReader
        private SQLiteDataReader dataReader;

        private SQLiteConnectionStringBuilder dbConnectionstr;
        private string logPath;
        //构造函数 负责查找数据库，建立数据库（连接）
        public SqliteOp(string ConnectionString)
        {
            //判断是否存在ConnectionString指定的数据库文件
            if (File.Exists(ConnectionString))
                Existflag = 1;
            try
            {
                logPath = "log.txt";
                dbConnection = new SQLiteConnection(ConnectionString);
                dbConnectionstr = new SQLiteConnectionStringBuilder();
                dbConnectionstr.DataSource = ConnectionString;
                //dbConnectionstr.Password = "admin";
                dbConnection.ConnectionString = dbConnectionstr.ToString();
                dbConnection.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public int GetExist()
        {
            return Existflag;
        }
       //析构函数，负责最终结束数据库连接的生命周期
        ~SqliteOp()
        {
            if(dbCommand != null)
            {
                dbCommand.Dispose();
            }
            dbCommand = null;
            if(dataReader != null)
            {
                dataReader.Dispose();
            }
            dataReader = null;
            //下面有问题 因为C#的垃圾回收机制会导致 dbConnection已经被销毁
            //但是并没有置为null
            //if(dbConnection != null)
            //{
            //    dbConnection.Close();
            //}
            if (dbConnection != null)
            {
                dbConnection.Dispose();
            }

            dbConnection = null;
        }
        //主动结束 dbConnection及其他command，reader的生命周期
        public void CloseConnection()
        {
            if (dbCommand != null)
            {
                dbCommand.Cancel();
            }
            dbCommand = null;
            if (dataReader != null)
            {
                dataReader.Close();
            }
            dataReader = null;
            if (dbConnection != null)
            {
                dbConnection.Close();
            }
            dbConnection = null;
        }
        public void log(string queryString)
        {

        }
        //执行Query语句
        public SQLiteDataReader ExecuteQuery(string queryString)
        {
            try
            {
                dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandText = queryString;
                dataReader = dbCommand.ExecuteReader();
                using (StreamWriter sw = new StreamWriter(logPath, true))
                {
                    sw.WriteLine(DateTime.Now + "  " + queryString);
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dataReader;
        }








        //C
        //create Table
        public SQLiteDataReader CreateTable(string tableName,string[] colNames, string[] colTypes)
        {
            string queryString = "Create Table  if not Exists " + tableName + "(" + colNames[0] + " " + colTypes[0];
            for(int i=1;i<colNames.Length; i++)
            {
                queryString += "," + colNames[i] + " " + colTypes[i];
            }
            queryString += " ) ";
            return ExecuteQuery(queryString);
        }

        //R
        public SQLiteDataReader ReadFullTable(string tableName)
        {
            string query = "Select * from " + tableName;
            return ExecuteQuery(query);
        }
        
        //U
        public SQLiteDataReader UpdateValues(string tableName,string[] colNames, string[] colValues, string key, string value, string operation)
        {
            if (colNames.Length != colValues.Length)
                throw new SQLiteException("列数和值的数量不等");
            string queryString = "Update " + tableName + " Set " + colNames[0] + "=" + "'" + colValues[0] + "'";
            for (int i = 1; i < colNames.Length; i++)
            {
                queryString += "," + colNames[i] + "=" + "'" + colValues[i] + "'";
            }
            /*
             * 此处我存在疑惑，update 中 如果字符串和数字皆有如何处理呢
             */

            queryString += " Where " + key + operation + "'" + value + "'";
            return ExecuteQuery(queryString);

        }

        //D
        //Delete
        public SQLiteDataReader DeleteValuesAnd(string tableName, string[] colNames, string[] colValues, string[] operations)
        {
            if (colNames.Length != colValues.Length || operations.Length != colNames.Length || operations.Length != colValues.Length)
                throw new SQLiteException("删除操作中的列数和对应列名数量不等，或者与操作数不等");
            string queryString = "Delete From " + tableName + " Where " + colNames[0] + operations[0] + "'" + colValues[0] + "'";
            for(int i=0;i<colNames.Length;i++)
            {
                queryString += " And " + colNames[i] + operations[i] + "'" + colValues[i] + "'";
            }
            return ExecuteQuery(queryString);
        }

        //I
        //Insert
        public SQLiteDataReader InsertValues(string tableName, string[] values)
        {
            int fieldCount = ReadFullTable(tableName).FieldCount;
            if (values.Length != fieldCount)
                throw new SQLiteException("插入值的数量不等于列数");
            string queryString = "Insert Into " + tableName + " Values (" + "'" + values[0] + "'";
            for (int i = 1; i < values.Length; i++)
            {
                queryString += "," + "'" + values[i] + "'";
            }
            queryString += ")";
            return ExecuteQuery(queryString);
        }
       



    }
}
