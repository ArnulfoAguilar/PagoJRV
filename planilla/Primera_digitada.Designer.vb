<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Primera_digitada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Primera_digitada))
        Me.LBLTITULO = New System.Windows.Forms.Label()
        Me.txtdui = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.txtnombre1 = New System.Windows.Forms.TextBox()
        Me.txtape1 = New System.Windows.Forms.TextBox()
        Me.txtjrv = New System.Windows.Forms.TextBox()
        Me.cmbcargo = New System.Windows.Forms.ComboBox()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.cbProcedencia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_aceptar_jrv = New System.Windows.Forms.Button()
        Me.cb_inconsistencias = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBLTITULO
        '
        Me.LBLTITULO.AutoSize = True
        Me.LBLTITULO.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTITULO.ForeColor = System.Drawing.Color.Navy
        Me.LBLTITULO.Location = New System.Drawing.Point(315, 9)
        Me.LBLTITULO.Name = "LBLTITULO"
        Me.LBLTITULO.Size = New System.Drawing.Size(594, 63)
        Me.LBLTITULO.TabIndex = 2
        Me.LBLTITULO.Text = "SISTEMA PAGOS JRV" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ELECCIONES 2018" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DIPUTACIONES A ASAMBLEA LEGISLATIVA Y CONSEJO" & _
            "S MUNICIPALES"
        Me.LBLTITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtdui
        '
        Me.txtdui.Location = New System.Drawing.Point(60, 107)
        Me.txtdui.MaxLength = 10
        Me.txtdui.Name = "txtdui"
        Me.txtdui.Size = New System.Drawing.Size(221, 20)
        Me.txtdui.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(118, 533)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Datos Correctos:"
        '
        'btnSi
        '
        Me.btnSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.ForeColor = System.Drawing.Color.Green
        Me.btnSi.Location = New System.Drawing.Point(349, 533)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(58, 33)
        Me.btnSi.TabIndex = 20
        Me.btnSi.Text = "Si"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(479, 533)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 33)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "No"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(386, 586)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 35)
        Me.btnCancelar.TabIndex = 22
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(298, 98)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(96, 38)
        Me.btnbuscar.TabIndex = 24
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 254)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(727, 239)
        Me.dgvData.TabIndex = 26
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(12, 109)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(42, 18)
        Me.Lbl1.TabIndex = 27
        Me.Lbl1.Text = "DUI:"
        '
        'txtnombre1
        '
        Me.txtnombre1.Location = New System.Drawing.Point(12, 152)
        Me.txtnombre1.Name = "txtnombre1"
        Me.txtnombre1.Size = New System.Drawing.Size(206, 20)
        Me.txtnombre1.TabIndex = 31
        '
        'txtape1
        '
        Me.txtape1.Location = New System.Drawing.Point(224, 152)
        Me.txtape1.Name = "txtape1"
        Me.txtape1.Size = New System.Drawing.Size(204, 20)
        Me.txtape1.TabIndex = 33
        '
        'txtjrv
        '
        Me.txtjrv.Location = New System.Drawing.Point(567, 108)
        Me.txtjrv.Name = "txtjrv"
        Me.txtjrv.Size = New System.Drawing.Size(51, 20)
        Me.txtjrv.TabIndex = 37
        '
        'cmbcargo
        '
        Me.cmbcargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcargo.FormattingEnabled = True
        Me.cmbcargo.Items.AddRange(New Object() {"Presidente", "Secretario", "Vocal1", "Vocal2", "Vocal3", "Vigilante"})
        Me.cmbcargo.Location = New System.Drawing.Point(434, 152)
        Me.cmbcargo.Name = "cmbcargo"
        Me.cmbcargo.Size = New System.Drawing.Size(121, 21)
        Me.cmbcargo.TabIndex = 38
        '
        'LOGO
        '
        Me.LOGO.Location = New System.Drawing.Point(20, 16)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(478, 301)
        Me.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LOGO.TabIndex = 4
        Me.LOGO.TabStop = False
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(588, 216)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 42
        Me.btningresar.Text = "INGRESAR"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'cbProcedencia
        '
        Me.cbProcedencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProcedencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProcedencia.FormattingEnabled = True
        Me.cbProcedencia.Items.AddRange(New Object() {"ARENA", "FMLN", "GANA", "PCN", "PDC", "CD", "DS", "PSD", "PSP", "FPS"})
        Me.cbProcedencia.Location = New System.Drawing.Point(570, 152)
        Me.cbProcedencia.Name = "cbProcedencia"
        Me.cbProcedencia.Size = New System.Drawing.Size(129, 23)
        Me.cbProcedencia.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(434, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Cargo en JRV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(567, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Procedencia"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.LOGO)
        Me.Panel1.Location = New System.Drawing.Point(761, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 327)
        Me.Panel1.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(841, 516)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 57)
        Me.Button1.TabIndex = 51
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(1155, 518)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(68, 57)
        Me.Button6.TabIndex = 52
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(945, 524)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(188, 40)
        Me.Button7.TabIndex = 53
        Me.Button7.Text = "Cambiar Imagen Asamblea"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 21)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "JRV No."
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(945, 105)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(58, 60)
        Me.Button3.TabIndex = 56
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(1077, 106)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 62)
        Me.Button4.TabIndex = 57
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btn_aceptar_jrv
        '
        Me.btn_aceptar_jrv.Location = New System.Drawing.Point(624, 105)
        Me.btn_aceptar_jrv.Name = "btn_aceptar_jrv"
        Me.btn_aceptar_jrv.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar_jrv.TabIndex = 58
        Me.btn_aceptar_jrv.Text = "Aceptar"
        Me.btn_aceptar_jrv.UseVisualStyleBackColor = True
        '
        'cb_inconsistencias
        '
        Me.cb_inconsistencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_inconsistencias.FormattingEnabled = True
        Me.cb_inconsistencias.Location = New System.Drawing.Point(15, 219)
        Me.cb_inconsistencias.Name = "cb_inconsistencias"
        Me.cb_inconsistencias.Size = New System.Drawing.Size(156, 21)
        Me.cb_inconsistencias.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Tipo de inconsistencia"
        '
        'Primera_digitada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 646)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cb_inconsistencias)
        Me.Controls.Add(Me.btn_aceptar_jrv)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbProcedencia)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.cmbcargo)
        Me.Controls.Add(Me.txtjrv)
        Me.Controls.Add(Me.txtape1)
        Me.Controls.Add(Me.txtnombre1)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdui)
        Me.Controls.Add(Me.LBLTITULO)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Primera_digitada"
        Me.Text = "PRIMER DIGITADA                               "
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLTITULO As System.Windows.Forms.Label
    Friend WithEvents LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents txtdui As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSi As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtnombre1 As System.Windows.Forms.TextBox
    Friend WithEvents txtape1 As System.Windows.Forms.TextBox
    Friend WithEvents txtjrv As System.Windows.Forms.TextBox
    Friend WithEvents cmbcargo As System.Windows.Forms.ComboBox
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents cbProcedencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar_jrv As System.Windows.Forms.Button
    Friend WithEvents cb_inconsistencias As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
