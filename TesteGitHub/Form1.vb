Imports MySql.Data.MySqlClient


Public Class Form1
    Public strConexo As String = "server=landshosting.com.br;user id=lands_conexao;password=conexao2015*;database=lands_eventos"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtCPF.Checked = True
        cboLPT.Items.Add("1")
        cboLPT.Items.Add("2")
        cboLPT.Items.Add("3")
        cboLPT.Items.Add("4")
        cboLPT.Items.Add("5")
        cboTipo.Items.Add("VISITANTE")
        cboTipo.Items.Add("IMPRENSA")
        cboTipo.Items.Add("EXPOSITOR")
        cboLPT.SelectedIndex = 0
        cboTipo.SelectedIndex = 0

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

        Select UCase("Visitante")
            Case "VISITANTE"
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
            Case "IMPRENSA"
            Case "EXPOSITOR"
        End Select

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
                'REGRAS PARA VALIDAÇÃO DA ETIQUETA
                '------------------
                '1) Verificar o tamanho do campo NOME
                '2) Verificar o tamanho do campo EMPRESA
                '3) Verificar o tamanho do campo PALESTRAS
                ') Verificar se o tipo é Expositor para verificar se o campo PAGO está como TRUE

                '------------------
                'IMPRIMIR ETIQUETA
                '------------------
                Dim swrArquivo As System.IO.StreamWriter

                'verifica se o arquivo existe e apague se for necessário
                If System.IO.File.Exists("C:\CSEtiqueta\arquivoEPL2.txt") Then
                    System.IO.File.Delete("C:\CSEtiqueta\arquivoEPL2.txt")
                End If
                swrArquivo = System.IO.File.CreateText("C:\CSEtiqueta\arquivoEPL2.txt")
                Select Case UCase("Visitante")
                    Case "VISITANTE"
                        swrArquivo.WriteLine("N")
                        swrArquivo.WriteLine("A30, 20, 0, 4, 1, 1, N, PALESTRA DEUS E BOM")
                        swrArquivo.WriteLine("A30, 60, 0, 4, 1, 1, N, CAMINHO A VERDADE E A VIDA")
                        swrArquivo.WriteLine("A20, 120, 0, 3, 1, 1, N, ------------------------------")
                        swrArquivo.WriteLine("A20, 160, 0, 3, 1, 1, N, VISITANTE")
                        swrArquivo.WriteLine("A20, 200, 0, 3, 1, 1, N, ANDERSON FERREIRA DA COSTA")
                        swrArquivo.WriteLine("P1")
                    Case "IMPRENSA"
                        swrArquivo.WriteLine("N")
                        swrArquivo.WriteLine("A30, 40, 0, 4, 1, 1, N, ANDERSON FERREIRA DA COSTA")
                        swrArquivo.WriteLine("A30, 80, 0, 3, 1, 1, N, ------------------------------")
                        swrArquivo.WriteLine("A20, 120, 0, 3, 1, 1, N, IMPRENSA")
                        swrArquivo.WriteLine("A20, 160, 0, 4, 1, 1, N, RBS - LAGES")
                        swrArquivo.WriteLine("P1")
                    Case "EXPOSITOR"
                        swrArquivo.WriteLine("N")
                        swrArquivo.WriteLine("A30, 40, 0, 4, 1, 1, N, ANDERSON FERREIRA DA COSTA")
                        swrArquivo.WriteLine("A30, 80, 0, 3, 1, 1, N, ------------------------------")
                        swrArquivo.WriteLine("A20, 120, 0, 3, 1, 1, N, EXPOSITOR")
                        swrArquivo.WriteLine("A20, 160, 0, 4, 1, 1, N, SOFTECSUL TECNOLIGIA LTDA")
                        swrArquivo.WriteLine("P1")
                End Select
                swrArquivo.Close()

                Try
                    System.IO.File.Copy("C:\CSEtiqueta\arquivoEPL2.txt", "LPT " & cboLPT.Text)
                Catch ex As Exception
                    Console.WriteLine("Erro ao enviar arquivo para impressora em LPT " & cboLPT.Text & "!")
                End Try
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

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub
End Class
