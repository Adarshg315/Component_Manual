cs
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Data;
	using System.Data.SqlClient;
	using BO;
	
	namespace DAL
	{
	   public class dalRegister
	   {
	       SqlConnection conn = new SqlConnection(@"data source=LAKSHANYA\SQLEXPRESS;database=master;integrated security=true");
	       public int dalreg(boRegister boregister)
	       {
	           try
	           {
	               conn.Open();
	               SqlCommand cmd = new SqlCommand("insert into user_table values('" + boregister.userName + "','" + boregister.gender + "','" + boregister.password + "','" + boregister.cPassword + "','" + boregister.fees + "','" + boregister.userType + "','" + boregister.eMail + "')", conn);
	               cmd.ExecuteNonQuery();
	               return 1;
	           }
	           catch (Exception ex)
	           {
	               throw ex;
	           }
	           finally
	           {
	               conn.Close();
	           }
	       }
	   }
	}