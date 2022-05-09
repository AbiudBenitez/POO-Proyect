Public Class reg_usua
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RentaDate)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RentaDate)

    End Sub

    Private Sub reg_usua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RentaDate.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.RentaDate.Usuarios)

    End Sub

    Private Sub UsuariosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles UsuariosBindingSource.CurrentChanged

    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        Try
            Me.UsuariosTableAdapter.insert_usu(Id_usuaTextBox.Text, Nomid_usuaTextBox.Text, Conid_usuaTextBox.Text)
            MsgBox("Usuario registrado con exito", MsgBoxStyle.Information)
            login.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("No se ha podido registrar, favor de intentar mas tarde" + ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()
    End Sub
End Class