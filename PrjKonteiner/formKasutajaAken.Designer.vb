<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKasutajaAken
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPoora1 = New System.Windows.Forms.Button()
        Me.btn2Poora = New System.Windows.Forms.Button()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sisendtekst"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pooramine funktsiooniga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pooramine protseduuriga"
        '
        'btnPoora1
        '
        Me.btnPoora1.Location = New System.Drawing.Point(177, 84)
        Me.btnPoora1.Name = "btnPoora1"
        Me.btnPoora1.Size = New System.Drawing.Size(146, 23)
        Me.btnPoora1.TabIndex = 3
        Me.btnPoora1.Text = "Poora funktsiooniga"
        Me.btnPoora1.UseVisualStyleBackColor = True
        '
        'btn2Poora
        '
        Me.btn2Poora.Location = New System.Drawing.Point(177, 168)
        Me.btn2Poora.Name = "btn2Poora"
        Me.btn2Poora.Size = New System.Drawing.Size(146, 23)
        Me.btn2Poora.TabIndex = 4
        Me.btn2Poora.Text = "Poora protseduuriga"
        Me.btn2Poora.UseVisualStyleBackColor = True
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(184, 30)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(169, 22)
        Me.txtSisendTekst.TabIndex = 5
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(177, 113)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(169, 22)
        Me.txtValjundTekst1.TabIndex = 6
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(177, 197)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(169, 22)
        Me.txtValjundTekst2.TabIndex = 7
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Controls.Add(Me.btn2Poora)
        Me.Controls.Add(Me.btnPoora1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formKasutajaAken"
        Me.Text = "Tekstitootlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPoora1 As Button
    Friend WithEvents btn2Poora As Button
    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents txtValjundTekst2 As TextBox
End Class
