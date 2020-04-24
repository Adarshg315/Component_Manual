cs
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using BO;
	using DAL;
	
	namespace BAL
	{
	   public class balRegister
	   {
	       dalRegister dalregister = new dalRegister();
	       public int balreg(boRegister boregister)
	       {
	           try
	           {
	               return dalregister.dalreg(boregister);
	           }
	           catch (Exception ex)
	           {
	               ex.GetType();
	            }
	           return 0;
	       }
	   }
	}