Imports MySql.Data.MySqlClient


Public Class Form1
    Public strConexo As String = "server=landshosting.com.br;user id=lands_conexao;password=conexao2015*;database=lands_eventos"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objConn As New MySqlConnection(strConexo)
        Dim objMySQLAdapter As MySqlDataAdapter
        Dim objMySQLDataSet As New DataSet

        'Dados servidor Lands
        '---------------------------
        'Servidor = landshosting.com.br
        'usuario = lands_conexao
        'senha = conexao2015*
        'database = lands_eventos
        'http://painel.landsdigital.com.br/adminer/adminer/adminer
        '---------------------------

        Try
            objConn.Open()
            Try
                objMySQLAdapter = New MySqlDataAdapter("SELECT usuarios.email_txf, pago_sel,formulario_txf ,evento_txf " _
                                                     & "FROM usuarios INNER JOIN inscricoes " _
                                                     & "ON usuarios.email_txf = usuarios.email_txf", objConn)
                objMySQLAdapter.Fill(objMySQLDataSet, "usuarios")
                DataGridView1.DataSource = objMySQLDataSet.Tables(0)
            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            objConn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            objConn.Dispose()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbEmail = PreencheCombo(cbbEmail, "SELECT email_txf FROM usuarios", "usuarios", "email_txf")
    End Sub

    Public Function PreencheCombo(ByRef ObjetoComboBox As ComboBox, SQL As String, Tabela As String, Campo As String) As ComboBox
        Dim objConn As New MySqlConnection(strConexo)
        Dim objMySQLAdapter As MySqlDataAdapter
        Dim objMySQLDataSet As New DataSet

        objConn.Open()
        objMySQLAdapter = New MySqlDataAdapter(SQL, objConn)
        objMySQLAdapter.Fill(objMySQLDataSet, Tabela)
        ObjetoComboBox.DataSource = objMySQLDataSet.Tables(0)
        ObjetoComboBox.DisplayMember = Campo

        Return ObjetoComboBox
    End Function
End Class
