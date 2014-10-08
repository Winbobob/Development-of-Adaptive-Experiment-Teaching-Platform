using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SelfAdaptivePlatform.Model;
using System.Configuration;

namespace SelfAdaptivePlatform.DAL
{
    class SQLHelper
    {
        //SqlConnection对象用于建立连接
        SqlConnection mycon = new SqlConnection();

        //SqlCommand对象用于建立命令
        SqlCommand mycom = new SqlCommand();

        //用于保存连接字符串
        string strConnection = null;

        //构造函数，初始化连接
        public SQLHelper()
        {
            strConnection = ConfigurationManager.ConnectionStrings["SelfAdaptionConnectionString"].ToString();
            mycon.ConnectionString = strConnection;
            //mycon.ConnectionString = "Data Source=.;Initial Catalog=Chat;Integrated Security=True";
        }

        /**/
        /// <summary>
        /// 执行SQL语句或存储过程，返回数据集
        /// </summary>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="para">参数数组</param>
        /// <param name="type">执行类型</param>
        /// <returns></returns>
        public DataSet doExcuteForDataset(string commandText, SqlParameter[] para, CommandType type)
        {
            //定义DataSet存储返回数据集
            DataSet ds = new DataSet();

            //定义command命令
            mycom.CommandText = commandText;

            //判断是否有参数，有则循环赋值
            if (para != null)
            {
                for (int i = 0; i < para.Length; i++)
                {
                    mycom.Parameters.Add(para[i]);
                }
            }

            //确定执行类型（SQL语句还是存储过程）
            mycom.CommandType = type;

            try
            {
                //打开连接
                mycon.Open();

                //为command命令指定连接
                mycom.Connection = mycon;

                //执行command命令
                SqlDataAdapter da = new SqlDataAdapter(mycom);

                //填充数据集
                da.Fill(ds, "table1");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                //关闭连接
                mycon.Close();
                 

            }
            return ds;
        }

        /**/
        /// <summary>
        /// 执行SQL语句或存储过程，返回受影响的行数
        /// </summary>
        /// <param name="commandText">SQL语句或存储过程名</param>
        /// <param name="para">参数数组</param>
        /// <param name="type">执行类型</param>
        /// <returns></returns>
        public int doExceutForRowCount(string commandText, SqlParameter[] para, CommandType type)
        {
            //定义result用于存储返回值
            int result = -1;

            //定义command命令
            mycom.CommandText = commandText;

            //判断是否有参数，有则循环赋值
            if (para != null)
            {
                for (int i = 0; i < para.Length; i++)
                {
                    mycom.Parameters.Add(para[i]);
                }
            }

            //确定执行类型（SQL语句还是存储过程）
            mycom.CommandType = type;

            try
            {
                //打开连接
                mycon.Open();

                //为command命令指定连接
                mycom.Connection = mycon;

                //执行命令，返回受影响的行数
                result = mycom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                //关闭连接
                mycon.Close();
                 

            }
            return result;
        }

        /**/
        /// <summary>
        ///  执行一条SQL语句，返回数据库记录总数
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns></returns>
        public int CountSqlRecordNum(string tablename)
        {
            int recordnum = 0;//记录返回记录数
            mycom = new SqlCommand();
            mycom.Connection = mycon;

            try
            {
                mycon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from [" + tablename + "] order by Id desc", mycon);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                recordnum = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                mycon.Close();
                 

            }
            return recordnum;
        }


        /**/
        /// <summary>
        ///  执行一条SQL语句，返回第一行第一列的元素
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns></returns>
        public string doSqlForFirst(string strSql)
        {
            string result = null;//记录返回元素
            mycom = new SqlCommand();
            mycom.Connection = mycon;
            mycom.CommandText = strSql;

            try
            {
                mycon.Open();
                result = mycom.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                mycon.Close();
                 

            }
            return result;
        }

        /**/
        /// <summary>
        /// 执行一条SQL语句，返回受影响的行数
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns></returns>
        public int doSql(string strSql)
        {
            int result = -1;//记录受影响的行数

            //Command命令
            mycom = new SqlCommand();
            mycom.Connection = mycon;
            mycom.CommandText = strSql;

            //执行Command命令
            try
            {
                mycon.Open();
                result = Convert.ToInt32(mycom.ExecuteNonQuery());  //ExecuteNonQuery方法是执行更新语句的方法，如果向执行查询语句，应该用Command对象的ExecuteReader方法来取得结果集
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                mycon.Close();
                 

            }
            return result;
        }

        /**/
        /// <summary>
        /// 执行一条SQL语句，返回行数
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns></returns>
        public bool doSql2(string strSql)
        {
            bool result;//记录是否读到数据
            //Command命令
            mycom = new SqlCommand();
            mycom.Connection = mycon;
            mycom.CommandText = strSql;

            //执行Command命令
            try
            {
                mycon.Open();
                result = mycom.ExecuteReader().HasRows;  //ExecuteNonQuery方法是执行更新语句的方法，如果向执行查询语句，应该用Command对象的ExecuteReader方法来取得结果集
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                mycon.Close();
                 
            }
            return result;  //SqlDataReader.HasRows，如果返回true，则表示查询到了记录，否则表示没有符合条件的记录集
        }


        #region 执行带参数的sql语句（select语句），返回数据流
        /**/
        /// <summary>
        /// 执行带参数的sql语句（select语句），返回数据流
        /// </summary>
        /// <param name="cmdText">SQL语句</param>
        /// <param name="para">参数</param>
        /// <returns></returns>
        public SqlDataReader GetDRWithPara(string cmdText, SqlParameter[] para)
        {
            //创建Command
            mycom = new SqlCommand(cmdText, mycon);
            for (int i = 0; i < para.Length; i++)
            {
                mycom.Parameters.Add(para[i]);
            }

            /**/
            ///定义返回值
            SqlDataReader dr = null;
            try
            {
                /**/
                ///打开链接
                mycon.Open();
                /**/
                ///执行SQL语句 
                dr = mycom.ExecuteReader();
               
            }
            catch (SqlException ex)
            {
                /**/
                ///抛出异常
                throw new Exception(ex.Message, ex);
            }
            return dr;
           
        }
        #endregion
    }
}
