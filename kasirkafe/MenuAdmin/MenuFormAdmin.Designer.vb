<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuFormAdmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnManage = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.txtNamaKasir = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnSettings)
        Me.Panel1.Controls.Add(Me.btnManage)
        Me.Panel1.Controls.Add(Me.btnHistory)
        Me.Panel1.Controls.Add(Me.btnOrder)
        Me.Panel1.Controls.Add(Me.txtNamaKasir)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1700, 292)
        Me.Panel1.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1463, 70)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(147, 67)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "LogOut"
        Me.Button5.UseMnemonic = False
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(1153, 70)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(147, 67)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.Text = "Notes"
        Me.btnSettings.UseMnemonic = False
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnManage
        '
        Me.btnManage.FlatAppearance.BorderSize = 0
        Me.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManage.Location = New System.Drawing.Point(1021, 70)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(141, 67)
        Me.btnManage.TabIndex = 4
        Me.btnManage.Text = "History"
        Me.btnManage.UseMnemonic = False
        Me.btnManage.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Location = New System.Drawing.Point(879, 70)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(136, 67)
        Me.btnHistory.TabIndex = 3
        Me.btnHistory.Text = "Manage"
        Me.btnHistory.UseMnemonic = False
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.FlatAppearance.BorderSize = 0
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(658, 70)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(215, 67)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "Administration"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'txtNamaKasir
        '
        Me.txtNamaKasir.AutoSize = True
        Me.txtNamaKasir.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaKasir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtNamaKasir.Location = New System.Drawing.Point(285, 134)
        Me.txtNamaKasir.Name = "txtNamaKasir"
        Me.txtNamaKasir.Size = New System.Drawing.Size(178, 39)
        Me.txtNamaKasir.TabIndex = 1
        Me.txtNamaKasir.Text = "Nama Admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.kasirkafe.My.Resources.Resources.Group_2__7___1_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(643, 319)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 292)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1700, 507)
        Me.Panel2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1306, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 67)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Settings"
        Me.Button1.UseMnemonic = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuFormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1700, 799)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuFormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuFormAdmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnManage As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents txtNamaKasir As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class
