<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.picCow = New System.Windows.Forms.PictureBox()
        Me.picEl = New System.Windows.Forms.PictureBox()
        Me.picLion = New System.Windows.Forms.PictureBox()
        Me.picMonkey = New System.Windows.Forms.PictureBox()
        Me.picTiger = New System.Windows.Forms.PictureBox()
        Me.picWolf = New System.Windows.Forms.PictureBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        CType(Me.picCow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMonkey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTiger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWolf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCow
        '
        Me.picCow.BackgroundImage = Global.EnglishTeacher.My.Resources.Resources.cow_in_pasture_jpg_838x0_q80
        Me.picCow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCow.Location = New System.Drawing.Point(45, 30)
        Me.picCow.Name = "picCow"
        Me.picCow.Size = New System.Drawing.Size(106, 67)
        Me.picCow.TabIndex = 0
        Me.picCow.TabStop = False
        '
        'picEl
        '
        Me.picEl.BackgroundImage = Global.EnglishTeacher.My.Resources.Resources.elephant
        Me.picEl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picEl.Location = New System.Drawing.Point(180, 30)
        Me.picEl.Name = "picEl"
        Me.picEl.Size = New System.Drawing.Size(106, 67)
        Me.picEl.TabIndex = 1
        Me.picEl.TabStop = False
        '
        'picLion
        '
        Me.picLion.BackgroundImage = Global.EnglishTeacher.My.Resources.Resources.lion
        Me.picLion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLion.Location = New System.Drawing.Point(314, 30)
        Me.picLion.Name = "picLion"
        Me.picLion.Size = New System.Drawing.Size(106, 67)
        Me.picLion.TabIndex = 2
        Me.picLion.TabStop = False
        '
        'picMonkey
        '
        Me.picMonkey.BackgroundImage = Global.EnglishTeacher.My.Resources.Resources.monkey_4
        Me.picMonkey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMonkey.Location = New System.Drawing.Point(45, 126)
        Me.picMonkey.Name = "picMonkey"
        Me.picMonkey.Size = New System.Drawing.Size(106, 67)
        Me.picMonkey.TabIndex = 3
        Me.picMonkey.TabStop = False
        '
        'picTiger
        '
        Me.picTiger.BackgroundImage = Global.EnglishTeacher.My.Resources.Resources.tiger
        Me.picTiger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picTiger.Location = New System.Drawing.Point(180, 126)
        Me.picTiger.Name = "picTiger"
        Me.picTiger.Size = New System.Drawing.Size(106, 67)
        Me.picTiger.TabIndex = 4
        Me.picTiger.TabStop = False
        '
        'picWolf
        '
        Me.picWolf.BackgroundImage = Global.EnglishTeacher.My.Resources.Resources.wolf
        Me.picWolf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picWolf.Location = New System.Drawing.Point(314, 126)
        Me.picWolf.Name = "picWolf"
        Me.picWolf.Size = New System.Drawing.Size(106, 67)
        Me.picWolf.TabIndex = 5
        Me.picWolf.TabStop = False
        '
        'txtWord
        '
        Me.txtWord.Enabled = False
        Me.txtWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtWord.Location = New System.Drawing.Point(166, 220)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(132, 40)
        Me.txtWord.TabIndex = 6
        Me.txtWord.Text = "-1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 290)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.picWolf)
        Me.Controls.Add(Me.picTiger)
        Me.Controls.Add(Me.picMonkey)
        Me.Controls.Add(Me.picLion)
        Me.Controls.Add(Me.picEl)
        Me.Controls.Add(Me.picCow)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.picCow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMonkey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTiger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWolf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCow As PictureBox
    Friend WithEvents picEl As PictureBox
    Friend WithEvents picLion As PictureBox
    Friend WithEvents picMonkey As PictureBox
    Friend WithEvents picTiger As PictureBox
    Friend WithEvents picWolf As PictureBox
    Friend WithEvents txtWord As TextBox
End Class
