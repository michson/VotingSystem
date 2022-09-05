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

public partial class Login : System.Web.UI.Page
{
    string loging;
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
                    string sqlstat = "SELECT * FROM Student_Reg WHERE Username = '" + txtUserName.Text + "' AND Password ='" + txtpassword.Text + "';";
                    string sql1 = "SELECT Name,Matric_No,ElectionState FROM CandidateReg WHERE Name = '" + txtUserName.Text + "' AND Matric_No ='" + txtpassword.Text + "';"; 
                    SqlCommand Comobj= new SqlCommand(sqlstat);
                    SqlCommand Comobj1 = new SqlCommand(sql1);
                    SqlDataAdapter ReadObj = new SqlDataAdapter(Comobj.CommandText, Conobj);
                    SqlDataAdapter ReadObj1 = new SqlDataAdapter(Comobj1.CommandText, Conobj);
                    DataTable dt = new DataTable();
                    DataTable dt1 = new DataTable();
                    ReadObj.Fill(dt);
                    ReadObj1.Fill(dt1);
                    int RowCount = dt.Rows.Count;
                    int RowCount1 = dt1.Rows.Count;
                    for (int i = 0; i < RowCount; i++)
                    {
                        
                        string Election = dt.Rows[i]["ElectionState"].ToString();
                         loging = dt.Rows[i]["IsLogingIn"].ToString();
                        string UserName = dt.Rows[i]["Username"].ToString();
                        string Password = dt.Rows[i]["Password"].ToString();
                        
                       string Voter = dt.Rows[i]["Role"].ToString();
                         if (UserName == txtUserName.Text && Password == txtpassword.Text)
                        {
                            Session["UserName"] = UserName;
                            if (Voter == "Admin" && Election == "Constant")
                                Response.Redirect("Admin.aspx",false);
                            else if (Voter == "Voters" && Election == "Ongoing")
                            {
                            if(loging.Contains("No"))
                            {
                                Response.Redirect("Votepage.aspx", false);
                            }
                            if (loging.Contains("Yes"))
                                Response.Write("<script>alert('Account No Longer Valid You can only Vote Once!') </Script>");
                            }
                               
                              else if(dt.Rows[i]["Role"].ToString() == "Voters" && Election == "End")
                                Response.Write("<script>alert('Sorry Election Has Ended!') </Script>");
                               else
                               {
                                Response.Write("<script>alert('incorrect usernane or password!') </Script>");
                                lblmsg.Enabled = true;
                                lblmsg.Text = "incorrect user";
                                 }
                        }
                        
                    }
                      for (int i = 0; i < RowCount1; i++)
                       {
                           string Elections = dt1.Rows[i]["ElectionState"].ToString();
                           string Name = dt1.Rows[i]["Name"].ToString();
                           string MatricNo = dt1.Rows[i]["Matric_No"].ToString();
                           if (Name == txtUserName.Text && MatricNo == txtpassword.Text && Elections == "Ongoing" )
                           {
                               Session["UserName"] = Name;
                                Response.Redirect("Candidatepage.aspx",false);
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

