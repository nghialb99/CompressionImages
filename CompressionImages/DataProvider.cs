﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressionImages
{
     public class DataProvider
    {
        private static DataProvider? instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        //private string connectionSTR = ConfigurationManager.ConnectionStrings["API_QuanLyNhaThuoc.Properties.Settings.Api_QuanLyNhaThuocConnectionString"].ConnectionString;
        private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=DrugstoreManagementDb;Integrated Security=True";
        //private string connectionSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ Application.StartupPath + @"\database\Api_QuanLyNhaThuoc.mdf;Integrated Security=True";
        public async Task<DataTable> ExcuteQuery(string query, object[]? a = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(query, connection);

                if (a != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, a[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        public async Task<int> ExcuteNunQuery(string query, object[]? a = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(query, connection);

                if (a != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, a[i]);
                            i++;
                        }
                    }
                }
                data = await command.ExecuteNonQueryAsync();

                connection.Close();
            }
            return data;
        }

        public async Task<object?> ExcuteScalar(string query, object[]? a = null)
        {
            object? data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(query, connection);

                if (a != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, a[i]);
                            i++;
                        }
                    }
                }
                data = await command.ExecuteScalarAsync();

                connection.Close();
            }
            return data;
        }
    }
}
