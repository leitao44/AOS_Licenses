using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AOS_Licenses
{
    /// <summary>
    /// Descrição resumida de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }
        [WebMethod]
		public string Existe(string json)
		{

			bool existe = false;
			try
			{

				Empresa empresa = new Empresa(json);
				string tag0 = empresa.tag0;
				string tag1 = empresa.tag1;
				string tag2 = empresa.tag2;
				string tag3 = empresa.tag3;
				string tag4 = empresa.tag4;
				string tag5 = empresa.tag5;
				string tag6 = empresa.tag6;
				string tag7 = empresa.tag7;
				string tag8 = empresa.tag8;
				string tag9 = empresa.tag9;
				string tag10 = empresa.tag10;
				string tag11 = empresa.tag11;
				string tag12 = empresa.tag12;
				string tag13 = empresa.tag13;
				string tag14 = empresa.tag14;
				string tag15 = empresa.tag15;
				string tag16 = empresa.tag16;
				string tag17 = empresa.tag17;
				string tag18 = empresa.tag18;
				string tag19 = empresa.tag19;
				string tag20 = empresa.tag20;
				string tag21 = empresa.tag21;
				string tag22 = empresa.tag22;
				string tag23 = empresa.tag23;
				string tag24 = empresa.tag24;
				string tag25 = empresa.tag25;
				string tag26 = empresa.tag26;
				string tag27 = empresa.tag27;
				string tag28 = empresa.tag28;
				string tag29 = empresa.tag29;
				string tag30 = empresa.tag30;
				DateTime date = DateTime.Now;

				SqlConnection conn = new SqlConnection("Server=tcp:verdadeirodb.database.windows.net,1433;Initial Catalog=verdadeiraDB;Persist Security Info=False;User ID=leitao44;Password=1Francisco2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
				conn.Open();
				SqlCommand check_id1 = new SqlCommand("select count(*) from [dbo].[Input] i where i.nomeEmpresa in (select e.nomeEmpresa from [dbo].[Empresas] e)", conn);
				int EmpresaIgual1 = (int)check_id1.ExecuteScalar();
				string insertQuery = "insert into [dbo].[Input](tag0,tag1,tag2,tag3,tag4,tag5,tag6,tag7,tag8,tag9,tag10,tag11,tag12,tag13,tag14,tag15,tag16,tag17,tag18,tag19,tag20,tag21,tag22,tag23,tag24,tag25,tag26,tag27,tag28,tag29,tag30) " +
				"values(@tag0,@tag1,@tag2,@tag3,@tag4,@tag5,@tag6,@tag7,@tag8,@tag9,@tag10,@tag11,@tag12,@tag13,@tag14,@tag15,@tag16,@tag17,@tag18,@tag19,@tag20,@tag21,@tag22,@tag23,@tag24,@tag25,@tag26,@tag27,@tag28,@tag29,@tag30)";
				SqlCommand cmd = new SqlCommand(insertQuery, conn);

				cmd.Parameters.AddWithValue("@tag0", tag0);
				cmd.Parameters.AddWithValue("@tag1", tag1);
				cmd.Parameters.AddWithValue("@tag2", tag2);
				cmd.Parameters.AddWithValue("@tag3", tag3);
				cmd.Parameters.AddWithValue("@tag4", tag4);
				cmd.Parameters.AddWithValue("@tag5", tag5);
				cmd.Parameters.AddWithValue("@tag6", tag6);
				cmd.Parameters.AddWithValue("@tag7", tag7);
				cmd.Parameters.AddWithValue("@tag8", tag8);
				cmd.Parameters.AddWithValue("@tag9", tag9);
				cmd.Parameters.AddWithValue("@tag10", tag10);
				cmd.Parameters.AddWithValue("@tag11", tag11);
				cmd.Parameters.AddWithValue("@tag12", tag12);
				cmd.Parameters.AddWithValue("@tag13", tag13);
				cmd.Parameters.AddWithValue("@tag14", tag14);
				cmd.Parameters.AddWithValue("@tag15", tag15);
				cmd.Parameters.AddWithValue("@tag16", tag16);
				cmd.Parameters.AddWithValue("@tag17", tag17);
				cmd.Parameters.AddWithValue("@tag18", tag18);
				cmd.Parameters.AddWithValue("@tag19", tag19);
				cmd.Parameters.AddWithValue("@tag20", tag20);
				cmd.Parameters.AddWithValue("@tag21", tag21);
				cmd.Parameters.AddWithValue("@tag22", tag22);
				cmd.Parameters.AddWithValue("@tag23", tag23);
				cmd.Parameters.AddWithValue("@tag24", tag24);
				cmd.Parameters.AddWithValue("@tag25", tag25);
				cmd.Parameters.AddWithValue("@tag26", tag26);
				cmd.Parameters.AddWithValue("@tag27", tag27);
				cmd.Parameters.AddWithValue("@tag28", tag28);
				cmd.Parameters.AddWithValue("@tag29", tag29);
				cmd.Parameters.AddWithValue("@tag30", tag30);


				cmd.ExecuteNonQuery();
				SqlCommand check_id2 = new SqlCommand("select count(*) from [dbo].[Input] i where i.nomeEmpresa in (select e.nomeEmpresa from [dbo].[Empresas] e)", conn);

				int EmpresaIgual2 = (int)check_id2.ExecuteScalar();

				if (EmpresaIgual2 - EmpresaIgual1 > 0)
				{
					string query = "SELECT localizacaoEmpresa FROM Empresas e INNER JOIN Input i ON e.nomeEmpresa = i.nomeEmpresa; ";
					string localizacaoo = query.ToString();
					SqlCommand cmd2 = new SqlCommand(query, conn);
					existe = true;
					return "Existe e a localização da empresa é " + localizacaoo;

				}

				conn.Close();

			}
			catch (Exception ex)
			{
				Console.WriteLine("error: " + ex.ToString());


			}
			return "";
		}

	}
}
