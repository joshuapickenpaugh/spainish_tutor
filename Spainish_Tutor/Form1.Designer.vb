<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Spainish word and then click the color button:"
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(389, 59)
        Me.txtGreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(148, 26)
        Me.txtGreen.TabIndex = 1
        Me.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(200, 59)
        Me.txtBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(148, 26)
        Me.txtBlue.TabIndex = 2
        Me.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(13, 59)
        Me.txtRed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(148, 26)
        Me.txtRed.TabIndex = 3
        Me.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Red
        Me.btnRed.Location = New System.Drawing.Point(13, 95)
        Me.btnRed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(148, 35)
        Me.btnRed.TabIndex = 4
        Me.btnRed.Text = "&Red"
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.Color.Blue
        Me.btnBlue.Location = New System.Drawing.Point(200, 95)
        Me.btnBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(148, 35)
        Me.btnBlue.TabIndex = 5
        Me.btnBlue.Text = "&Blue"
        Me.btnBlue.UseVisualStyleBackColor = False
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.Lime
        Me.btnGreen.Location = New System.Drawing.Point(389, 95)
        Me.btnGreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(148, 35)
        Me.btnGreen.TabIndex = 6
        Me.btnGreen.Text = "&Green"
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(596, 96)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(596, 38)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(148, 35)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 168)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGreen As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtRed As TextBox
    Friend WithEvents btnRed As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
