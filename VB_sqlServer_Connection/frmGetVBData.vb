Imports System.Data.SqlClient
Imports System.IO
Public Class frmGetVBData

    Dim sqlConn As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=UsingADO;Integrated Security=True")

    Dim strSelectCmd As String = "SELECT ContactID, FName, LName FROM Customers ORDER BY LName"

    Private Sub cmdPress_Click(sender As System.Object, e As System.EventArgs) Handles cmdPress.Click


        Try
            sqlConn.Open()

            DisplayState(sqlConn)

            txtDisplay.Text = DisplayData(strSelectCmd, sqlConn).ToString

            sqlConn.Close()

            DisplayState(sqlConn)

        Catch ex As SqlException

            MessageBox.Show(ex.Message, "There has been an error")

        End Try

    End Sub

    Private Sub DisplayState(ByVal Connection As SqlConnection)


        Select Case Connection.State

            Case ConnectionState.Open

                MessageBox.Show("Your connection to " & Connection.Database.ToString & " is open")

            Case ConnectionState.Closed

                MessageBox.Show("Your connection to " & Connection.Database.ToString & " is closed")

        End Select

    End Sub

    Private Function DisplayData(ByVal Command As String, ByVal Connection As SqlConnection) As StringWriter

        Dim sWriter As New StringWriter

        Dim daContacts As New SqlDataAdapter(Command, Connection)

        Dim dsTheDataSet As New DataSet("TheDataSet")

        sWriter.WriteLine("Name of DataSet = " & dsTheDataSet.DataSetName.ToString & vbCrLf)

        daContacts.Fill(dsTheDataSet, "Customers")

        sWriter.WriteLine("")
        sWriter.WriteLine("{0}", dsTheDataSet.Tables(0).TableName)
        sWriter.WriteLine("*************")

        For Each row As DataRow In dsTheDataSet.Tables("Customers").Rows

            sWriter.WriteLine("Customer No. {0} {1} {2}", row("ContactID"), row("FName"), row("LName"))

        Next row

        Return sWriter

    End Function

    Private Sub cmdShowCode_Click(sender As System.Object, e As System.EventArgs) Handles cmdShowCode.Click

        Dim frmShowVBcode As New frmVBCode

        frmShowVBcode.ShowDialog(Me)

    End Sub

End Class
