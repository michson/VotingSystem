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

public partial class Registration : System.Web.UI.Page
{
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string Matric_Num="";
        string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog=Voting_System ;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);
        try
        {
            
            Conobj.Open();
            string sqlstate = "SELECT * FROM Student_Reg WHERE Matric_no = '" + txtmat.Text + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate);
            SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
            DataTable dtb = new DataTable();
            ReadObject.Fill(dtb);
            int RowCountg = dtb.Rows.Count;
            
            for (int i = 0; i < RowCountg; i++)
            {
                Matric_Num = dtb.Rows[i]["Matric_no"].ToString();
                
                if (Matric_Num == txtmat.Text)
                {
                 Response.Write("<script>alert('sorry you can not register again, kindly login to vote ') </Script>");    
                }
                else 
                {
                 
                string sqlstat = "SELECT * FROM Student_Details WHERE Matric_No = '" + txtmat.Text + "' AND school ='" + txtsch.Text + "' AND Department ='" + txtdep.Text + "'";
                SqlCommand Comobj = new SqlCommand(sqlstat);
                SqlDataAdapter ReadObj = new SqlDataAdapter(Comobj.CommandText, Conobj);
                DataTable dt = new DataTable();
                ReadObj.Fill(dt);
                int RowCount = dt.Rows.Count;
                for (int l = 0; l < RowCount; l++)
                {
                    string Matric_No = dt.Rows[i]["Matric_No"].ToString();
                    string school = dt.Rows[i]["school"].ToString();
                    string Department = dt.Rows[i]["Department"].ToString();
                    if (Matric_No == txtmat.Text && school == txtsch.Text && Department == txtdep.Text)
                    {
                       
                        string constring;
                        constring = "Data Source=COLE-PC\\SQLEXPRESS;";
                        constring = constring + "Initial Catalog= Voting_System;";
                        constring = constring + "Integrated Security= True;";
                        SqlConnection Conobject = new SqlConnection(constring);
                        string sqlstatement = "INSERT INTO Student_Reg(Username,password,phone,Email,Matric_no,Role,Session,IsLogingIn) VALUES(@Username,@password ," +
                       "@phone,@Email,@Matric_no,@Role,@Session,@IsLogingIn)";
                        try
                        {
                           
                            Conobject.Open();
                            SqlCommand Comobject = new SqlCommand(sqlstatement, Conobject);
                            SqlParameter[] param = new SqlParameter[8];
                            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
                            param[1] = new SqlParameter("@password", SqlDbType.NVarChar, 10);
                            param[2] = new SqlParameter("@phone", SqlDbType.NChar, 12);
                            param[3] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
                            param[4] = new SqlParameter("@Matric_no", SqlDbType.NVarChar, 50);
                            param[5] = new SqlParameter("@Role", SqlDbType.NVarChar, 50);
                            param[6] = new SqlParameter("@Session", SqlDbType.NVarChar, 10);
                            param[7] = new SqlParameter("@IsLogingIn", SqlDbType.NVarChar, 20);

                            param[0].Value = txtid.Text;
                            param[1].Value = txtpwd.Text;
                            param[2].Value = txtphone.Text;
                            param[3].Value = txtemail.Text;
                            param[4].Value = txtmat.Text;
                            param[5].Value = "Voters";
                            param[6].Value = txtsesion.Text;
                            param[7].Value = "No";
                            for (int j = 0; j < param.Length; j++)
                            {
                                Comobject.Parameters.Add(param[j]);

                            }
                            Comobject.CommandType = CommandType.Text;
                            Comobject.ExecuteNonQuery();
                            Response.Write("<script>alert('Registration Succesful')</Script>");
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
                           
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Matric_No., pls also check the department and school if not spell corectly')</Script>");
                    }
                   
                }
                }
            }
        }
        catch (Exception)
        {
            Response.Write("<script>alert('Error Connecting To The DataBase') </Script>");
        }
        finally
        {
            Conobj.Close();
        }
    
    }
}
