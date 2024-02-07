<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formKasutajaAken
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPoora1 = New System.Windows.Forms.Button()
        Me.btn2Poora = New System.Windows.Forms.Button()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStopp = New System.Windows.Forms.Button()
        Me.TimerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblVowels = New System.Windows.Forms.Label()
        Me.Algoritmiline = New System.Windows.Forms.CheckBox()
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
        Me.txtValjundTekst1.Enabled = False
        Me.txtValjundTekst1.Location = New System.Drawing.Point(177, 113)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(169, 22)
        Me.txtValjundTekst1.TabIndex = 6
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Enabled = False
        Me.txtValjundTekst2.Location = New System.Drawing.Point(177, 197)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(169, 22)
        Me.txtValjundTekst2.TabIndex = 7
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(382, 111)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStopp
        '
        Me.btnStopp.Enabled = False
        Me.btnStopp.Location = New System.Drawing.Point(382, 141)
        Me.btnStopp.Name = "btnStopp"
        Me.btnStopp.Size = New System.Drawing.Size(75, 23)
        Me.btnStopp.TabIndex = 9
        Me.btnStopp.Text = "Stop"
        Me.btnStopp.UseVisualStyleBackColor = True
        '
        'TimerUuenda
        '
        Me.TimerUuenda.Interval = 5000
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(360, 35)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(16, 16)
        Me.lblLength.TabIndex = 10
        Me.lblLength.Text = "..."
        '
        'lblVowels
        '
        Me.lblVowels.AutoSize = True
        Me.lblVowels.Location = New System.Drawing.Point(415, 35)
        Me.lblVowels.Name = "lblVowels"
        Me.lblVowels.Size = New System.Drawing.Size(16, 16)
        Me.lblVowels.TabIndex = 11
        Me.lblVowels.Text = "..."
        '
        'Algoritmiline
        '
        Me.Algoritmiline.AutoSize = True
        Me.Algoritmiline.Location = New System.Drawing.Point(248, 279)
        Me.Algoritmiline.Name = "Algoritmiline"
        Me.Algoritmiline.Size = New System.Drawing.Size(157, 20)
        Me.Algoritmiline.TabIndex = 12
        Me.Algoritmiline.Text = "Sorteeri algoritmiliselt"
        Me.Algoritmiline.UseVisualStyleBackColor = True
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Algoritmiline)
        Me.Controls.Add(Me.lblVowels)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.btnStopp)
        Me.Controls.Add(Me.btnStart)
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
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStopp As Button
    Friend WithEvents TimerUuenda As Timer
    Friend WithEvents lblLength As Label
    Friend WithEvents lblVowels As Label
    Friend WithEvents Algoritmiline As CheckBox
    Private WithEvents txtValjundTekst1 As TextBox
    Private WithEvents txtValjundTekst2 As TextBox
End Class
