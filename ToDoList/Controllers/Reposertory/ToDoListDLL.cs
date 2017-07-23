using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using ToDoListLibrary.Entity.ToDoList;
using System.Web.Configuration;
using System.Data;

namespace ToDoListLibrary.Controllers.Reposertory.ToDoList
{
    /// <summary>
    /// To Do Read, Update, Delete
    /// </summary>
    public class ToDoListDLL
    {
        /// <summary>
        /// Read one content entity
        /// </summary>
        /// <param name="fld_ID"></param>
        /// <returns></returns>
        public ContentEntity ReadEntity(string fld_ID)
        {
            ContentEntity entity = null;
            string strSql = "SELECT Top 1 *  FROM tb_ListContent WITH(NO LOCK) WHERE fld_ID=@fld_ID ";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings.ToString();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql);
                    SqlParameter parameter = new SqlParameter();
                    cmd.Connection = conn;
                    cmd.Parameters.Add(new SqlParameter("@fld_ID", Convert.ToInt32(fld_ID)));
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        entity.fld_ID = dr["fld_ID"].ToString();
                        entity.fld_Content = dr["fld_Content"].ToString();
                        entity.fld_CreateDate = DateTime.Parse(dr["fld_ID"].ToString());
                    }
                }
                catch (Exception)
                {
                    // handle Exception
                }
            }
            return entity;
        }
        /// <summary>
        /// Read one content entity
        /// </summary>
        /// <returns></returns>
        public List<ContentEntity> ReadAllContentEntity()
        {
            List<ContentEntity> listContentEntity = new List<ContentEntity>();
            string strSql = "SELECT * FROM tb_ListContent WITH(NO LOCK)";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings.ToString();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql);
                    cmd.Connection = conn;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ContentEntity entity = new ContentEntity();
                        entity.fld_ID = dr["fld_ID"].ToString();
                        entity.fld_Content = dr["fld_Content"].ToString();
                        entity.fld_CreateDate = DateTime.Parse(dr["fld_ID"].ToString());
                        listContentEntity.Add(entity);
                    }
                }
                catch (Exception)
                {
                    // handle Exception
                }
            }
            return listContentEntity;
        }
        /// <summary>
        /// Insert a Todo content
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public bool InsertContent(string content)
        {
            bool isSuccess = false;
            List<ContentEntity> listContentEntity = new List<ContentEntity>();
            string strSql = "INSERT INTO tb_ListContent (fld_Content) VALUES(@fld_Content)";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings.ToString();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql);
                    cmd.Parameters.Add(new SqlParameter("@fld_Content", content));
                    cmd.Connection = conn;
                     
                    if (cmd.ExecuteNonQuery()>0)
                    {
                        isSuccess = true;
                    }
                }
                catch (Exception)
                {
                    // handle Exception
                }
            }
            return isSuccess;
        }
        /// <summary>
        /// delete a Todo content
        /// </summary>
        /// <param name="fld_ID"></param>
        /// <returns></returns>
        public bool DeleteContent(string fld_ID)
        {
            bool isSuccess = false;
            List<ContentEntity> listContentEntity = new List<ContentEntity>();
            string strSql = "DELETE tb_ListContent WHERE fld_ID=@fld_ID ";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings.ToString();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql);
                    cmd.Connection = conn;
                    SqlParameter parameter = new SqlParameter();
                    cmd.Parameters.Add(new SqlParameter("@fld_ID", Convert.ToInt32(fld_ID)));
                    
                    if (cmd.ExecuteNonQuery()>0)
                    {
                        isSuccess = true;
                    }
                }
                catch (Exception)
                {
                    // handle Exception
                }
            }
            return isSuccess;
        }
    }
}

