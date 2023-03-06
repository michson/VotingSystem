











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
    public string president;
   

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        
        if (Chkconfirm.Checked == false)
        {
            Response.Write("<script>alert('pls check the box to confirm your vote!') </Script>");
        }
        else
          if(RadioButtonList1.Items[0].Selected == false && RadioButtonList1.Items[1].Selected == false)
          {
              Response.Write("<script>alert('pls vote for the president!') </Script>");
          
          }
        else if(RadioButtonList2.Items[0].Selected == false && RadioButtonList2.Items[1].Selected == false)
        {
            Response.Write("<script>alert('pls vote for the P.R.O!') </Script>");
        }
          else if (RadioButtonList3.Items[0].Selected == false && RadioButtonList3.Items[1].Selected == false)
          {
              Response.Write("<script>alert('pls vote for the Editor in Chief!') </Script>");
          }
        else
          {
            string constr;

            constr = "Data Source=COLE-PC\\SQLEXPRESS;";
            constr = constr + "Initial Catalog=Voting_System ;";
            constr = constr + "Integrated Security= True;";
            SqlConnection Conobj = new SqlConnection(constr);

            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Student_Reg set IsLogingIn = '" + "Yes" + "' WHERE Username = '" + Session["UserName"] + "'";
                string sqlstate1 = " UPDATE CandidateReg set IsLog = '" + "Yes" + "' WHERE Name = '" + Session["UserName"] + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
                SqlCommand Comobjects1 = new SqlCommand(sqlstate1, Conobj);
                Comobjects.ExecuteNonQuery();
                Comobjects1.ExecuteNonQuery();
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
            // chechecking if is the first president
            if (RadioButtonList1.Items[0].Selected == true)
            {
                try
                {

                    Conobj.Open();
                    string sqlstate = " UPDATE Candidate_Result set voteNo = voteNo + 1 WHERE Name = '" + RadioButtonList1.Items[0].Text + "'";
                    SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
                    Comobjects.ExecuteNonQuery();
                   // Response.Write("<script>alert('Thanks For Voting!') </Script>");
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
            // if  it is the second president
            else if (RadioButtonList1.Items[1].Selected == true)
            {
                try
                {

                    Conobj.Open();
                    string sqlstate = " UPDATE Candidate_Result set voteNo = voteNo + 1 WHERE Name = '" + RadioButtonList1.Items[1].Text + "'";
                    SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
                    Comobjects.ExecuteNonQuery();
                   // Response.Write("<script>alert('Thanks For Voting!') </Script>");
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
            //cheking for pro
            if (RadioButtonList2.Items[0].Selected == true)
            {
                try
                {

                    Conobj.Open();
                    string sqlstate = " UPDATE Candidate_Result set voteNo = voteNo + 1 WHERE Name = '" + RadioButtonList2.Items[0].Text + "'";
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
            // if  it is the second PRO
            else if (RadioButtonList2.Items[1].Selected == true)
            {
                try
                {

                    Conobj.Open();
                    string sqlstate = " UPDATE Candidate_Result set voteNo = voteNo + 1 WHERE Name = '" + RadioButtonList2.Items[1].Text + "'";
                    SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
                    Comobjects.ExecuteNonQuery();
                   // Response.Write("<script>alert('Thanks For Voting!') </Script>");
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
            // first Auditor in chif
            if (RadioButtonList3.Items[0].Selected == true)
            {
                try
                {

                    Conobj.Open();
                    string sqlstate = " UPDATE Candidate_Result set voteNo = voteNo + 1 WHERE Name = '" + RadioButtonList3.Items[0].Text + "'";
                    SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
                    Comobjects.ExecuteNonQuery();
                    ClientScript.RegisterStartupScript(this.GetType(), "Myalert", "alert('" +"Thanks for voting" +"');", true);
                    //Response.Write("<script>alert('Thanks For Voting!') </Script>");
                    //Response.Write("<script>location.href =Login.aspx;</Script>");
                    Response.Redirect("Login.aspx",false);

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
            // if  it is the second Auditor in chief
            else if (RadioButtonList3.Items[1].Selected == true)
            {
                try
                {

                    Conobj.Open();
                    string sqlstate = " UPDATE Candidate_Result set voteNo = voteNo + 1 WHERE Name = '" + RadioButtonList3.Items[1].Text + "'";
                    SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
                    Comobjects.ExecuteNonQuery();
                   // Response.Write("<script>alert('Thanks For Voting!') </Script>");
                    Response.Redirect("Login.aspx",false);
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
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        lblAd.Visible = true;
        lblAd.Text = "<b>" + "Welcome " + "</b><font color=red>" + " " + Session["UserName"] + "</font>" + " " + "<b>" + "Your Vote is Important Us " + "</b>";
        //For president


        string constr;

        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog=Voting_System ;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);
        try
        {
            Conobj.Open();
            string sqlstat = "SELECT Image, Name,Department FROM CandidateReg WHERE Post = '" + "President" + "'";
            SqlCommand Comobj = new SqlCommand(sqlstat);
            SqlDataAdapter ReadObj = new SqlDataAdapter(Comobj.CommandText, Conobj);
            DataTable dt = new DataTable();
            ReadObj.Fill(dt);
            int RowCount = dt.Rows.Count;
            for (int i = 0; i < RowCount; i++)
            {
                Label1.Text = dt.Rows[0]["Department"].ToString();
                Label2.Text = dt.Rows[1]["Department"].ToString();
                Image2.ImageUrl = dt.Rows[0]["Image"].ToString();
                Image3.ImageUrl = dt.Rows[1]["Image"].ToString();
                RadioButtonList2.Items[i].Text = dt.Rows[i]["Name"].ToString();
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


        // for P.R. O
        try
        {
            Conobj.Open();
            string sqlstat = "SELECT Image, Name,Department FROM CandidateReg WHERE Post = '" + "P.R.O" + "'";
            SqlCommand Comobj = new SqlCommand(sqlstat);
            SqlDataAdapter ReadObj = new SqlDataAdapter(Comobj.CommandText, Conobj);
            DataTable dt = new DataTable();
            ReadObj.Fill(dt);
            int RowCount = dt.Rows.Count;
            for (int i = 0; i < RowCount; i++)
            {
                Label3.Text = dt.Rows[0]["Department"].ToString();
                Label4.Text = dt.Rows[1]["Department"].ToString();
                Image1.ImageUrl = dt.Rows[0]["Image"].ToString();
                Image4.ImageUrl = dt.Rows[1]["Image"].ToString();
                RadioButtonList1.Items[i].Text = dt.Rows[i]["Name"].ToString();
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
        // For Editor in chief
        try
        {
            Conobj.Open();
            string sqlstat = "SELECT Image, Name,Department FROM CandidateReg WHERE Post = '" + "Editor In Chief" + "'";
            SqlCommand Comobj = new SqlCommand(sqlstat);
            SqlDataAdapter ReadObj = new SqlDataAdapter(Comobj.CommandText, Conobj);
            DataTable dt = new DataTable();
            ReadObj.Fill(dt);
            int RowCount = dt.Rows.Count;
            for (int i = 0; i < RowCount; i++)
            {
                Label5.Text = dt.Rows[0]["Department"].ToString();
               Label6.Text = dt.Rows[1]["Department"].ToString();
                Image5.ImageUrl = dt.Rows[0]["Image"].ToString();
                Image6.ImageUrl = dt.Rows[1]["Image"].ToString();
                //RadioButtonList3.Items[i].Text = dt.Rows[i]["Name"].ToString();
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
