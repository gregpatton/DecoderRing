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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpMethod = New System.Windows.Forms.GroupBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdDecode = New System.Windows.Forms.Button()
        Me.cmdEncode = New System.Windows.Forms.Button()
        Me.cmbMethod = New System.Windows.Forms.ComboBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.cmdSendToInput = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.grpMethod.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.DarkGreen
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(728, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Decoder Ring"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpMethod
        '
        Me.grpMethod.Controls.Add(Me.cmdReset)
        Me.grpMethod.Controls.Add(Me.cmdDecode)
        Me.grpMethod.Controls.Add(Me.cmdEncode)
        Me.grpMethod.Controls.Add(Me.cmbMethod)
        Me.grpMethod.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMethod.Location = New System.Drawing.Point(12, 72)
        Me.grpMethod.Name = "grpMethod"
        Me.grpMethod.Size = New System.Drawing.Size(725, 67)
        Me.grpMethod.TabIndex = 1
        Me.grpMethod.TabStop = False
        Me.grpMethod.Text = "Method"
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(448, 29)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 4
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdDecode
        '
        Me.cmdDecode.Location = New System.Drawing.Point(367, 29)
        Me.cmdDecode.Name = "cmdDecode"
        Me.cmdDecode.Size = New System.Drawing.Size(75, 23)
        Me.cmdDecode.TabIndex = 3
        Me.cmdDecode.Text = "Decode"
        Me.cmdDecode.UseVisualStyleBackColor = True
        '
        'cmdEncode
        '
        Me.cmdEncode.Location = New System.Drawing.Point(286, 29)
        Me.cmdEncode.Name = "cmdEncode"
        Me.cmdEncode.Size = New System.Drawing.Size(75, 23)
        Me.cmdEncode.TabIndex = 2
        Me.cmdEncode.Text = "Encode"
        Me.cmdEncode.UseVisualStyleBackColor = True
        '
        'cmbMethod
        '
        Me.cmbMethod.FormattingEnabled = True
        Me.cmbMethod.Items.AddRange(New Object() {"Base64", "HTML", "HTML Attribute", "JavaScript String", "MD5", "SHA1", "SHA256", "SHA384", "SHA512", "URL", "URL Path", "Reverse", "Lowercase", "Uppercase", "Rot13", "ASCII"})
        Me.cmbMethod.Location = New System.Drawing.Point(6, 29)
        Me.cmbMethod.Name = "cmbMethod"
        Me.cmbMethod.Size = New System.Drawing.Size(274, 21)
        Me.cmbMethod.TabIndex = 1
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.cmdSendToInput)
        Me.grpOutput.Controls.Add(Me.txtOutput)
        Me.grpOutput.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOutput.Location = New System.Drawing.Point(12, 334)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(725, 187)
        Me.grpOutput.TabIndex = 3
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output"
        '
        'cmdSendToInput
        '
        Me.cmdSendToInput.Location = New System.Drawing.Point(6, 156)
        Me.cmdSendToInput.Name = "cmdSendToInput"
        Me.cmdSendToInput.Size = New System.Drawing.Size(95, 23)
        Me.cmdSendToInput.TabIndex = 7
        Me.cmdSendToInput.Text = "Send to Input"
        Me.cmdSendToInput.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(6, 20)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(710, 130)
        Me.txtOutput.TabIndex = 5
        Me.txtOutput.WordWrap = False
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.txtInput)
        Me.grpInput.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInput.Location = New System.Drawing.Point(12, 145)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(725, 187)
        Me.grpInput.TabIndex = 7
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input"
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.SystemColors.Window
        Me.txtInput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(6, 20)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInput.Size = New System.Drawing.Size(710, 161)
        Me.txtInput.TabIndex = 5
        Me.txtInput.WordWrap = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(754, 533)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpMethod)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Decoder Ring"
        Me.grpMethod.ResumeLayout(False)
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpMethod As System.Windows.Forms.GroupBox
    Friend WithEvents grpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents cmdDecode As System.Windows.Forms.Button
    Friend WithEvents cmdEncode As System.Windows.Forms.Button
    Friend WithEvents cmbMethod As System.Windows.Forms.ComboBox
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents cmdSendToInput As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button

End Class
