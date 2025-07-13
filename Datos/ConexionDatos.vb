Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class ConexionDatos
    'Private Shared ReadOnly cadenaConexion As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
    'Private Shared ReadOnly cadenaConexion1 As String = ConfigurationManager.ConnectionStrings("DbCensos").ConnectionString

    Public Shared Function GetLoteriaConexion() As MySqlConnection
        'Return New MySqlConnection("server=127.0.0.1;user id=root;password=SQLjosan1800;persistsecurityinfo=True;database=loteria")
        Return New MySqlConnection("server=86.109.162.100;user id=JA_Censos;password=hH4pw&06;database=dbcensos;persistsecurityinfo=True")
    End Function

    Public Shared Function GetDbCensosConexion() As MySqlConnection
        Return New MySqlConnection("server=86.109.162.100;user id=JA_Censos;password=hH4pw&06;database=dbcensos;persistsecurityinfo=True")
    End Function

End Class
