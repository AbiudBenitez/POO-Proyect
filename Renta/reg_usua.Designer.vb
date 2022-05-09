<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reg_usua
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reg_usua))
        Me.RentaDate = New Renta.RentaDate()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New Renta.RentaDateTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New Renta.RentaDateTableAdapters.TableAdapterManager()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Conid_usuaTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nomid_usuaTextBox = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.id = New System.Windows.Forms.Label()
        Me.Id_usuaTextBox = New System.Windows.Forms.TextBox()
        CType(Me.RentaDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RentaDate
        '
        Me.RentaDate.DataSetName = "RentaDate"
        Me.RentaDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.RentaDate
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Articulos_dañadosTableAdapter = Nothing
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CobrosTableAdapter = Nothing
        Me.TableAdapterManager.Corte_de_cajaTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_de_rentaTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RentasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Renta.RentaDateTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'btnregistrar
        '
        Me.btnregistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregistrar.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistrar.Location = New System.Drawing.Point(94, 222)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(167, 36)
        Me.btnregistrar.TabIndex = 16
        Me.btnregistrar.Text = "Registrar"
        Me.btnregistrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 24)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(54, 200)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(252, 10)
        Me.BunifuSeparator2.TabIndex = 23
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(54, 138)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(252, 10)
        Me.BunifuSeparator1.TabIndex = 22
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(139, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Contraseña"
        '
        'Conid_usuaTextBox
        '
        Me.Conid_usuaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Conid_usuaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Conid_usuaTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conid_usuaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Conid_usuaTextBox.Location = New System.Drawing.Point(76, 181)
        Me.Conid_usuaTextBox.Name = "Conid_usuaTextBox"
        Me.Conid_usuaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Conid_usuaTextBox.Size = New System.Drawing.Size(209, 20)
        Me.Conid_usuaTextBox.TabIndex = 20
        Me.Conid_usuaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(151, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Usuario"
        '
        'Nomid_usuaTextBox
        '
        Me.Nomid_usuaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Nomid_usuaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nomid_usuaTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nomid_usuaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Nomid_usuaTextBox.Location = New System.Drawing.Point(76, 118)
        Me.Nomid_usuaTextBox.Name = "Nomid_usuaTextBox"
        Me.Nomid_usuaTextBox.Size = New System.Drawing.Size(209, 20)
        Me.Nomid_usuaTextBox.TabIndex = 18
        Me.Nomid_usuaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(54, 74)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(252, 10)
        Me.BunifuSeparator3.TabIndex = 26
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.id.Location = New System.Drawing.Point(166, 34)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(21, 19)
        Me.id.TabIndex = 25
        Me.id.Text = "Id"
        '
        'Id_usuaTextBox
        '
        Me.Id_usuaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Id_usuaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_usuaTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_usuaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Id_usuaTextBox.Location = New System.Drawing.Point(76, 55)
        Me.Id_usuaTextBox.Name = "Id_usuaTextBox"
        Me.Id_usuaTextBox.Size = New System.Drawing.Size(209, 20)
        Me.Id_usuaTextBox.TabIndex = 24
        Me.Id_usuaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'reg_usua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(362, 361)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Id_usuaTextBox)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Conid_usuaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nomid_usuaTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnregistrar)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "reg_usua"
        Me.Text = "Registro"
        CType(Me.RentaDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RentaDate As RentaDate
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As RentaDateTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As RentaDateTableAdapters.TableAdapterManager
    Friend WithEvents btnregistrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label2 As Label
    Friend WithEvents Conid_usuaTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Nomid_usuaTextBox As TextBox
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents id As Label
    Friend WithEvents Id_usuaTextBox As TextBox
End Class
