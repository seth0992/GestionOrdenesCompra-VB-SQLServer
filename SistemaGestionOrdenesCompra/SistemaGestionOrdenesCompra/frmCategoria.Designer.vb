<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnModificar = New Button()
        btnEliminar = New Button()
        btnLimpiar = New Button()
        btnRegistrar = New Button()
        txtDescripcionCat = New TextBox()
        txtNombreCat = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        dgvDatos = New DataGridView()
        GroupBox2 = New GroupBox()
        txtBuscar = New TextBox()
        btnBuscar = New Button()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(203, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 25)
        Label1.TabIndex = 0
        Label1.Text = "Control de Proveedores"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnModificar)
        GroupBox1.Controls.Add(btnEliminar)
        GroupBox1.Controls.Add(btnLimpiar)
        GroupBox1.Controls.Add(btnRegistrar)
        GroupBox1.Controls.Add(txtDescripcionCat)
        GroupBox1.Controls.Add(txtNombreCat)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 61)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(594, 145)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos del Proveedor"
        ' 
        ' btnModificar
        ' 
        btnModificar.Enabled = False
        btnModificar.Location = New Point(163, 85)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(125, 42)
        btnModificar.TabIndex = 4
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Enabled = False
        btnEliminar.Location = New Point(307, 85)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(125, 42)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(451, 85)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(125, 42)
        btnLimpiar.TabIndex = 4
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(19, 85)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(125, 42)
        btnRegistrar.TabIndex = 4
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' txtDescripcionCat
        ' 
        txtDescripcionCat.Location = New Point(307, 51)
        txtDescripcionCat.Name = "txtDescripcionCat"
        txtDescripcionCat.Size = New Size(269, 23)
        txtDescripcionCat.TabIndex = 2
        ' 
        ' txtNombreCat
        ' 
        txtNombreCat.Location = New Point(17, 51)
        txtNombreCat.Name = "txtNombreCat"
        txtNombreCat.Size = New Size(269, 23)
        txtNombreCat.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(307, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 15)
        Label3.TabIndex = 0
        Label3.Text = "Descripción de la Categoría"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 15)
        Label2.TabIndex = 0
        Label2.Text = "Nombre de la Categoría"
        ' 
        ' dgvDatos
        ' 
        dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDatos.Location = New Point(6, 66)
        dgvDatos.Name = "dgvDatos"
        dgvDatos.Size = New Size(595, 166)
        dgvDatos.TabIndex = 2
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtBuscar)
        GroupBox2.Controls.Add(btnBuscar)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(dgvDatos)
        GroupBox2.Location = New Point(12, 212)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(601, 238)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Lista de Categorías"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(125, 32)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(361, 23)
        txtBuscar.TabIndex = 5
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(492, 24)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(103, 36)
        btnBuscar.TabIndex = 4
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 15)
        Label4.TabIndex = 3
        Label4.Text = "Buscar por Nombre:"
        ' 
        ' frmCategoria
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(625, 456)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Name = "frmCategoria"
        Text = "frmProveedor"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescripcionCat As TextBox
    Friend WithEvents txtNombreCat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label4 As Label
End Class
