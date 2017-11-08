<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txt_word_en = New System.Windows.Forms.TextBox()
        Me.txt_word_bg = New System.Windows.Forms.TextBox()
        Me.btn_subbmit = New System.Windows.Forms.Button()
        Me.lbl_score = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_word_en
        '
        Me.txt_word_en.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_word_en.Location = New System.Drawing.Point(100, 102)
        Me.txt_word_en.Name = "txt_word_en"
        Me.txt_word_en.Size = New System.Drawing.Size(180, 40)
        Me.txt_word_en.TabIndex = 1
        '
        'txt_word_bg
        '
        Me.txt_word_bg.Enabled = False
        Me.txt_word_bg.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_word_bg.Location = New System.Drawing.Point(100, 41)
        Me.txt_word_bg.Name = "txt_word_bg"
        Me.txt_word_bg.Size = New System.Drawing.Size(180, 40)
        Me.txt_word_bg.TabIndex = 2
        '
        'btn_subbmit
        '
        Me.btn_subbmit.Location = New System.Drawing.Point(149, 148)
        Me.btn_subbmit.Name = "btn_subbmit"
        Me.btn_subbmit.Size = New System.Drawing.Size(75, 23)
        Me.btn_subbmit.TabIndex = 3
        Me.btn_subbmit.Text = "Subbmit"
        Me.btn_subbmit.UseVisualStyleBackColor = True
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Location = New System.Drawing.Point(332, 22)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(13, 13)
        Me.lbl_score.TabIndex = 5
        Me.lbl_score.Text = "0"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(322, 9)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(38, 13)
        Me.lbl.TabIndex = 6
        Me.lbl.Text = "Score:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(388, 204)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lbl_score)
        Me.Controls.Add(Me.btn_subbmit)
        Me.Controls.Add(Me.txt_word_bg)
        Me.Controls.Add(Me.txt_word_en)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_word_en As TextBox
    Friend WithEvents txt_word_bg As TextBox
    Friend WithEvents btn_subbmit As Button
    Friend WithEvents lbl_score As Label
    Friend WithEvents lbl As Label
End Class
