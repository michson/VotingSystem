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
    int vote1,vote2,vote3,vote4,vote5,vote6,vote7,vote8,vote9,vote10;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDeclarewin_Click(object sender, EventArgs e)
    {
        //fOR p.r.o
        string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog= Voting_System;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);
        try
        {
            Conobj.Open();
            string sqlstat = "SELECT VoteNo FROM Candidate_Result WHERE Post='" + "P.R.O" + "'";
            SqlCommand Comobj = new SqlCommand(sqlstat);
            SqlDataAdapter ReadObj = new SqlDataAdapter(Comobj.CommandText, Conobj);
            DataTable dt = new DataTable();
           
            ReadObj.Fill(dt);
            
                 vote1 = Convert.ToInt32(dt.Rows[0]["VoteNo"].ToString());
                 vote2 =Convert.ToInt32(dt.Rows[1]["VoteNo"].ToString());
                 
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
        //First Testing of Winner
        if (vote1 > vote2)
        {
            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Candidate_Result set Result = '" + "Winner" + "' WHERE VoteNo = '" + vote1 + "' AND Post ='" + "P.R.O" + "'";
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
        else if (vote2 > vote1)
        {
            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Candidate_Result set Result = '" + "Winner" + "' WHERE VoteNo = '" + vote2 + "' AND Post ='" + "P.R.O" + "'";
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
        else
        {
            Response.Write("<script>alert('No winner the Result is Equal')</Script>");
        }


        //Second Testing Of Winner========================================================================
        try
        {
            Conobj.Open();

        string sqlstat1 = "SELECT VoteNo FROM Candidate_Result WHERE Post='" + "A.G.S" + "'";
        SqlCommand Comobj1 = new SqlCommand(sqlstat1);
        SqlDataAdapter ReadObj1 = new SqlDataAdapter(Comobj1.CommandText, Conobj);
        DataTable dt1 = new DataTable();
        ReadObj1.Fill(dt1);
        vote3 = Convert.ToInt32(dt1.Rows[0]["VoteNo"].ToString());
        vote4 = Convert.ToInt32(dt1.Rows[1]["VoteNo"].ToString());
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
       
        if (vote3 > vote4)
        {
            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Candidate_Result set Result = '" + "Winner" + "' WHERE VoteNo = '" + vote3 + "' AND Post ='" +"A.G.S"+ "'";
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
        else if (vote4 > vote3)
        {
            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Candidate_Result set Result = '" + "Winner" + "' WHERE VoteNo = '" + vote4 + "' AND Post ='" + "A.G.S" + "'";
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
        else
        {
            Response.Write("<script>alert('No winner the Result is Equal')</Script>");
        }

        // Third testing =====================================================================
        try
        {
            Conobj.Open();

            string sqlstat12 = "SELECT VoteNo FROM Candidate_Result WHERE Post='" + "Treasurer" + "'";
            SqlCommand Comobj12 = new SqlCommand(sqlstat12);
            SqlDataAdapter ReadObj12 = new SqlDataAdapter(Comobj12.CommandText, Conobj);
            DataTable dt12 = new DataTable();
            ReadObj12.Fill(dt12);
            vote5 = Convert.ToInt32(dt12.Rows[0]["VoteNo"].ToString());
            vote6 = Convert.ToInt32(dt12.Rows[1]["VoteNo"].ToString());
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

        if (vote5 > vote6)
        {
            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Candidate_Result set Result = '" + "Winner" + "' WHERE VoteNo = '" + vote5 + "' AND Post ='" + "Treasurer" + "'";
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
        else if (vote6 > vote5)
        {
            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Candidate_Result set Result = '" + "Winner" + "' WHERE VoteNo = '" + vote6 + "' AND Post ='" + "Treasurer" + "'";
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
        else
        {
            Response.Write("<script>alert('No winner the Result is Equal')</Script>");
        }
        //Fouth Testing=========================================================================================
        try
        {
            Conobj.Open();

            string sqlstat1 = "SELECT VoteNo FROM Candidate_Result WHERE Post='" + "General Secretary" + "'";
            SqlCommand Comobj1 = new SqlCommand(sqlstat1);
            SqlDataAdapter ReadObj1 = new SqlDataAdapter(Comobj1.CommandText, Conobj);
            DataTable dt1 = new DataTable();
            ReadObj1.Fill(dt1);
            vote7 = Convert.ToInt32(dt1.Rows[0]["VoteNo"].ToString());
            vote8 = Convert.ToInt32(dt1.Rows[1]["VoteNo"].ToString());
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

        if (vote7 > vote8)
        {
            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Candidate_Result set Result = '" + "Winner" + "' WHERE VoteNo = '" + vote7 + "' AND Post ='" + "General Secretary" + "'";
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
        else if (vote8 > vote7)
        {
            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Candidate_Result set Result = '" + "Winner" + "' WHERE VoteNo = '" + vote8 + "' AND Post ='" + "General Secretary" + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
                Comobjects.ExecuteNonQuery();
                Response.Write("<script>alert('Winner has been declare, you can now Display the Result')</Script>");
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
        else
        {
            Response.Write("<script>alert('No winner the Result is Equal')</Script>");
   
        }

        //5th Testing =============================================================================
        try
        {
            Conobj.Open();

            string sqlstat1 = "SELECT VoteNo FROM Candidate_Result WHERE Post='" + "President" + "'";
            SqlCommand Comobj1 = new SqlCommand(sqlstat1);
            SqlDataAdapter ReadObj1 = new SqlDataAdapter(Comobj1.CommandText, Conobj);
            DataTable dt1 = new DataTable();
            ReadObj1.Fill(dt1);
            vote9 = Convert.ToInt32(dt1.Rows[0]["VoteNo"].ToString());
            vote10 = Convert.ToInt32(dt1.Rows[1]["VoteNo"].ToString());
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

        if (vote9 > vote10)
        {
            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Candidate_Result set Result = '" + "Winner" + "' WHERE VoteNo = '" + vote9 + "' AND Post ='" + "President" + "'";
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
        else if (vote10 > vote9)
        {
            try
            {

                Conobj.Open();
                string sqlstate = " UPDATE Candidate_Result set Result = '" + "Winner" + "' WHERE VoteNo = '" + vote10 + "' AND Post ='" + "President" + "'";
                SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
                Comobjects.ExecuteNonQuery();
                Response.Write("<script>alert('Winner has been declare, you can now Display the Result')</Script>");
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
        else
        {
            Response.Write("<script>alert('No winner the Result is Equal')</Script>");
        }
    }


    protected void Button13_Click(object sender, EventArgs e)
    {
 string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog= Voting_System;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);
        try
        {
            Conobj.Open();
            string sqlstate = " UPDATE Candidate_Result set ShowResult = '" + "Show" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
            Comobjects.ExecuteNonQuery();
            Response.Write("<script>alert('You Have Show The Result Publicly')</Script>");

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
        string constr;
        constr = "Data Source=COLE-PC\\SQLEXPRESS;";
        constr = constr + "Initial Catalog= Voting_System;";
        constr = constr + "Integrated Security= True;";
        SqlConnection Conobj = new SqlConnection(constr);
        try
        {
            Conobj.Open();
            string sqlstate = " UPDATE Candidate_Result set ShowResult = '" + "Hide" + "'";
            SqlCommand Comobjects = new SqlCommand(sqlstate, Conobj);
            Comobjects.ExecuteNonQuery();
            Response.Write("<script>alert('You Have Hide The Result  for Publicly')</Script>");

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
