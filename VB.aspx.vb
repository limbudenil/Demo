Imports System.IO
Imports System.Data

Partial Class VB
    Inherits System.Web.UI.Page
    Protected Sub ImportCSV(sender As Object, e As EventArgs)
        'Upload and save the file
        Dim csvPath As String = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload1.PostedFile.FileName)
        FileUpload1.SaveAs(csvPath)

        'Create a DataTable.
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn(4) {New DataColumn("Id", GetType(Integer)), New DataColumn("Name", GetType(String)), New DataColumn("Technology", GetType(String)), New DataColumn("Company", GetType(String)), New DataColumn("Country", GetType(String))})

        'Read the contents of CSV file.
        Dim csvData As String = File.ReadAllText(csvPath)

        'Execute a loop over the rows.
        For Each row As String In csvData.Split(ControlChars.Lf)
            If Not String.IsNullOrEmpty(row) Then
                dt.Rows.Add()
                Dim i As Integer = 0

                'Execute a loop over the columns.
                For Each cell As String In row.Split(","c)
                    dt.Rows(dt.Rows.Count - 1)(i) = cell
                    i += 1
                Next
            End If
        Next

        'Bind the DataTable.
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub
End Class
