<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.txtnomid_usu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtconid_usu = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnregistro = New System.Windows.Forms.Button()
        Me.RentaDate = New Renta.RentaDate()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New Renta.RentaDateTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New Renta.RentaDateTableAdapters.TableAdapterManager()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        CType(Me.RentaDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnomid_usu
        '
        Me.txtnomid_usu.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtnomid_usu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnomid_usu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomid_usu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtnomid_usu.Location = New System.Drawing.Point(114, 34)
        Me.txtnomid_usu.Name = "txtnomid_usu"
        Me.txtnomid_usu.Size = New System.Drawing.Size(209, 20)
        Me.txtnomid_usu.TabIndex = 0
        Me.txtnomid_usu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(189, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(177, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'txtconid_usu
        '
        Me.txtconid_usu.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtconid_usu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtconid_usu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconid_usu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtconid_usu.Location = New System.Drawing.Point(114, 97)
        Me.txtconid_usu.Name = "txtconid_usu"
        Me.txtconid_usu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconid_usu.Size = New System.Drawing.Size(209, 20)
        Me.txtconid_usu.TabIndex = 2
        Me.txtconid_usu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnlogin.Location = New System.Drawing.Point(42, 148)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(136, 36)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Iniciar Sesion"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btnregistro
        '
        Me.btnregistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnregistro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregistro.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnregistro.Location = New System.Drawing.Point(244, 148)
        Me.btnregistro.Name = "btnregistro"
        Me.btnregistro.Size = New System.Drawing.Size(136, 36)
        Me.btnregistro.TabIndex = 5
        Me.btnregistro.Text = "Registrarse"
        Me.btnregistro.UseVisualStyleBackColor = False
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
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(92, 54)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(252, 10)
        Me.BunifuSeparator1.TabIndex = 6
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(92, 116)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(252, 10)
        Me.BunifuSeparator2.TabIndex = 7
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(425, 230)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.btnregistro)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtconid_usu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnomid_usu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        CType(Me.RentaDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnomid_usu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtconid_usu As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents RentaDate As RentaDate
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As RentaDateTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As RentaDateTableAdapters.TableAdapterManager
    Friend WithEvents btnregistro As Button
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
End Class
