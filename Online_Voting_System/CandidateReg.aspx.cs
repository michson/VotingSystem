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
using System.IO;

public partial class Default2 : System.Web.UI.Page
{
    string Matric;
    protected void Page_Load(object sender, EventArgs e)
    {
         
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (ListBox1.SelectedIndex == -1)
        {
            Response.Write("<script>alert('You must choose post to proceed')</Script>");
        }
        else if (txtgrade.Text == String.Empty || txtName.Text == String.Empty || txtphone.Text == String.Empty || txtsession.Text == String.Empty || txtlevel.Text == String.Empty)
        {
            Response.Write("<script>alert('You Must fill all the data')</Script>");
        }
        else if (FileUpload1.PostedFile == null && FileUpload1.PostedFile.FileName == "")
        {
            Response.Write("<script>alert('Pls upload your recent photo')</Script>");
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
                string sqlstate = "SELECT Matric_No FROM CandidateReg WHERE Matric_No = '" + txtmat.Text + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate);

                SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
                DataTable dtb = new DataTable();
                ReadObject.Fill(dtb);
                int RowCountg = dtb.Rows.Count;
             
                for (int i = 0; i < RowCountg; i++)
                {
                    Matric = dtb.Rows[i]["Matric_No"].ToString();
                  
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
                 
            }


            if (txtmat.Text == Matric)
            {

                Response.Write("<script>alert('You Can Not Register Twice ')</Script>");
            }
            else
            {
                // save file to disk
                string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/images/" + FileName));
                string constri;
                constri = "Data Source=COLE-PC\\SQLEXPRESS;";
                constri = constr + "Initial Catalog=Voting_System ;";
                constri = constr + "Integrated Security= True;";
                SqlConnection Conobject = new SqlConnection(constri);
                string sqlstatement = "INSERT INTO CandidateReg(Name,Department,Post,Matric_No,Level,Current_Grade,Phone,Email,Session,Image,IsLog) VALUES(@Name,@Department ," +
               "@Post,@Matric_No,@Level,@Current_Grade,@Phone,@Email,@Session,@Image,@IsLog)";
                string sqlst = "INSERT INTO Candidate_Result(Name,Post,VoteNo,Image) VALUES(@Name,@Post,@VoteNo,@Image)";
                try
                {
                    Conobject.Open();
                    SqlCommand Comobject = new SqlCommand(sqlstatement, Conobj);
                    SqlCommand Comobject1 = new SqlCommand(sqlst, Conobj);
                    SqlParameter[] param = new SqlParameter[11];
                    SqlParameter[] param1 = new SqlParameter[4];
                    param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                    param[1] = new SqlParameter("@Department", SqlDbType.NVarChar, 30);
                    param[2] = new SqlParameter("@Post", SqlDbType.NVarChar, 50);
                    param[3] = new SqlParameter("@Matric_No", SqlDbType.NVarChar, 30);
                    param[4] = new SqlParameter("@Level", SqlDbType.NVarChar, 50);
                    param[5] = new SqlParameter("@Current_Grade", SqlDbType.Float, 8);
                    param[6] = new SqlParameter("@Phone", SqlDbType.NVarChar, 12);
                    param[7] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
                    param[8] = new SqlParameter("@Session", SqlDbType.NVarChar, 50);
                    param[9] = new SqlParameter("@Image", SqlDbType.NVarChar, 50);
                    param[10] = new SqlParameter("@IsLog", SqlDbType.NVarChar, 20);

                    param1[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                    param1[1] = new SqlParameter("@Post", SqlDbType.NVarChar, 50);
                    param1[2] = new SqlParameter("@VoteNo", SqlDbType.NVarChar, 50);
                    param1[3] = new SqlParameter("@Image", SqlDbType.NVarChar, 50);
                    




                    param[0].Value = txtName.Text;
                    param[1].Value = DropDownList1.SelectedValue;
                    param[2].Value = ListBox1.SelectedValue;
                    param[3].Value = txtmat.Text;
                    param[4].Value = txtlevel.Text;
                    param[5].Value = txtgrade.Text;
                    param[6].Value = txtphone.Text;
                    param[7].Value = txtemail.Text;
                    param[8].Value = txtsession.Text;
                    param[9].Value = "images/" + FileName;
                    param[10].Value = "No";

                    param1[0].Value = txtName.Text;
                    param1[1].Value = ListBox1.SelectedValue;
                    param1[2].Value = "0";
                    param1[3].Value = "images/" + FileName;
                    

                    for (int j = 0; j < param1.Length; j++)
                    {
                     Comobject1.Parameters.Add(param1[j]);
                    }
                    for (int j = 0; j < param.Length; j++)
                    {
                        Comobject.Parameters.Add(param[j]);
                       
                    }
                    Comobject.CommandType = CommandType.Text;
                    Comobject1.CommandType = CommandType.Text;
                    Comobject.ExecuteNonQuery();
                    Comobject1.ExecuteNonQuery();
                    Response.Write("<script>alert('Your Registration Is Succesful. You can Log in with your Name  as the UserName and password as the matricNo')</Script>");
                    ListBox1.Items.Clear();
                    txtemail.Text = "";
                    txtgrade.Text = "";
                    txtlevel.Text = "";
                    txtmat.Text = "";
                    txtName.Text = "";
                    txtphone.Text = "";
                    txtsession.Text = "";
                    
                }

                catch (Exception ex)
                {
                    string msg = "Insert Error:";
                    msg += ex.Message;
                    throw new Exception(msg);
                }
                finally
                {
                    Conobject.Close();
                }


            }    
            
                      
            } 
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Testing for cd HND
        if (txtmat.Text.Contains("cs") && txtmat.Text.Contains("hnd"))
        {
            string constr;
            constr = "Data Source=COLE-PC\\SQLEXPRESS;";
            constr = constr + "Initial Catalog=Voting_System ;";
            constr = constr + "Integrated Security= True;";
            SqlConnection Conobj = new SqlConnection(constr);

            try
            {

                Conobj.Open();
                string sqlstate = "SELECT Slate1,Slate3 FROM ElectionSlating WHERE Department = '" + "Computer Science" + "'";
                string sql2 ="SELECT Post FROM CandidateReg WHERE Post ='" + "P.R.O" + "'";
                string sql3 = "SELECT Post FROM CandidateReg WHERE Post ='" + "Treasurer" + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate);
                SqlCommand Comob = new SqlCommand(sql2);
                SqlCommand Comob1 = new SqlCommand(sql3);
                SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
                SqlDataAdapter ReadObj = new SqlDataAdapter(Comob.CommandText, Conobj);
                SqlDataAdapter ReadObj1 = new SqlDataAdapter(Comob1.CommandText, Conobj);
                DataTable dtb = new DataTable();
                DataTable dtb1 = new DataTable();
                DataTable dtb2 = new DataTable();
                ReadObject.Fill(dtb);
                ReadObj.Fill(dtb1);
                ReadObj1.Fill(dtb2);
                int RowCount = dtb1.Rows.Count;
                int RowCount1 = dtb2.Rows.Count;
                if (RowCount < 2 && RowCount1 < 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt1, sltt3;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt1 = dtb.Rows[i]["Slate1"].ToString();
                        sltt3 = dtb.Rows[i]["Slate3"].ToString();

                        ListBox1.Items.Add(sltt1);
                        ListBox1.Items.Add(sltt3);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else if (RowCount == 2 && RowCount1 < 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt3;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt3 = dtb.Rows[i]["Slate3"].ToString();
                        ListBox1.Items.Add(sltt3);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else if (RowCount < 2 && RowCount1 == 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt2;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt2 = dtb.Rows[i]["Slate2"].ToString();
                        ListBox1.Items.Add(sltt2);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else
                {
                    Response.Write("<script>alert('No More Post Available for HND ')</Script>");
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
        //Testind for cs ND
        else if (txtmat.Text.Contains("cs") && txtmat.Text.Contains("nd"))
        {

            string constr;
            constr = "Data Source=COLE-PC\\SQLEXPRESS;";
            constr = constr + "Initial Catalog=Voting_System ;";
            constr = constr + "Integrated Security= True;";
            SqlConnection Conobj = new SqlConnection(constr);

            try
            {

                Conobj.Open();
                string sqlstate = "SELECT Slate2 FROM ElectionSlating WHERE Department = '" + "Computer Science" + "'";
                string sql1 = "SELECT Post FROM CandidateReg WHERE Post ='" + "A.G.S" + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate);
                SqlCommand Comobjects1 = new SqlCommand(sql1);
                SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
                SqlDataAdapter ReadObject1 = new SqlDataAdapter(Comobjects1.CommandText, Conobj);
                DataTable dtb = new DataTable();
                DataTable dtb1 = new DataTable();
                ReadObject.Fill(dtb);
                ReadObject1.Fill(dtb1);
                int RowCount = dtb.Rows.Count;
                if (RowCount == 2)
                {
                    Response.Write("<script>alert('No More Post Available for ND ')</Script>");
                }
                else
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt2;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt2 = dtb.Rows[i]["Slate2"].ToString();

                        ListBox1.Items.Add(sltt2);

                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
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
        //Testing for HND slt
        else if (txtmat.Text.Contains("slt") && txtmat.Text.Contains("hnd"))
        {

            string constr;
            constr = "Data Source=COLE-PC\\SQLEXPRESS;";
            constr = constr + "Initial Catalog=Voting_System ;";
            constr = constr + "Integrated Security= True;";
            SqlConnection Conobj = new SqlConnection(constr);

            try
            {

                Conobj.Open();
                string sqlstate = "SELECT Slate1,Slate2 FROM ElectionSlating WHERE Department = '" + "S.L.T" + "'";
                string sql2 = "SELECT Post FROM CandidateReg WHERE Post ='" + "President" + "'";
                string sql3 = "SELECT Post FROM CandidateReg WHERE Post ='" + "Editor in Chief" + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate);
                SqlCommand Comob = new SqlCommand(sql2);
                SqlCommand Comob1 = new SqlCommand(sql3);
                SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
                SqlDataAdapter ReadObj = new SqlDataAdapter(Comob.CommandText, Conobj);
                SqlDataAdapter ReadObj1 = new SqlDataAdapter(Comob1.CommandText, Conobj);
                DataTable dtb = new DataTable();
                DataTable dtb1 = new DataTable();
                DataTable dtb2 = new DataTable();
                ReadObject.Fill(dtb);
                ReadObj.Fill(dtb1);
                ReadObj1.Fill(dtb2);
                int RowCount = dtb1.Rows.Count;
                int RowCount1 = dtb2.Rows.Count;
                if (RowCount < 2 && RowCount1 < 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt1, sltt2;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt1 = dtb.Rows[i]["Slate1"].ToString();
                        sltt2 = dtb.Rows[i]["Slate2"].ToString();

                        ListBox1.Items.Add(sltt1);
                        ListBox1.Items.Add(sltt2);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;  
                }
                else if (RowCount == 2 && RowCount1 < 2 )
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt2;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt2 = dtb.Rows[i]["Slate2"].ToString();
                        ListBox1.Items.Add(sltt2);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else if (RowCount < 2 && RowCount1 == 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt1;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt1 = dtb.Rows[i]["Slate1"].ToString();
                        ListBox1.Items.Add(sltt1);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else
                {
                    Response.Write("<script>alert('No More Post Available for HND ')</Script>");   
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
        //Testing for ND slt
        else if (txtmat.Text.Contains("slt") && txtmat.Text.Contains("nd"))
        {

            string constr;
            constr = "Data Source=COLE-PC\\SQLEXPRESS;";
            constr = constr + "Initial Catalog=Voting_System ;";
            constr = constr + "Integrated Security= True;";
            SqlConnection Conobj = new SqlConnection(constr);

            try
            {

                Conobj.Open();
                string sqlstate = "SELECT Slate3 FROM ElectionSlating WHERE Department = '" + "S.L.T" + "'";
                string sql1 = "SELECT Post FROM CandidateReg WHERE Post ='" + "Social Director" + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate);
                SqlCommand Comobjects1 = new SqlCommand(sql1);
                SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
                SqlDataAdapter ReadObject1 = new SqlDataAdapter(Comobjects1.CommandText, Conobj);
                DataTable dtb = new DataTable();
                DataTable dtb1 = new DataTable();
                ReadObject.Fill(dtb);
                ReadObject1.Fill(dtb1);
                int RowCount = dtb.Rows.Count;
                if (RowCount == 2)
                {
                    Response.Write("<script>alert('No More Post Available for ND ')</Script>");
                }
                else
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt3;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt3 = dtb.Rows[i]["Slate3"].ToString();

                        ListBox1.Items.Add(sltt3);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
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
            //Testing Food Tech HND
        else if (txtmat.Text.Contains("ft") && txtmat.Text.Contains("hnd"))
        {

            string constr;
            constr = "Data Source=COLE-PC\\SQLEXPRESS;";
            constr = constr + "Initial Catalog=Voting_System ;";
            constr = constr + "Integrated Security= True;";
            SqlConnection Conobj = new SqlConnection(constr);

            try
            {

                Conobj.Open();
                string sqlstate = "SELECT Slate1,Slate2 FROM ElectionSlating WHERE Department = '" + "Food Tech" + "'";
                string sql2 = "SELECT Post FROM CandidateReg WHERE Post ='" + "Auditor" + "'";
                string sql3 = "SELECT Post FROM CandidateReg WHERE Post ='" + "General Secretary" + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate);
                SqlCommand Comob = new SqlCommand(sql2);
                SqlCommand Comob1 = new SqlCommand(sql3);
                SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
                SqlDataAdapter ReadObj = new SqlDataAdapter(Comob.CommandText, Conobj);
                SqlDataAdapter ReadObj1 = new SqlDataAdapter(Comob1.CommandText, Conobj);
                DataTable dtb = new DataTable();
                DataTable dtb1 = new DataTable();
                DataTable dtb2 = new DataTable();
                ReadObject.Fill(dtb);
                ReadObj.Fill(dtb1);
                ReadObj1.Fill(dtb2);
                int RowCount = dtb1.Rows.Count;
                int RowCount1 = dtb2.Rows.Count;

                if (RowCount < 2 && RowCount1 < 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt1, sltt2;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt1 = dtb.Rows[i]["Slate1"].ToString();
                        sltt2 = dtb.Rows[i]["Slate2"].ToString();

                        ListBox1.Items.Add(sltt1);
                        ListBox1.Items.Add(sltt2);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else if (RowCount == 2 && RowCount1 < 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt2;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt2 = dtb.Rows[i]["Slate2"].ToString();
                        ListBox1.Items.Add(sltt2);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else if (RowCount < 2 && RowCount1 == 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt1;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt1 = dtb.Rows[i]["Slate1"].ToString();
                        ListBox1.Items.Add(sltt1);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else
                {
                    Response.Write("<script>alert('No More Post Available for HND ')</Script>");
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
            //Testing For Food tech ND
        else if (txtmat.Text.Contains("ft") && txtmat.Text.Contains("nd"))
        {

            string constr;
            constr = "Data Source=COLE-PC\\SQLEXPRESS;";
            constr = constr + "Initial Catalog=Voting_System ;";
            constr = constr + "Integrated Security= True;";
            SqlConnection Conobj = new SqlConnection(constr);

            try
            {

                Conobj.Open();
                string sqlstate = "SELECT Slate3 FROM ElectionSlating WHERE Department = '" + "Food Tech" + "'";
                string sql1 = "SELECT Post FROM CandidateReg WHERE Post ='" + "Vice President" + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate);
                SqlCommand Comobjects1 = new SqlCommand(sql1);
                SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
                SqlDataAdapter ReadObject1 = new SqlDataAdapter(Comobjects1.CommandText, Conobj);
                DataTable dtb = new DataTable();
                DataTable dtb1 = new DataTable();
                ReadObject.Fill(dtb);
                ReadObject1.Fill(dtb1);
                int RowCount = dtb.Rows.Count;
                if (RowCount == 2)
                {
                    Response.Write("<script>alert('No More Post Available for ND ')</Script>");
                }
                else
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt3;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt3 = dtb.Rows[i]["Slate3"].ToString();

                        ListBox1.Items.Add(sltt3);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
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
            //Testing For Math&Sttat hnd
        else if (txtmat.Text.Contains("ms") && txtmat.Text.Contains("hnd"))
        {

            string constr;
            constr = "Data Source=COLE-PC\\SQLEXPRESS;";
            constr = constr + "Initial Catalog=Voting_System ;";
            constr = constr + "Integrated Security= True;";
            SqlConnection Conobj = new SqlConnection(constr);

            try
            {

                Conobj.Open();
                string sqlstate = "SELECT Slate2,Slate3 FROM ElectionSlating WHERE Department = '" + "Math&Stat" + "'";
                string sql2 = "SELECT Post FROM CandidateReg WHERE Post ='" + "Auditor" + "'";
                string sql3 = "SELECT Post FROM CandidateReg WHERE Post ='" + "General Secretary" + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate);
                SqlCommand Comob = new SqlCommand(sql2);
                SqlCommand Comob1 = new SqlCommand(sql3);
                SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
                SqlDataAdapter ReadObj = new SqlDataAdapter(Comob.CommandText, Conobj);
                SqlDataAdapter ReadObj1 = new SqlDataAdapter(Comob1.CommandText, Conobj);
                DataTable dtb = new DataTable();
                DataTable dtb1 = new DataTable();
                DataTable dtb2 = new DataTable();
                ReadObject.Fill(dtb);
                ReadObj.Fill(dtb1);
                ReadObj1.Fill(dtb2);
                int RowCount = dtb1.Rows.Count;
                int RowCount1 = dtb2.Rows.Count;

                if (RowCount < 2 && RowCount1 < 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt1, sltt2;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt1 = dtb.Rows[i]["Slate1"].ToString();
                        sltt2 = dtb.Rows[i]["Slate2"].ToString();

                        ListBox1.Items.Add(sltt1);
                        ListBox1.Items.Add(sltt2);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else if (RowCount == 2 && RowCount1 < 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt2;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt2 = dtb.Rows[i]["Slate2"].ToString();
                        ListBox1.Items.Add(sltt2);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else if (RowCount < 2 && RowCount1 == 2)
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt1;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt1 = dtb.Rows[i]["Slate1"].ToString();
                        ListBox1.Items.Add(sltt1);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
                }
                else
                {
                    Response.Write("<script>alert('No More Post Available for HND ')</Script>");
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
            //Testing for Math&stat ND
        else if (txtmat.Text.Contains("ms") && txtmat.Text.Contains("nd"))
        {

            string constr;
            constr = "Data Source=COLE-PC\\SQLEXPRESS;";
            constr = constr + "Initial Catalog=Voting_System ;";
            constr = constr + "Integrated Security= True;";
            SqlConnection Conobj = new SqlConnection(constr);

            try
            {

                Conobj.Open();
                string sqlstate = "SELECT Slate1 FROM ElectionSlating WHERE Department = '" + "Math&Stat" + "'";
                string sql1 = "SELECT Post FROM CandidateReg WHERE Post ='" + "Sport Director" + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate);
                SqlCommand Comobjects1 = new SqlCommand(sql1);
                SqlDataAdapter ReadObject = new SqlDataAdapter(Comobjects.CommandText, Conobj);
                SqlDataAdapter ReadObject1 = new SqlDataAdapter(Comobjects1.CommandText, Conobj);
                DataTable dtb = new DataTable();
                DataTable dtb1 = new DataTable();
                ReadObject.Fill(dtb);
                ReadObject1.Fill(dtb1);
                int RowCount = dtb.Rows.Count;
                if (RowCount == 2)
                {
                    Response.Write("<script>alert('No More Post Available for ND ')</Script>");
                }
                else
                {
                    int RowCountg = dtb.Rows.Count;
                    string sltt1;
                    for (int i = 0; i < RowCountg; i++)
                    {
                        sltt1 = dtb.Rows[i]["Slate1"].ToString();

                        ListBox1.Items.Add(sltt1);
                    }
                    Button1.Visible = false;
                    txtmat.ReadOnly = true;
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
}