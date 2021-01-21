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
        Me.components = New System.ComponentModel.Container()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnOption3 = New System.Windows.Forms.Button()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.btnOption2 = New System.Windows.Forms.Button()
        Me.btnOption1 = New System.Windows.Forms.Button()
        Me.lblStory = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.picIndoraptor = New System.Windows.Forms.PictureBox()
        Me.picImage = New System.Windows.Forms.PictureBox()
        CType(Me.picIndoraptor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Navy
        Me.lblTimer.Location = New System.Drawing.Point(304, 360)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(57, 20)
        Me.lblTimer.TabIndex = 32
        Me.lblTimer.Text = "Label1"
        '
        'btnOption3
        '
        Me.btnOption3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption3.Location = New System.Drawing.Point(11, 264)
        Me.btnOption3.Name = "btnOption3"
        Me.btnOption3.Size = New System.Drawing.Size(553, 44)
        Me.btnOption3.TabIndex = 31
        Me.btnOption3.Text = "Option3"
        Me.btnOption3.UseVisualStyleBackColor = True
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(11, 360)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(57, 20)
        Me.lblMoney.TabIndex = 30
        Me.lblMoney.Text = "Label2"
        '
        'btnOption2
        '
        Me.btnOption2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption2.Location = New System.Drawing.Point(307, 214)
        Me.btnOption2.Name = "btnOption2"
        Me.btnOption2.Size = New System.Drawing.Size(257, 44)
        Me.btnOption2.TabIndex = 29
        Me.btnOption2.Text = "Option2"
        Me.btnOption2.UseVisualStyleBackColor = True
        '
        'btnOption1
        '
        Me.btnOption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption1.Location = New System.Drawing.Point(11, 214)
        Me.btnOption1.Name = "btnOption1"
        Me.btnOption1.Size = New System.Drawing.Size(257, 44)
        Me.btnOption1.TabIndex = 28
        Me.btnOption1.Text = "Option1"
        Me.btnOption1.UseVisualStyleBackColor = True
        '
        'lblStory
        '
        Me.lblStory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStory.Location = New System.Drawing.Point(12, 9)
        Me.lblStory.Name = "lblStory"
        Me.lblStory.Size = New System.Drawing.Size(257, 150)
        Me.lblStory.TabIndex = 26
        Me.lblStory.Text = "Label1"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'picIndoraptor
        '
        Me.picIndoraptor.Image = Global.cyoaAyden.My.Resources.Resources.indoraptor
        Me.picIndoraptor.Location = New System.Drawing.Point(307, 6)
        Me.picIndoraptor.Name = "picIndoraptor"
        Me.picIndoraptor.Size = New System.Drawing.Size(257, 150)
        Me.picIndoraptor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIndoraptor.TabIndex = 33
        Me.picIndoraptor.TabStop = False
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(307, 6)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(257, 150)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage.TabIndex = 27
        Me.picImage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 422)
        Me.Controls.Add(Me.picIndoraptor)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnOption3)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.btnOption2)
        Me.Controls.Add(Me.btnOption1)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.lblStory)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picIndoraptor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picIndoraptor As System.Windows.Forms.PictureBox
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents btnOption3 As System.Windows.Forms.Button
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents btnOption2 As System.Windows.Forms.Button
    Friend WithEvents btnOption1 As System.Windows.Forms.Button
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblStory As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
