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

public partial class Defau : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog=Voting_System ;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);

        string strq = "SELECT Name,Department,Post,Level,Session,Image FROM CandidateReg";
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
}
