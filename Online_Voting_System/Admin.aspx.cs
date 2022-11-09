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



public partial class _Default : System.Web.UI.Page
{
    protected void btnStatElec_Click(object sender, EventArgs e)
    {
        string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog=Voting_System ;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);

        try
        {

            Conobj.Open();
            string sqlstate = "UPDATE Student_Reg SET ElectionState ='" + "Ongoing" + "' WHERE Role = '"+ "Voters" +"'";
            string sqlstate1 = "UPDATE CandidateReg SET ElectionState ='" + "Ongoing" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
            SqlCommand Comobjects1 = new SqlCommand(sqlstate1, Conobj);
            Comobjects.ExecuteNonQuery();
            Comobjects1.ExecuteNonQuery();
            Response.Write("<script>alert('You Have start the Election')</Script>");
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
    protected void btnEndElec_Click(object sender, EventArgs e)
    {
        string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog=Voting_System ;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);

        try
        {

            Conobj.Open();
            string sqlstate = "UPDATE Student_Reg SET ElectionState ='" + "End" + "' WHERE Role = '" + "Voters" + "'";
            string sqlstate1 = "UPDATE CandidateReg SET ElectionState ='" + "End" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
            SqlCommand Comobjects1 = new SqlCommand(sqlstate1, Conobj);
            Comobjects.ExecuteNonQuery();
            Comobjects1.ExecuteNonQuery();
            Response.Write("<script>alert('You Have End the Election')</Script>");
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
    protected void LNKLOGOUT_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
       FormsAuthentication.SignOut();
       Response.Redirect("Login.aspx");
       
    }
}
