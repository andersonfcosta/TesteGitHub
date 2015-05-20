Public Class frmExpositor
    Private Sub cmdInserir_Click(sender As Object, e As EventArgs) Handles cmdInserir.Click
        lsbNomes.Items.Add(txtNome.Text.ToString)
        txtNome.Text = ""
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        '------------------
        'IMPRIMIR ETIQUETA
        '------------------
        Dim swrArquivo As System.IO.StreamWriter
        Dim intCont As Integer = 0

        For intCont = 1 To lsbNomes.Items.Count
            'verifica se o arquivo existe e apague se for necessário
            If System.IO.File.Exists("C:\CSEtiqueta\arquivoEPL2.txt") Then
                System.IO.File.Delete("C:\CSEtiqueta\arquivoEPL2.txt")
            End If
            swrArquivo = System.IO.File.CreateText("C:\CSEtiqueta\arquivoEPL2.txt")
            swrArquivo.WriteLine("N")
            swrArquivo.WriteLine("A30,40,0,4,1,1,N," & """" & lsbNomes.Items(intCont - 1).ToString & """")
            swrArquivo.WriteLine("A30,80,0,3,1,1,N," & """" & "------------------------------" & """")
            swrArquivo.WriteLine("A20,120,0,3,1,1,N," & """" & "EXPOSITOR" & """")
            swrArquivo.WriteLine("A20,160,0,4,1,1,N," & """" & txtExpositor.Text.ToString & """")
            swrArquivo.WriteLine("P1")
            swrArquivo.Close()
            'System.IO.File.Copy("C:\CSEtiqueta\arquivoEPL2.txt", "LPT" & Form1.cboTipo.Text)
        Next
    End Sub
End Class