<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kalkulator
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.tambah = New System.Windows.Forms.Button
        Me.kurang = New System.Windows.Forms.Button
        Me.bagi = New System.Windows.Forms.Button
        Me.kali = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KALKULATOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input Angka Pertama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Input Angka Kedua"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(212, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(212, 114)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(161, 20)
        Me.TextBox2.TabIndex = 4
        '
        'tambah
        '
        Me.tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambah.Location = New System.Drawing.Point(47, 155)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(62, 48)
        Me.tambah.TabIndex = 5
        Me.tambah.Text = "+"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'kurang
        '
        Me.kurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kurang.Location = New System.Drawing.Point(121, 155)
        Me.kurang.Name = "kurang"
        Me.kurang.Size = New System.Drawing.Size(62, 48)
        Me.kurang.TabIndex = 6
        Me.kurang.Text = "-"
        Me.kurang.UseVisualStyleBackColor = True
        '
        'bagi
        '
        Me.bagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bagi.Location = New System.Drawing.Point(200, 155)
        Me.bagi.Name = "bagi"
        Me.bagi.Size = New System.Drawing.Size(64, 48)
        Me.bagi.TabIndex = 7
        Me.bagi.Text = "/"
        Me.bagi.UseVisualStyleBackColor = True
        '
        'kali
        '
        Me.kali.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kali.Location = New System.Drawing.Point(281, 155)
        Me.kali.Name = "kali"
        Me.kali.Size = New System.Drawing.Size(65, 48)
        Me.kali.TabIndex = 8
        Me.kali.Text = "x"
        Me.kali.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Hasil Perhitungan"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(212, 224)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(161, 20)
        Me.TextBox3.TabIndex = 10
        '
        'kalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(408, 331)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.kali)
        Me.Controls.Add(Me.bagi)
        Me.Controls.Add(Me.kurang)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "kalkulator"
        Me.Text = "kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tambah As System.Windows.Forms.Button
    Friend WithEvents kurang As System.Windows.Forms.Button
    Friend WithEvents bagi As System.Windows.Forms.Button
    Friend WithEvents kali As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
