Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module conexion

    '*****************************MS SQL*********************************************************************************************************************************************************************
    'MAC
    'Public cadena As New SqlConnection("Data Source=MacWindows;Initial Catalog=PVDESK;Integrated Security=False;User ID=sa;Password=Ximena2005;Connect Timeout=15;Encrypt=False;Packet Size=4096")

    'ALEX
    'Public conectar As New SqlConnection("Data Source=DEV;Initial Catalog=facturacion33;Integrated Security=False;User ID=sa;Password=Ximena2005;Connect Timeout=15;Encrypt=False;Packet Size=4096")
    'Public conectar As New SqlConnection("Data Source=efactura33.arasis.com.mx;Initial Catalog=arasisco_efactura33;Integrated Security=False;User ID=arasisco_efactura33;Password=Aramos1977@;Connect Timeout=15;Encrypt=False;Packet Size=4096")


    'PVDesk
    ' Public cadena As New SqlConnection("Data Source=PVDESK;Initial Catalog=[facturacion33];Integrated Security=False;User ID=sa;Password=Ximena2005;Connect Timeout=15;Encrypt=False;Packet Size=4096")

    'TOTIS
    'Public cadena As New SqlConnection("Data Source=FTCPU-0120;Initial Catalog=PVDESK;Integrated Security=False;User ID=sa;Password=Ximena2005;Connect Timeout=15;Encrypt=False;Packet Size=4096")

    'BD DB_RAMOS NUBE
    'Public cadena As New SqlConnection("Data Source=184.168.194.58;Initial Catalog=arasis_db;Persist Security Info=True;Password=Lex253014;User ID=arasis;Integrated Security=False;Packet Size=4096;")


    'EDGAR RODRIGUEZ
    'Public cadena As New SqlConnection("Data Source=DESKTOP-SJK5VLS\COMPAC08R2;Initial Catalog=PVDESK;Integrated Security=False;User ID=sa;Password=Erc201;Connect Timeout=15;Encrypt=False;Packet Size=4096")


    Public SQL As String
    'Public MSSQL As String
    'Public Variables.USUARIO_SISTEMA As String
    'Public Variables.NIVEL_SISTEMA As String
    'Public Variables.EMPRESA_SISTEMA As String

    '*******************************************************************************************************************************************************************************************************

    '*****************************MYSQL*********************************************************************************************************************************************************************
    'NUBE
    'Public cadena As New MySqlConnection("Data Source=50.62.209.111;Database=arasis_db;Uid=arasis;Password=Lex253014")

    'LOCAL
    'Public conexion As New MySqlConnection("Data Source=facturacion33.arasis.com.mx;Database=arasisco_facturacion33;Uid=arasi_aramos;Password=253014Aramos@")
    '*******************************************************************************************************************************************************************************************************


End Module
