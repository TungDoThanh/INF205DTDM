# INF205DTDM
Imports System
Imports System.Data
Imports Sql.Data.Types
Imports System.Configuration
Imports Sql.Data.SqlClient
Public Class PhepCong
public function PhepCong(ByVal SoA as int, Byval SoB as int)
 Dim Tong as int = 0
 Tong = soA + SoB
 return Tong
End Function
End Class
