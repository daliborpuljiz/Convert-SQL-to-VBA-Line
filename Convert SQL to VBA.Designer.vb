<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvertSQLToVBA
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
  Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvertSQLToVBA))
  Me.tbxSQL = New System.Windows.Forms.TextBox()
  Me.cbtConvert = New System.Windows.Forms.Button()
  Me.SuspendLayout()
  '
  'tbxSQL
  '
  Me.tbxSQL.AllowDrop = True
  Me.tbxSQL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
  Me.tbxSQL.BorderStyle = System.Windows.Forms.BorderStyle.None
  Me.tbxSQL.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
  Me.tbxSQL.Location = New System.Drawing.Point(12, 34)
  Me.tbxSQL.Multiline = True
  Me.tbxSQL.Name = "tbxSQL"
  Me.tbxSQL.Size = New System.Drawing.Size(669, 696)
  Me.tbxSQL.TabIndex = 0
  '
  'cbtConvert
  '
  Me.cbtConvert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
  Me.cbtConvert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
  Me.cbtConvert.Location = New System.Drawing.Point(12, 5)
  Me.cbtConvert.Name = "cbtConvert"
  Me.cbtConvert.Size = New System.Drawing.Size(669, 23)
  Me.cbtConvert.TabIndex = 1
  Me.cbtConvert.Text = "Convert SQL to VBA"
  Me.cbtConvert.UseVisualStyleBackColor = True
  '
  'frmConvertSQLToVBA
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(693, 742)
  Me.Controls.Add(Me.cbtConvert)
  Me.Controls.Add(Me.tbxSQL)
  Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
  Me.Name = "frmConvertSQLToVBA"
  Me.Text = "Convert SQL to VBA"
  Me.ResumeLayout(False)
  Me.PerformLayout()

 End Sub
 Friend WithEvents tbxSQL As System.Windows.Forms.TextBox
    Friend WithEvents cbtConvert As System.Windows.Forms.Button

End Class
