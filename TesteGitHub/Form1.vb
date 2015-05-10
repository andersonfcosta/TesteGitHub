Imports MySql.Data.MySqlClient


Public Class Form1
    Public strConexo As String = "server=landshosting.com.br;user id=lands_conexao;password=conexao2015*;database=lands_eventos"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtCPF.Checked = True
    End Sub

    Private Sub rbtCPF_Click(sender As Object, e As EventArgs) Handles rbtCPF.Click
        If rbtCPF.Checked = True Then
            mskCPF.Mask = "999,999,999-99"
        End If
    End Sub

    Private Sub rbtEmail_Click(sender As Object, e As EventArgs) Handles rbtEmail.Click
        If rbtEmail.Checked = True Then
            mskCPF.Mask = ""
        End If
    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        Dim objConn As New MySqlConnection(strConexo)
        Dim objMySQLAdapter As MySqlDataAdapter
        Dim dtsMySQL As New DataSet
        Dim strDadosPesquisa As String

        If rbtCPF.Checked = True Then
            strDadosPesquisa = "SELECT Nome_txf, inscricoes.email_txf as Email, formulario_txf as Palestra, cpf_txf as CPF, pago_sel as Pagamento " _
                             & "FROM usuarios RIGHT JOIN inscricoes " _
                             & "ON usuarios.email_txf = inscricoes.email_txf " _
                             & "WHERE Cpf_txf = '" & mskCPF.Text.ToString & "'"
        Else
            If rbtEmail.Checked = True Then
                strDadosPesquisa = "SELECT Nome_txf, inscricoes.email_txf as Email, formulario_txf as Palestra, cpf_txf as CPF, pago_sel as Pagamento " _
                            & "FROM usuarios RIGHT JOIN inscricoes " _
                            & "ON usuarios.email_txf = inscricoes.email_txf " _
                            & "WHERE inscricoes.Email_txf LIKE '%" & mskCPF.Text.ToString & "%'"
            Else
                MsgBox("Não foi selecionado o tipo de pesquisa!!!")
            End If
        End If
        
        Try
            objConn.Open()
            Try
                objMySQLAdapter = New MySqlDataAdapter(strDadosPesquisa, objConn)
                objMySQLAdapter.Fill(dtsMySQL)
                dgvDados.DataSource = dtsMySQL.Tables(0)
                mskCPF.Text = ""
                dgvDados.Columns.Item(0).Width = 200
                dgvDados.Columns.Item(1).Width = 200
                dgvDados.Columns.Item(4).Width = 80
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

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
        If dgvDados.Rows(e.RowIndex).Cells(4).Value.ToString = "NAO" Then
            MsgBox("Não é possível gerar etiquetas para" _
        & vbCrLf & "palestras que não foram pagas !", MsgBoxStyle.Critical, "Aviso do Sistema")
        Else
            If MsgBox("Deseja imprimir a etiqueta:" _
           & vbCrLf & "Nome : " & dgvDados.Rows(e.RowIndex).Cells(0).Value.ToString _
           & vbCrLf & "Palestra : " & dgvDados.Rows(e.RowIndex).Cells(2).Value.ToString, MsgBoxStyle.YesNo, "Aviso do Sistema") = MsgBoxResult.Yes Then
                '------------------
                'Imprimir etiqueta
                '------------------
            End If
        End If
    End Sub

    'Public Function PreencheCombo(ByRef ObjetoComboBox As ComboBox, SQL As String, Tabela As String, Campo As String) As ComboBox
    '    Dim objConn As New MySqlConnection(strConexo)
    '    Dim objMySQLAdapter As MySqlDataAdapter
    '    Dim objMySQLDataSet As New DataSet

    '    objConn.Open()
    '    objMySQLAdapter = New MySqlDataAdapter(SQL, objConn)
    '    objMySQLAdapter.Fill(objMySQLDataSet, Tabela)
    '    ObjetoComboBox.DataSource = objMySQLDataSet.Tables(0)
    '    ObjetoComboBox.DisplayMember = Campo

    '    Return ObjetoComboBox
    'End Function

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
