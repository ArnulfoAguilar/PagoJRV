Imports System.Data.OracleClient
Imports System.Data
Imports planilla.Usuario

Public Class ingreso
    ' Dim cadena As String = "Data Source=172.16.100.41:1521/cnpre; User id=PAGOSJRV; password=Arkantos14" '"Data Source=localhost:1521/orcl; User id=PAGOSJRV; password=Arkantos14"
    'Dim cadena As String = "Data Source=192.168.4.101:1521/REGELEC.tse.gob.sv; User id=PAGOSJRV_2018; password=Arkantos14"
    Dim cadena As String = "Data Source=localhost:1521/orcl; User id=PAGOJRV; password=PAGOJRV"
    Dim con As New OracleConnection(cadena)

    Private Sub nusuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        con.Close()
        'usuarios.Show()
        Me.Close()
    End Sub
    Private Sub eventoConsultar()

        Try
            ' Dim sql As String = "select * from usuario where nom_usuario=:nombre and password=:password" ' Esta es la consulta a la base
            'Dim comando As New OracleCommand(sql, con) ' SE crea un nuevo comando de oracle y se le asigna la consulta a la base (sql) y la conexion(con)
            Dim sql As String = "select * from usuario where nombre=:NOMBRE and password=:password"
            Dim comando As New OracleCommand(sql, con) ' SE crea un nuevo comando de oracle y se le asigna la consulta a la base (sql) y la conexion(con)
            comando.Parameters.Add(":NOMBRE", txtusuario.Text.ToUpper)
            comando.Parameters.Add(":password", txtclave.Text.ToUpper)


            con.Open()
            Dim lector As OracleDataReader = Nothing

            lector = comando.ExecuteReader
            If lector.HasRows Then
                If lector.Read() Then
                    Dim a As Integer = Convert.ToInt32(lector(0).ToString)
                    Dim usu As String = lector(1).ToString()
                    codUsuario = a
                    nomUsuario = usu
                End If
                con.Close()

                MenuPrincipal.Show()
                Me.Close()
            Else
                MessageBox.Show("CONTRASEÑA O USUARIO INCORRECTO")
                txtusuario.Text = ""
                txtclave.Text = ""
                txtusuario.Focus()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString) ' Se imprime el error por si falla la conexion a la base
            con.Close()

        End Try

    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        eventoConsultar()
    End Sub

    Private Sub btnsalida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalida.Click
        Me.Close()
    End Sub

    Private Sub txtusuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusuario.KeyDown
        If e.KeyData = Keys.Enter Then
            txtclave.Focus()
        End If
    End Sub

    Private Sub txtclave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtclave.KeyDown
        If e.KeyData = Keys.Enter Then
            eventoConsultar()
        End If
    End Sub

End Class
