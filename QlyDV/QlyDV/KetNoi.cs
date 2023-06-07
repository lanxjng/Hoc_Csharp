﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace QlyDV
{
    class KetNoi
    {
        public SqlConnection connect = new SqlConnection(@"Data Source=TRUONGJAE\SQLEXPRESS;Initial Catalog=QlyDV;Integrated Security=True");
        public void Execute(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();

                adapter.Fill(dt);
            
                
            adapter.Update(dt);
            dt.AcceptChanges();

        }
        public DataTable Load(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, connect);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comSelect;
            adapter.Fill(dt);
            dt.AcceptChanges();
            return dt;
        }

    }
}