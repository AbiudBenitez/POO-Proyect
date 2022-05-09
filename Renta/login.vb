Public Class login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            If ValidarUsua(txtnomid_usu.Text) = True Then
                Dim contra As String = ValidarCont(txtnomid_usu.Text)
                If contra.Equals(txtconid_usu.Text) = True Then
                    Me.Hide()
                    Clientes.Show()
                Else
                    MsgBox("No funciono")
                End If
            Else
                MsgBox("El usuario no existe")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RentaDate)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RentaDate.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.RentaDate.Usuarios)
        Abrir()
    End Sub

    Private Sub btnregistro_Click(sender As Object, e As EventArgs) Handles btnregistro.Click
        reg_usua.Show()
        Me.Hide()
    End Sub

    Private Sub txtnomid_usu_TextChanged(sender As Object, e As EventArgs) Handles txtnomid_usu.TextChanged

    End Sub
End Class
