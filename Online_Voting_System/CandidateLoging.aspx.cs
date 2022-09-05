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
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog= Voting_System;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);
        try
        {
            Conobj.Open();
            string sql1 = "SELECT Name,Matric_No,ElectionState,IsLog FROM CandidateReg WHERE Name = '" + txtUserName.Text + "' AND Matric_No ='" + txtpassword.Text + "';";
            SqlCommand Comobj1 = new SqlCommand(sql1);
            SqlDataAdapter ReadObj1 = new SqlDataAdapter(Comobj1.CommandText, Conobj);
            DataTable dt1 = new DataTable();
            ReadObj1.Fill(dt1);
            int RowCount1 = dt1.Rows.Count;
            for (int i = 0; i < RowCount1; i++)
            {
                string Elections = dt1.Rows[i]["ElectionState"].ToString();
                string Name = dt1.Rows[i]["Name"].ToString();
                string MatricNo = dt1.Rows[i]["Matric_No"].ToString();
                string Loging = dt1.Rows[i]["IsLog"].ToString();
                if (Name == txtUserName.Text && MatricNo == txtpassword.Text && Elections == "Ongoing")
                {
                    if (Loging.Contains("No"))
                    {
                        Session["UserName"] = Name;
                        Response.Redirect("votepage.aspx", false);
                    }
                    else
                        Response.Write("<script>alert('You Can Only Vote Once!') </Script>");
                   
                }
                else if (Name == txtUserName.Text && MatricNo == txtpassword.Text && Elections == "End")
                    Response.Write("<script>alert('Sorry Election Has Ended!') </Script>");
                else
                {

                    Response.Write("<script>alert('incorrect usernane or password!') </Script>");
                    lblmsg.Enabled = true;
                    lblmsg.Text = "incorrect user";
                }

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
}
