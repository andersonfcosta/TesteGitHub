<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbbEmail = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gboEtiqueta = New System.Windows.Forms.GroupBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.btnFiltraDados = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboEtiqueta.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbEmail
        '
        Me.cbbEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbEmail.FormattingEnabled = True
        Me.cbbEmail.Location = New System.Drawing.Point(144, 11)
        Me.cbbEmail.Name = "cbbEmail"
        Me.cbbEmail.Size = New System.Drawing.Size(212, 21)
        Me.cbbEmail.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TesteGitHub.My.Resources.Resources.Conexao
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'gboEtiqueta
        '
        Me.gboEtiqueta.BackColor = System.Drawing.Color.White
        Me.gboEtiqueta.Controls.Add(Me.lblNome)
        Me.gboEtiqueta.Location = New System.Drawing.Point(12, 93)
        Me.gboEtiqueta.Name = "gboEtiqueta"
        Me.gboEtiqueta.Size = New System.Drawing.Size(344, 100)
        Me.gboEtiqueta.TabIndex = 6
        Me.gboEtiqueta.TabStop = False
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(6, 14)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(277, 25)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Anderson Ferreira da Costa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "E-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "CPF"
        '
        'mskCPF
        '
        Me.mskCPF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCPF.Location = New System.Drawing.Point(197, 37)
        Me.mskCPF.Mask = "999,999,999-99"
        Me.mskCPF.Name = "mskCPF"
        Me.mskCPF.Size = New System.Drawing.Size(159, 22)
        Me.mskCPF.TabIndex = 10
        Me.mskCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFiltraDados
        '
        Me.btnFiltraDados.Location = New System.Drawing.Point(105, 65)
        Me.btnFiltraDados.Name = "btnFiltraDados"
        Me.btnFiltraDados.Size = New System.Drawing.Size(251, 22)
        Me.btnFiltraDados.TabIndex = 11
        Me.btnFiltraDados.Text = "Filtra Dados"
        Me.btnFiltraDados.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(365, 210)
        Me.Controls.Add(Me.btnFiltraDados)
        Me.Controls.Add(Me.mskCPF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gboEtiqueta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbbEmail)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboEtiqueta.ResumeLayout(False)
        Me.gboEtiqueta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbbEmail As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gboEtiqueta As System.Windows.Forms.GroupBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnFiltraDados As System.Windows.Forms.Button

End Class
