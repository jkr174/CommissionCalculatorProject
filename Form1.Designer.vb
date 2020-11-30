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
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.btnRate8 = New System.Windows.Forms.Button()
        Me.btnRate10 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtCommission = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(12, 9)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(36, 13)
        Me.lblSales.TabIndex = 0
        Me.lblSales.Text = "&Sales:"
        '
        'lblCommission
        '
        Me.lblCommission.AutoSize = True
        Me.lblCommission.Location = New System.Drawing.Point(115, 9)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(65, 13)
        Me.lblCommission.TabIndex = 1
        Me.lblCommission.Text = "Commission:"
        '
        'btnRate8
        '
        Me.btnRate8.Location = New System.Drawing.Point(224, 12)
        Me.btnRate8.Name = "btnRate8"
        Me.btnRate8.Size = New System.Drawing.Size(75, 23)
        Me.btnRate8.TabIndex = 2
        Me.btnRate8.Text = "&8% rate"
        Me.btnRate8.UseVisualStyleBackColor = True
        '
        'btnRate10
        '
        Me.btnRate10.Location = New System.Drawing.Point(224, 41)
        Me.btnRate10.Name = "btnRate10"
        Me.btnRate10.Size = New System.Drawing.Size(75, 23)
        Me.btnRate10.TabIndex = 3
        Me.btnRate10.Text = "&10% rate"
        Me.btnRate10.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(224, 70)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(12, 25)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 5
        '
        'txtCommission
        '
        Me.txtCommission.Location = New System.Drawing.Point(118, 25)
        Me.txtCommission.Name = "txtCommission"
        Me.txtCommission.Size = New System.Drawing.Size(100, 20)
        Me.txtCommission.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 108)
        Me.Controls.Add(Me.txtCommission)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRate10)
        Me.Controls.Add(Me.btnRate8)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.lblSales)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSales As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents btnRate8 As Button
    Friend WithEvents btnRate10 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtCommission As TextBox
End Class
