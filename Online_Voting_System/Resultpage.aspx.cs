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

public partial class Resultpage : System.Web.UI.Page
{
    string sltt1;
    protected void Page_Load(object sender, EventArgs e)
    {
        string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog= Voting_System;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);
        try
        {
            Conobj.Open();
            string sqlstat = "SELECT ShowResult FROM Candidate_Result";
            SqlCommand Comobj = new SqlCommand(sqlstat);
            SqlDataAdapter ReadObj = new SqlDataAdapter(Comobj.CommandText, Conobj);
            DataTable dt = new DataTable();
            ReadObj.Fill(dt);
            int RowCount = dt.Rows.Count;
            for (int i = 0; i < RowCount; i++)
            {
              sltt1  = dt.Rows[i]["ShowResult"].ToString();
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
        if( sltt1 == "Show")
        {
            string strq = "SELECT Image,Name,Post,VoteNo,Result FROM Candidate_Result";
            SqlCommand cmd = new SqlCommand(strq);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conobj;
            try
            {
                Conobj.Open();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                Conobj.Close();
                sda.Dispose();
                Conobj.Dispose();
            }
        }
        else if (sltt1 == "Hide")
        {
 
        }
    }
}