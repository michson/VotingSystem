using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page
{
    public string[] slt = new string[3];
    public string[] stat = new string[3];
    public string[] Comp = new string[3];
    public string[] tech = new string[3];
    protected void Page_Load(object sender, EventArgs e)
    {
        string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog=Voting_System ;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);

        try
        {

            Conobj.Open();
            string sqlstate = "SELECT Slate1,Slate2,Slate3 FROM ElectionSlating WHERE Department = '" + "S.L.T" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate);

            SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
            DataTable dtb = new DataTable();
            ReadObject.Fill(dtb);
            int RowCountg = dtb.Rows.Count;
            string sltt1,sltt2,sltt3;
            for (int i = 0; i < RowCountg; i++)
            {
            sltt1 =  dtb.Rows[i]["Slate1"].ToString();
            sltt2 = dtb.Rows[i]["Slate2"].ToString();
            sltt3 = dtb.Rows[i]["Slate3"].ToString();
          
           lstSLT.Items.Add(sltt1);
            lstSLT.Items.Add(sltt2);
            lstSLT.Items.Add(sltt3);

            }
            
        }

        catch (Exception ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            Conobj.Close();
        }

        try
        {

            Conobj.Open();
            string sqlstate = "SELECT Slate1,Slate2,Slate3 FROM ElectionSlating WHERE Department = '" + "Math&Stat" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate);

            SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
            DataTable dtb = new DataTable();
            ReadObject.Fill(dtb);
            int RowCountg = dtb.Rows.Count;
            string sltt1, sltt2, sltt3;
            for (int i = 0; i < RowCountg; i++)
            {
                sltt1 = dtb.Rows[i]["Slate1"].ToString();
                sltt2 = dtb.Rows[i]["Slate2"].ToString();
                sltt3 = dtb.Rows[i]["Slate3"].ToString();
                lstMATHS.Items.Add(sltt1);
                lstMATHS.Items.Add(sltt2);
                lstMATHS.Items.Add(sltt3);
            }

        }

        catch (Exception ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            Conobj.Close();
        }
        try
        {

            Conobj.Open();
            string sqlstate = "SELECT Slate1,Slate2,Slate3 FROM ElectionSlating WHERE Department = '" + "Computer Science" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate);

            SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
            DataTable dtb = new DataTable();
            ReadObject.Fill(dtb);
            int RowCountg = dtb.Rows.Count;
            string sltt1, sltt2, sltt3;
            for (int i = 0; i < RowCountg; i++)
            {
                sltt1 = dtb.Rows[i]["Slate1"].ToString();
                sltt2 = dtb.Rows[i]["Slate2"].ToString();
                sltt3 = dtb.Rows[i]["Slate3"].ToString();
                lstcomS.Items.Add(sltt1);
                lstcomS.Items.Add(sltt2);
                lstcomS.Items.Add(sltt3);
            }

        }

        catch (Exception ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            Conobj.Close();
        }
        try
        {

            Conobj.Open();
            string sqlstate = "SELECT Slate1,Slate2,Slate3 FROM ElectionSlating WHERE Department = '" + "Food Tech" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate);

            SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
            DataTable dtb = new DataTable();
            ReadObject.Fill(dtb);
            int RowCountg = dtb.Rows.Count;
            string sltt1, sltt2, sltt3;
            for (int i = 0; i < RowCountg; i++)
            {
                sltt1 = dtb.Rows[i]["Slate1"].ToString();
                sltt2 = dtb.Rows[i]["Slate2"].ToString();
                sltt3 = dtb.Rows[i]["Slate3"].ToString();
                lstfoodteh.Items.Add(sltt1);
                lstfoodteh.Items.Add(sltt2);
                lstfoodteh.Items.Add(sltt3);
            }

        }

        catch (Exception ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            Conobj.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       for (int i = 0; i <= 2; i++)
        {
           slt[i]=Convert.ToString((lstSLT.Items[i]));
            
        }
        for (int i = 0; i <= 2; i++)
        {
            tech[i]=Convert.ToString((lstfoodteh.Items[i]));
            
        }
        for (int i = 0; i <= 2; i++)
        {
            Comp[i] = Convert.ToString((lstcomS.Items[i]));

        }
        for (int i = 0; i <= 2; i++)
        {
            stat[i] = Convert.ToString((lstMATHS.Items[i]));

        }
        lstSLT.Items.Clear();
        lstfoodteh.Items.Clear();
        lstcomS.Items.Clear(); 
        lstMATHS.Items.Clear();

        for (int i = 0; i <= 2; i++)
        {
            lstMATHS.Items.Add(Comp[i]);
        }
        
        for (int i = 0; i <= 2; i++)
        {
            lstSLT.Items.Add(stat[i]);

        }
        for (int i = 0; i <= 2; i++)
        {
            lstfoodteh.Items.Add(slt[i]);
        }
        for (int i = 0; i <= 2; i++)
        {
            lstcomS.Items.Add(tech[i]);
        }
        // updating Database with the value
        string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog=Voting_System ;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);

        try
        {

            Conobj.Open();
            string sqlstate = " UPDATE ElectionSlating SET Slate1 = '" + lstSLT.Items[0] + "',Slate2 = '" + lstSLT.Items[1] + "' WHERE Department = '" + "S.L.T" + "'";
            string sql2 = "UPDATE ElectionSlating SET Slate3 = '" + lstSLT.Items[2] + "'";
            SqlCommand comb = new SqlCommand(sql2,Conobj);
            SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
            Comobjects.ExecuteNonQuery();
            comb.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            Conobj.Close();
        }

        //the Second one database
        try
        {

            Conobj.Open();
            string sqlstate = " UPDATE ElectionSlating SET Slate1 = '" + lstMATHS.Items[0] + "',Slate2 = '" + lstMATHS.Items[1] + "',Slate3 = '" + lstMATHS.Items[2] + "' WHERE Department = '" + "Math&Stat" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
            Comobjects.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            Conobj.Close();
        }
        // The third Connection
        try
        {

            Conobj.Open();
            string sqlstate = " UPDATE ElectionSlating SET Slate1 = '" + lstcomS.Items[0] + "',Slate2 = '" + lstcomS.Items[1] + "',Slate3 = '" + lstcomS.Items[2] + "' WHERE Department = '" + "Computer Science" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
            Comobjects.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            Conobj.Close();
        }
        // the fourth Connection
        try
        {

            Conobj.Open();
            string sqlstate = " UPDATE ElectionSlating SET Slate1 = '" + lstfoodteh.Items[0] + "',Slate2 = '" + lstfoodteh.Items[1] + "',Slate3 = '" + lstfoodteh.Items[2] + "' WHERE Department = '" + "Food Tech" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
            Comobjects.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            Conobj.Close();
        } 
    }
}
