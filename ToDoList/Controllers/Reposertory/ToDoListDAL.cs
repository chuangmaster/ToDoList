﻿using System;
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
    public class ToDoListDAL
    {
        /// <summary>
        /// Read one content entity
        /// </summary>
        /// <param name="fld_ID"></param>
        /// <returns></returns>
        public ContentEntity ReadEntity(string fld_ID)
        {
            ContentEntity entity = null;
            string strSql = "SELECT Top 1 *  FROM tb_ListContent WHERE fld_ID=@fld_ID ";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnectString();
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
                        entity = new ContentEntity();
                        entity.fld_ID = dr["fld_ID"].ToString();
                        entity.fld_Content = dr["fld_Content"].ToString();
                        entity.fld_CreateDate = DateTime.Parse(dr["fld_CreateDate"].ToString());
                        entity.fld_status = bool.Parse(dr["fld_status"].ToString());
                    }
                }
                catch (Exception e)
                {
                    throw e;
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
            string strSql = "SELECT *  FROM tb_ListContent ORDER BY fld_CreateDate";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnectString();
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
                        entity.fld_status = bool.Parse(dr["fld_status"].ToString());
                        entity.fld_CreateDate = DateTime.Parse(dr["fld_CreateDate"].ToString());
                        listContentEntity.Add(entity);
                    }
                }
                catch (Exception e)
                {
                    throw e;
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
            string strSql = "INSERT INTO tb_ListContent (fld_ID,fld_Content,fld_CreateDate) VALUES(@fld_ID,@fld_Content,@fld_CreateDate)";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnectString();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql);

                    cmd.Parameters.Add(new SqlParameter("@fld_ID", GetHashCode()));
                    cmd.Parameters.Add(new SqlParameter("@fld_Content", content));
                    cmd.Parameters.Add(new SqlParameter("@fld_CreateDate", DateTime.Now));
                    cmd.Connection = conn;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        isSuccess = true;
                    }
                }
                catch (Exception e)
                {
                    throw e;
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
                conn.ConnectionString = GetConnectString();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql);
                    cmd.Connection = conn;
                    SqlParameter parameter = new SqlParameter();
                    cmd.Parameters.Add(new SqlParameter("@fld_ID", Convert.ToInt32(fld_ID)));

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        isSuccess = true;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return isSuccess;
        }

        public bool UpdateContent(string fld_ID, bool fld_status)
        {
            bool isSuccess = false;
            List<ContentEntity> listContentEntity = new List<ContentEntity>();
            string strSql = "UPDATE tb_ListContent SET fld_status=@fld_status WHERE fld_ID=@fld_ID ";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnectString();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql);
                    cmd.Connection = conn;
                    SqlParameter parameter = new SqlParameter();
                    cmd.Parameters.Add(new SqlParameter("@fld_ID", Convert.ToInt32(fld_ID)));
                    cmd.Parameters.Add(new SqlParameter("@fld_status", fld_status));

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        isSuccess = true;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return isSuccess;
        }

        private string GetConnectString()
        {
            return WebConfigurationManager.ConnectionStrings["localDB"].ToString();

        }
    }
}

