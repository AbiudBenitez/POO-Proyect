<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_cliLabel As System.Windows.Forms.Label
        Dim Nom_cliLabel As System.Windows.Forms.Label
        Dim Cd_cliLabel As System.Windows.Forms.Label
        Dim Cll_cliLabel As System.Windows.Forms.Label
        Dim Num_cliLabel As System.Windows.Forms.Label
        Dim Cp_cliLabel As System.Windows.Forms.Label
        Dim Tel_cliLabel As System.Windows.Forms.Label
        Me.RentaDate = New Renta.RentaDate()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Renta.RentaDateTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Renta.RentaDateTableAdapters.TableAdapterManager()
        Me.Id_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Cd_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Cll_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Num_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Cp_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_cliLabel = New System.Windows.Forms.Label()
        Nom_cliLabel = New System.Windows.Forms.Label()
        Cd_cliLabel = New System.Windows.Forms.Label()
        Cll_cliLabel = New System.Windows.Forms.Label()
        Num_cliLabel = New System.Windows.Forms.Label()
        Cp_cliLabel = New System.Windows.Forms.Label()
        Tel_cliLabel = New System.Windows.Forms.Label()
        CType(Me.RentaDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RentaDate
        '
        Me.RentaDate.DataSetName = "RentaDate"
        Me.RentaDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.RentaDate
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Articulos_dañadosTableAdapter = Nothing
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.CobrosTableAdapter = Nothing
        Me.TableAdapterManager.Corte_de_cajaTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_de_rentaTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RentasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Renta.RentaDateTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Id_cliLabel
        '
        Id_cliLabel.AutoSize = True
        Id_cliLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_cliLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Id_cliLabel.Location = New System.Drawing.Point(100, 20)
        Id_cliLabel.Name = "Id_cliLabel"
        Id_cliLabel.Size = New System.Drawing.Size(21, 19)
        Id_cliLabel.TabIndex = 1
        Id_cliLabel.Text = "Id"
        '
        'Id_cliTextBox
        '
        Me.Id_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "id_cli", True))
        Me.Id_cliTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_cliTextBox.Location = New System.Drawing.Point(127, 17)
        Me.Id_cliTextBox.Name = "Id_cliTextBox"
        Me.Id_cliTextBox.Size = New System.Drawing.Size(244, 27)
        Me.Id_cliTextBox.TabIndex = 2
        '
        'Nom_cliLabel
        '
        Nom_cliLabel.AutoSize = True
        Nom_cliLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_cliLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Nom_cliLabel.Location = New System.Drawing.Point(61, 55)
        Nom_cliLabel.Name = "Nom_cliLabel"
        Nom_cliLabel.Size = New System.Drawing.Size(60, 19)
        Nom_cliLabel.TabIndex = 3
        Nom_cliLabel.Text = "Nombre"
        '
        'Nom_cliTextBox
        '
        Me.Nom_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nom_cli", True))
        Me.Nom_cliTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_cliTextBox.Location = New System.Drawing.Point(127, 52)
        Me.Nom_cliTextBox.Name = "Nom_cliTextBox"
        Me.Nom_cliTextBox.Size = New System.Drawing.Size(244, 27)
        Me.Nom_cliTextBox.TabIndex = 4
        '
        'Cd_cliLabel
        '
        Cd_cliLabel.AutoSize = True
        Cd_cliLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_cliLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Cd_cliLabel.Location = New System.Drawing.Point(67, 90)
        Cd_cliLabel.Name = "Cd_cliLabel"
        Cd_cliLabel.Size = New System.Drawing.Size(54, 19)
        Cd_cliLabel.TabIndex = 5
        Cd_cliLabel.Text = "Ciudad"
        '
        'Cd_cliTextBox
        '
        Me.Cd_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cd_cli", True))
        Me.Cd_cliTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_cliTextBox.Location = New System.Drawing.Point(127, 87)
        Me.Cd_cliTextBox.Name = "Cd_cliTextBox"
        Me.Cd_cliTextBox.Size = New System.Drawing.Size(244, 27)
        Me.Cd_cliTextBox.TabIndex = 6
        '
        'Cll_cliLabel
        '
        Cll_cliLabel.AutoSize = True
        Cll_cliLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cll_cliLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Cll_cliLabel.Location = New System.Drawing.Point(79, 125)
        Cll_cliLabel.Name = "Cll_cliLabel"
        Cll_cliLabel.Size = New System.Drawing.Size(42, 19)
        Cll_cliLabel.TabIndex = 7
        Cll_cliLabel.Text = "Calle"
        '
        'Cll_cliTextBox
        '
        Me.Cll_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cll_cli", True))
        Me.Cll_cliTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cll_cliTextBox.Location = New System.Drawing.Point(127, 122)
        Me.Cll_cliTextBox.Name = "Cll_cliTextBox"
        Me.Cll_cliTextBox.Size = New System.Drawing.Size(244, 27)
        Me.Cll_cliTextBox.TabIndex = 8
        '
        'Num_cliLabel
        '
        Num_cliLabel.AutoSize = True
        Num_cliLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_cliLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Num_cliLabel.Location = New System.Drawing.Point(61, 160)
        Num_cliLabel.Name = "Num_cliLabel"
        Num_cliLabel.Size = New System.Drawing.Size(60, 19)
        Num_cliLabel.TabIndex = 9
        Num_cliLabel.Text = "Numero"
        '
        'Num_cliTextBox
        '
        Me.Num_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "num_cli", True))
        Me.Num_cliTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_cliTextBox.Location = New System.Drawing.Point(127, 157)
        Me.Num_cliTextBox.Name = "Num_cliTextBox"
        Me.Num_cliTextBox.Size = New System.Drawing.Size(244, 27)
        Me.Num_cliTextBox.TabIndex = 10
        '
        'Cp_cliLabel
        '
        Cp_cliLabel.AutoSize = True
        Cp_cliLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cp_cliLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Cp_cliLabel.Location = New System.Drawing.Point(23, 195)
        Cp_cliLabel.Name = "Cp_cliLabel"
        Cp_cliLabel.Size = New System.Drawing.Size(98, 19)
        Cp_cliLabel.TabIndex = 11
        Cp_cliLabel.Text = "Codigo Postal"
        '
        'Cp_cliTextBox
        '
        Me.Cp_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cp_cli", True))
        Me.Cp_cliTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cp_cliTextBox.Location = New System.Drawing.Point(127, 192)
        Me.Cp_cliTextBox.Name = "Cp_cliTextBox"
        Me.Cp_cliTextBox.Size = New System.Drawing.Size(244, 27)
        Me.Cp_cliTextBox.TabIndex = 12
        '
        'Tel_cliLabel
        '
        Tel_cliLabel.AutoSize = True
        Tel_cliLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tel_cliLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Tel_cliLabel.Location = New System.Drawing.Point(56, 230)
        Tel_cliLabel.Name = "Tel_cliLabel"
        Tel_cliLabel.Size = New System.Drawing.Size(65, 19)
        Tel_cliLabel.TabIndex = 13
        Tel_cliLabel.Text = "Telefono"
        '
        'Tel_cliTextBox
        '
        Me.Tel_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "tel_cli", True))
        Me.Tel_cliTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tel_cliTextBox.Location = New System.Drawing.Point(127, 227)
        Me.Tel_cliTextBox.Name = "Tel_cliTextBox"
        Me.Tel_cliTextBox.Size = New System.Drawing.Size(244, 27)
        Me.Tel_cliTextBox.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(83, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 37)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Anterior"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(224, 282)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 37)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Siguiente"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(83, 325)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 37)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Nuevo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(224, 325)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 37)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(83, 368)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 37)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Actualizar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(224, 368)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 37)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Borrar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(387, 17)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(924, 408)
        Me.ClientesDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_cli"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_cli"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom_cli"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nom_cli"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cd_cli"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cd_cli"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cll_cli"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cll_cli"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "num_cli"
        Me.DataGridViewTextBoxColumn5.HeaderText = "num_cli"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cp_cli"
        Me.DataGridViewTextBoxColumn6.HeaderText = "cp_cli"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tel_cli"
        Me.DataGridViewTextBoxColumn7.HeaderText = "tel_cli"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1323, 437)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Id_cliLabel)
        Me.Controls.Add(Me.Id_cliTextBox)
        Me.Controls.Add(Nom_cliLabel)
        Me.Controls.Add(Me.Nom_cliTextBox)
        Me.Controls.Add(Cd_cliLabel)
        Me.Controls.Add(Me.Cd_cliTextBox)
        Me.Controls.Add(Cll_cliLabel)
        Me.Controls.Add(Me.Cll_cliTextBox)
        Me.Controls.Add(Num_cliLabel)
        Me.Controls.Add(Me.Num_cliTextBox)
        Me.Controls.Add(Cp_cliLabel)
        Me.Controls.Add(Me.Cp_cliTextBox)
        Me.Controls.Add(Tel_cliLabel)
        Me.Controls.Add(Me.Tel_cliTextBox)
        Me.Name = "Clientes"
        Me.Text = "Agregar Clientes"
        CType(Me.RentaDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RentaDate As RentaDate
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As RentaDateTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As RentaDateTableAdapters.TableAdapterManager
    Friend WithEvents Id_cliTextBox As TextBox
    Friend WithEvents Nom_cliTextBox As TextBox
    Friend WithEvents Cd_cliTextBox As TextBox
    Friend WithEvents Cll_cliTextBox As TextBox
    Friend WithEvents Num_cliTextBox As TextBox
    Friend WithEvents Cp_cliTextBox As TextBox
    Friend WithEvents Tel_cliTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
