Imports MySql.Data.MySqlClient


Public Class Form1
    Public strConexo As String = "server=landshosting.com.br;user id=lands_conexao;password=conexao2015*;database=lands_eventos"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cbbEmail = PreencheCombo(cbbEmail, "SELECT email_txf FROM usuarios", "usuarios", "email_txf")
    End Sub

    Private Sub btnFiltraDados_Click(sender As Object, e As EventArgs) Handles btnFiltraDados.Click
        If mskCPF.TextLength = 14 And mskCPF.Text <> "   .   .   -" Then
            cbbEmail = PreencheCombo(cbbEmail, "SELECT email_txf FROM usuarios WHERE Cpf_txf = '" & mskCPF.Text & "' ", "usuarios", "email_txf")
        Else
            'Filtra os dados na Combo
            cbbEmail = PreencheCombo(cbbEmail, "SELECT email_txf FROM usuarios WHERE email_txf LIKE '%" & cbbEmail.Text & "%'", "usuarios", "email_txf")
        End If
    End Sub

    'Private Sub mskCPF_TextChanged(sender As Object, e As EventArgs) Handles mskCPF.TextChanged
    '    If mskCPF.Text <> "   .   .   -" Then
    '        cbbEmail.Enabled = False
    '        cbbEmail.DataSource = Nothing
    '    Else
    '        cbbEmail.Enabled = True
    '    End If
    'End Sub

    Private Sub cbbEmail_LostFocus(sender As Object, e As EventArgs) Handles cbbEmail.LostFocus
        Dim objConn As New MySqlConnection(strConexo)
        Dim objMySQLAdapter As MySqlDataAdapter
        Dim dtsMySQL As New DataSet

        Try
            objConn.Open()
            Try
                objMySQLAdapter = New MySqlDataAdapter("SELECT inscricoes.email_txf, pago_sel, formulario_txf, evento_txf, cpf_txf " _
                                                     & "FROM usuarios RIGHT JOIN inscricoes " _
                                                     & "ON usuarios.email_txf = inscricoes.email_txf " _
                                                     & "WHERE inscricoes.Email_txf = '" & cbbEmail.Text.ToString & "'", objConn)
                objMySQLAdapter.Fill(dtsMySQL)
                cbbEmail.DataSource = dtsMySQL.Tables(0)
                cbbEmail.DisplayMember = "email_txf"
                mskCPF.Text = dtsMySQL.Tables(0).Rows(0).Item("cpf_txf").ToString
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


    Private Sub cbbEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles cbbEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbbEmail = PreencheCombo(cbbEmail, "SELECT email_txf FROM usuarios WHERE email_txf LIKE '%" & cbbEmail.Text & "%'", "usuarios", "email_txf")
        End If
        If e.KeyCode = Keys.Delete Then
            cbbEmail.DataSource = Nothing
        End If
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

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim objConn As New MySqlConnection(strConexo)
    '    Dim objMySQLAdapter As MySqlDataAdapter
    '    Dim objMySQLDataSet As New DataSet

    '    'Dados servidor Lands
    '    '---------------------------
    '    'Servidor = landshosting.com.br
    '    'usuario = lands_conexao
    '    'senha = conexao2015*
    '    'database = lands_eventos
    '    'http://painel.landsdigital.com.br/adminer/adminer/adminer
    '    '---------------------------

    '    Try
    '        objConn.Open()
    '        Try
    '            objMySQLAdapter = New MySqlDataAdapter("SELECT usuarios.email_txf, pago_sel,formulario_txf ,evento_txf " _
    '                                                 & "FROM usuarios INNER JOIN inscricoes " _
    '                                                 & "ON usuarios.email_txf = usuarios.email_txf", objConn)
    '            objMySQLAdapter.Fill(objMySQLDataSet, "usuarios")
    '            DataGridView1.DataSource = objMySQLDataSet.Tables(0)
    '        Catch myerro As MySqlException
    '            MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
    '        End Try
    '        objConn.Close()
    '    Catch myerro As MySqlException
    '        MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
    '    Finally
    '        objConn.Dispose()
    '    End Try
    'End Sub

End Class
