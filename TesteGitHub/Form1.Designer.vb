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
        Me.mskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.rbtCPF = New System.Windows.Forms.RadioButton()
        Me.rbtEmail = New System.Windows.Forms.RadioButton()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboLPT = New System.Windows.Forms.ComboBox()
        Me.lblLPT = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mskCPF
        '
        Me.mskCPF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCPF.Location = New System.Drawing.Point(10, 42)
        Me.mskCPF.Mask = "999,999,999-99"
        Me.mskCPF.Name = "mskCPF"
        Me.mskCPF.Size = New System.Drawing.Size(343, 19)
        Me.mskCPF.TabIndex = 10
        Me.mskCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbtCPF
        '
        Me.rbtCPF.AutoSize = True
        Me.rbtCPF.Location = New System.Drawing.Point(77, 19)
        Me.rbtCPF.Name = "rbtCPF"
        Me.rbtCPF.Size = New System.Drawing.Size(45, 17)
        Me.rbtCPF.TabIndex = 12
        Me.rbtCPF.TabStop = True
        Me.rbtCPF.Text = "CPF"
        Me.rbtCPF.UseVisualStyleBackColor = True
        '
        'rbtEmail
        '
        Me.rbtEmail.AutoSize = True
        Me.rbtEmail.Location = New System.Drawing.Point(10, 19)
        Me.rbtEmail.Name = "rbtEmail"
        Me.rbtEmail.Size = New System.Drawing.Size(50, 17)
        Me.rbtEmail.TabIndex = 13
        Me.rbtEmail.TabStop = True
        Me.rbtEmail.Text = "Email"
        Me.rbtEmail.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(7, 108)
        Me.dgvDados.MultiSelect = False
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.RowHeadersVisible = False
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(678, 149)
        Me.dgvDados.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TesteGitHub.My.Resources.Resources.Conexao
        Me.PictureBox1.Location = New System.Drawing.Point(589, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(368, 37)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(67, 29)
        Me.btnPesquisa.TabIndex = 16
        Me.btnPesquisa.Text = "Pesquisa"
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSair)
        Me.GroupBox1.Controls.Add(Me.lblLPT)
        Me.GroupBox1.Controls.Add(Me.cboLPT)
        Me.GroupBox1.Controls.Add(Me.rbtCPF)
        Me.GroupBox1.Controls.Add(Me.btnPesquisa)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.rbtEmail)
        Me.GroupBox1.Controls.Add(Me.mskCPF)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 90)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'cboLPT
        '
        Me.cboLPT.FormattingEnabled = True
        Me.cboLPT.Location = New System.Drawing.Point(46, 63)
        Me.cboLPT.Name = "cboLPT"
        Me.cboLPT.Size = New System.Drawing.Size(44, 21)
        Me.cboLPT.TabIndex = 17
        '
        'lblLPT
        '
        Me.lblLPT.AutoSize = True
        Me.lblLPT.Location = New System.Drawing.Point(13, 68)
        Me.lblLPT.Name = "lblLPT"
        Me.lblLPT.Size = New System.Drawing.Size(27, 13)
        Me.lblLPT.TabIndex = 18
        Me.lblLPT.Text = "LPT"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(500, 52)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(83, 34)
        Me.btnSair.TabIndex = 19
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(692, 263)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvDados)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rbtCPF As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEmail As System.Windows.Forms.RadioButton
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnPesquisa As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLPT As System.Windows.Forms.Label
    Friend WithEvents cboLPT As System.Windows.Forms.ComboBox
    Friend WithEvents btnSair As System.Windows.Forms.Button

End Class
