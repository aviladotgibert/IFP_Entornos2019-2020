Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Class Form

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private NameValid As Boolean 'Es Nombre Valido ?
    Private PhoneValid As Boolean 'Es Numero de Telefono Valido?
    Private EmailValid As Boolean 'Es Email Valido?
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' PARAMETROS DE PARA CONEXION A LA BASE DE DATOS 

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Documentos\Cursos IFP\DAM2\MP05 - Entornos de desarrollo\UF1- Desarrollo de Software\Actividades\M5UF1A2 - Programas desarrollados de VisualStudio\M5UF1A2_AppEntumundo_Eduardo_Celis\AppEntumundo\AppEntumundo.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        disp_data()


    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click

        Dim sValidation As Boolean = Validation(txt_nombre.Text, txt_email.Text, txt_telefono.Text)

        If sValidation = True Then

            'GENERACION DEL GUID
            Dim userId As Guid
            userId = Guid.NewGuid()
            Dim UserString = userId.ToString()

            'FECHA Y FORMATEO
            Dim dt = DateTime.Now()
            Dim reformatted As String = dt.ToString("yyyy-MM-dd")


            'ENCRIPTACION
            Dim plainText As String = txt_clave.Text
            Dim password As String = "1234"

            Dim wrapper As New Simple3Des(password)
            Dim cipherText As String = wrapper.EncryptData(plainText)

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Users values('" + UserString + "','" + txt_email.Text + "','" + txt_clave.Text + "','" + cipherText + "','" + txt_telefono.Text + "', '" + reformatted + "','" + txt_nombre.Text + "')"

            cmd.ExecuteNonQuery()

            disp_data()

            txt_nombre.Text = ""
            txt_email.Text = ""
            txt_clave.Text = ""
            txt_telefono.Text = ""

            MessageBox.Show("Registro insertado correctamente")

        End If

    End Sub
    Public Sub disp_data()

        'MOSTRAR DATOS DE LOS USUARIOS

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Id,Nombre,UserId,Email,ClaveEncript,Telefono,FechaCreacion from Users"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select Id,Nombre,UserId,Email,Clave,ClaveEncript,Telefono,FechaCreacion from Users where id=" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read

                txt_email.Text = dr.GetString(3).ToString()
                txt_clave.Text = dr.GetString(4).ToString()
                txt_telefono.Text = dr.GetString(6).ToString()
                txt_nombre.Text = dr.GetString(1).ToString()

            End While
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click

        Dim sValidation As Boolean = Validation(txt_nombre.Text, txt_email.Text, txt_telefono.Text)

        If sValidation = True Then

            'ENCRIPTACION
            Dim plainText As String = txt_clave.Text
            Dim password As String = "1234"

            Dim wrapper As New Simple3Des(password)
            Dim cipherText As String = wrapper.EncryptData(plainText)

            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            'cmd.CommandText = "update Users set name='" + TextBox1.Text + "',city='" + TextBox2.Text + "' where id=" & i & ""
            cmd.CommandText = "update Users set nombre='" + txt_nombre.Text + "',email='" + txt_email.Text + "',clave='" + txt_clave.Text + "',ClaveEncript='" + cipherText + "',telefono='" + txt_telefono.Text + "' where id=" & i & ""
            cmd.ExecuteNonQuery()

            disp_data()

            MessageBox.Show("Registro actualizado correctamente")

        End If

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        'cmd.CommandText = "delete from Users where name='" + TextBox1.Text + "'"
        cmd.CommandText = "delete from Users where nombre='" + txt_nombre.Text + "'"
        cmd.ExecuteNonQuery()

        disp_data()

        MessageBox.Show("Registro eliminado correctamente")

    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        disp_data()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        'Algo escrito 
        If Not String.IsNullOrEmpty(txt_nombre.Text) Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Users where nombre like '%" + txt_nombre.Text + "%'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Else
            MessageBox.Show("Introduzca un nombre para buscar el registro !")
        End If

    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Me.Show()
    End Sub
    'Function para validar el nombre
    Public Function ValidateName(ByVal strName As String) As Boolean

        'Si no se ingresó un formato coincidente
        If Not Regex.Match(strName, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then 'Solo Letras
            NameValid = False 'Boolean = False
            MessageBox.Show("Introduzca un nombre con caracteres alfabéticos!")
            txt_nombre.Focus() 'Returna Focus
            txt_nombre.Clear() 'Limpia el TextBox
        Else
            NameValid = True 'Everything Fine
        End If

        Return NameValid 'Returna True / False

    End Function
    'Function para validar el numero de telefono
    Public Function ValidatePhone(ByVal strPhoneNum As String) As Boolean

        'Algo escrito 
        If Not String.IsNullOrEmpty(strPhoneNum) Then

            If IsNumeric(strPhoneNum) Then
                PhoneValid = True
            Else
                PhoneValid = False
                MessageBox.Show("Introduzca un teléfono con sólo numeros!")
                txt_telefono.Focus() 'Returna Focus
                txt_telefono.Clear() 'Limpia el TextBox
            End If

        Else
            PhoneValid = False 'No Valido
        End If

        Return PhoneValid 'Returna True / False

    End Function
    'Function para validar el formato del email
    Function ValidateEmail(ByVal s As String) As Boolean

        If Not Regex.Match(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$").Success Then
            MessageBox.Show("Introduzca un email con formato correcto!")
            txt_email.Focus() 'Returna Focus
            txt_email.Clear() 'Limpia el TextBox
            NameValid = False 'Everything Fine
        Else
            NameValid = True 'Everything Fine
        End If

        Return NameValid 'Returna True / False

    End Function
    Function Validation(ByVal sName As String, ByVal sEmail As String, ByVal sTelefono As String) As Boolean

        Dim sValido As Boolean

        Dim vName As Boolean = ValidateName(sName)

        If vName = True Then
            Dim vEmail As Boolean = ValidateEmail(sEmail)
            If vEmail = True Then
                Dim vTelefono As Boolean = ValidatePhone(sTelefono)
                If vTelefono = True Then
                    sValido = True
                Else
                    sValido = False
                End If
            End If
        Else
            sValido = False
        End If

        Return sValido 'Return True / False

    End Function
    Private Sub JobInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobInformationToolStripMenuItem.Click

    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub InicioDeLaAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioDeLaAppToolStripMenuItem.Click
        Inicio.Show()
    End Sub
End Class
Public NotInheritable Class Simple3Des

    Private TripleDes As New TripleDESCryptoServiceProvider
    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function
    Sub New(ByVal key As String)
        ' Inicializar el proveedor de cifrado.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub

    Public Function EncryptData(ByVal plaintext As String) As String

        '  Convierte la cadena de texto sin formato en una matriz de bytes..
        Dim plaintextBytes() As Byte =
        System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Crea la secuencia.
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms,
        TripleDes.CreateEncryptor(),
        System.Security.Cryptography.CryptoStreamMode.Write)

        ' Usa la secuencia de cifrado para escribir la matriz de bytes en la secuencia.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convierta la secuencia cifrada en una cadena imprimible.
        Return Convert.ToBase64String(ms.ToArray)

    End Function

    Public Function DecryptData(ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array.
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream.
        Dim decStream As New CryptoStream(ms,
        TripleDes.CreateDecryptor(),
        System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string.
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function

End Class