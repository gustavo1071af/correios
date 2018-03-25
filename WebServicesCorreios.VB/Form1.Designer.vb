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
        Me.TbEstado = New System.Windows.Forms.TextBox()
        Me.TbCidade = New System.Windows.Forms.TextBox()
        Me.TbBairro = New System.Windows.Forms.TextBox()
        Me.TbComplemento2 = New System.Windows.Forms.TextBox()
        Me.TbComplemento = New System.Windows.Forms.TextBox()
        Me.TbEndereco = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblComplemento2 = New System.Windows.Forms.Label()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.TbCEP = New System.Windows.Forms.MaskedTextBox()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TbEstado
        '
        Me.TbEstado.Enabled = False
        Me.TbEstado.Location = New System.Drawing.Point(18, 275)
        Me.TbEstado.Name = "TbEstado"
        Me.TbEstado.Size = New System.Drawing.Size(282, 20)
        Me.TbEstado.TabIndex = 29
        '
        'TbCidade
        '
        Me.TbCidade.Enabled = False
        Me.TbCidade.Location = New System.Drawing.Point(18, 235)
        Me.TbCidade.Name = "TbCidade"
        Me.TbCidade.Size = New System.Drawing.Size(282, 20)
        Me.TbCidade.TabIndex = 27
        '
        'TbBairro
        '
        Me.TbBairro.Enabled = False
        Me.TbBairro.Location = New System.Drawing.Point(18, 195)
        Me.TbBairro.Name = "TbBairro"
        Me.TbBairro.Size = New System.Drawing.Size(282, 20)
        Me.TbBairro.TabIndex = 25
        '
        'TbComplemento2
        '
        Me.TbComplemento2.Enabled = False
        Me.TbComplemento2.Location = New System.Drawing.Point(18, 155)
        Me.TbComplemento2.Name = "TbComplemento2"
        Me.TbComplemento2.Size = New System.Drawing.Size(282, 20)
        Me.TbComplemento2.TabIndex = 23
        '
        'TbComplemento
        '
        Me.TbComplemento.Enabled = False
        Me.TbComplemento.Location = New System.Drawing.Point(18, 115)
        Me.TbComplemento.Name = "TbComplemento"
        Me.TbComplemento.Size = New System.Drawing.Size(282, 20)
        Me.TbComplemento.TabIndex = 21
        '
        'TbEndereco
        '
        Me.TbEndereco.Enabled = False
        Me.TbEndereco.Location = New System.Drawing.Point(18, 75)
        Me.TbEndereco.Name = "TbEndereco"
        Me.TbEndereco.Size = New System.Drawing.Size(282, 20)
        Me.TbEndereco.TabIndex = 19
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(18, 258)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 28
        Me.lblEstado.Text = "Estado"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(18, 218)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 26
        Me.lblCidade.Text = "Cidade"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(18, 178)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(34, 13)
        Me.lblBairro.TabIndex = 24
        Me.lblBairro.Text = "Bairro"
        '
        'lblComplemento2
        '
        Me.lblComplemento2.AutoSize = True
        Me.lblComplemento2.Location = New System.Drawing.Point(18, 138)
        Me.lblComplemento2.Name = "lblComplemento2"
        Me.lblComplemento2.Size = New System.Drawing.Size(80, 13)
        Me.lblComplemento2.TabIndex = 22
        Me.lblComplemento2.Text = "Complemento 2"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(18, 98)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(71, 13)
        Me.lblComplemento.TabIndex = 20
        Me.lblComplemento.Text = "Complemento"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(18, 58)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lblEndereco.TabIndex = 18
        Me.lblEndereco.Text = "Endereço"
        '
        'TbCEP
        '
        Me.TbCEP.Location = New System.Drawing.Point(18, 31)
        Me.TbCEP.Mask = "00000-000"
        Me.TbCEP.Name = "TbCEP"
        Me.TbCEP.Size = New System.Drawing.Size(100, 20)
        Me.TbCEP.TabIndex = 16
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(124, 29)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(176, 23)
        Me.BtBuscar.TabIndex = 17
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(15, 14)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(28, 13)
        Me.lblCEP.TabIndex = 15
        Me.lblCEP.Text = "CEP"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 308)
        Me.Controls.Add(Me.TbEstado)
        Me.Controls.Add(Me.TbCidade)
        Me.Controls.Add(Me.TbBairro)
        Me.Controls.Add(Me.TbComplemento2)
        Me.Controls.Add(Me.TbComplemento)
        Me.Controls.Add(Me.TbEndereco)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.lblComplemento2)
        Me.Controls.Add(Me.lblComplemento)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.TbCEP)
        Me.Controls.Add(Me.BtBuscar)
        Me.Controls.Add(Me.lblCEP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Busca CEP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents TbEstado As TextBox
    Private WithEvents TbCidade As TextBox
    Private WithEvents TbBairro As TextBox
    Private WithEvents TbComplemento2 As TextBox
    Private WithEvents TbComplemento As TextBox
    Private WithEvents TbEndereco As TextBox
    Private WithEvents lblEstado As Label
    Private WithEvents lblCidade As Label
    Private WithEvents lblBairro As Label
    Private WithEvents lblComplemento2 As Label
    Private WithEvents lblComplemento As Label
    Private WithEvents lblEndereco As Label
    Private WithEvents TbCEP As MaskedTextBox
    Private WithEvents BtBuscar As Button
    Private WithEvents lblCEP As Label
End Class
