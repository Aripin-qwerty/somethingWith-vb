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
        Me.hitung = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.kerja = New System.Windows.Forms.TextBox()
        Me.lembur = New System.Windows.Forms.TextBox()
        Me.absen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(446, 373)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(89, 24)
        Me.hitung.TabIndex = 0
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Penghitung Gaji Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jml Jam Kerja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jml Lembur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Jml Tidak Hadir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Total Gaji"
        '
        'kerja
        '
        Me.kerja.Location = New System.Drawing.Point(216, 87)
        Me.kerja.Name = "kerja"
        Me.kerja.Size = New System.Drawing.Size(129, 20)
        Me.kerja.TabIndex = 8
        '
        'lembur
        '
        Me.lembur.Location = New System.Drawing.Point(216, 128)
        Me.lembur.Name = "lembur"
        Me.lembur.Size = New System.Drawing.Size(129, 20)
        Me.lembur.TabIndex = 9
        '
        'absen
        '
        Me.absen.Location = New System.Drawing.Point(216, 174)
        Me.absen.Name = "absen"
        Me.absen.Size = New System.Drawing.Size(129, 20)
        Me.absen.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Uang Makan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(213, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(213, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "-"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 423)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.absen)
        Me.Controls.Add(Me.lembur)
        Me.Controls.Add(Me.kerja)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hitung)
        Me.Name = "Form1"
        Me.Text = "Penghitung Gaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hitung As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents kerja As System.Windows.Forms.TextBox
    Friend WithEvents lembur As System.Windows.Forms.TextBox
    Friend WithEvents absen As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
