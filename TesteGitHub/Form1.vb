Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection
        Dim MySqlCommand As New MySqlCommand
        Dim MySQLAdapter As MySqlDataAdapter
        Dim MySQLDataSet As DataSet
        Dim strSQL As String

        'Pegar os dados no SKYPE
        'segunda linha de comentário

        conn.ConnectionString = "server=localhost;user id=root;password=mac;database=northwind"

        strSQL = "SELECT * FROM northwind.employees"

        Try
            conn.Open()
            Try
                MySqlCommand.Connection = conn
                MySqlCommand.CommandText = strSQL
                MySQLAdapter.SelectCommand = MySqlCommand
                MySQLAdapter.Fill(MySQLDataSet)
                DataGridView1.DataSource = MySQLDataSet
            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class
