using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

public partial class CS : System.Web.UI.Page
{
    protected void UsersReport(object sender, EventArgs e)
    {
        //Upload and save the file
        string csvPath = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload1.PostedFile.FileName);
        FileUpload1.SaveAs(csvPath);

        //Create a DataTable.
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[4] 
        { new DataColumn("Id", typeof(string)),
        new DataColumn("Name", typeof(string)),
        new DataColumn("First Activity", typeof(string)),
        new DataColumn("Last Activity",typeof(string)) });

        //Read the contents of CSV file.
        string csvData = File.ReadAllText(csvPath);

        //Execute a loop over the rows.
        foreach (string row in csvData.Split('\n'))
        {
            if (!string.IsNullOrEmpty(row))
            {
                dt.Rows.Add();
                int i = 0;

                //Execute a loop over the columns.
                foreach (string cell in row.Split(','))
                {
                    dt.Rows[dt.Rows.Count - 1][i] = cell;
                    i++;
                }
            }
        }

        //Bind the DataTable.
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void EntitySummary(object sender, EventArgs e)
    {
        //Upload and save the file
        string csvPath1 = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload2.PostedFile.FileName);
        FileUpload2.SaveAs(csvPath1);

        //Create a DataTable.
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[13]
        {

         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),

         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),
         new DataColumn("", typeof(string)),

        });

        //Read the contents of CSV file.
        string csvData = File.ReadAllText(csvPath1);
        //Execute a loop over the rows.
        foreach (string row in csvData.Split('\n'))
        {
            if (!string.IsNullOrEmpty(row))
            {
                dt.Rows.Add();
                int i = 0;

                //Execute a loop over the columns.
                foreach (string cell in row.Split(','))
                {
                    dt.Rows[dt.Rows.Count - 1][i] = cell;
                    i++;
                }
            }
        }

        //Bind the DataTable.
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }



    protected void AssessmentSummary(object sender, EventArgs e)
    {
        //Upload and save the file
        string csvPath2 = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload3.PostedFile.FileName);
        FileUpload3.SaveAs(csvPath2);

        //Create a DataTable.
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[10]
        {
          new DataColumn("AssessId", typeof(string)),
          new DataColumn("Name", typeof(string)),
          new DataColumn("Created", typeof(string)),
          new DataColumn("Created By", typeof(string)),
          new DataColumn("Assigned To", typeof(string)),
          new DataColumn("Not Started", typeof(string)),
          new DataColumn("In Progress", typeof(string)),
          new DataColumn("Pending", typeof(string)),
          new DataColumn("Passed", typeof(string)),
          new DataColumn("Failed", typeof(string)),



        });

        //Read the contents of CSV file.
        string csvData = File.ReadAllText(csvPath2);

        //Execute a loop over the rows.
        foreach (string row in csvData.Split('\n'))
        {
            if (!string.IsNullOrEmpty(row))
            {
                dt.Rows.Add();
                int i = 0;

                //Execute a loop over the columns.
                foreach (string cell in row.Split(','))
                {
                    dt.Rows[dt.Rows.Count - 1][i] = cell;
                    i++;
                }
            }
        }

        //Bind the DataTable.
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}