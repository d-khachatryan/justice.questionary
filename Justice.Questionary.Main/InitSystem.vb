Imports SQL.Core.Connector
Imports System.Data

Public Class InitSystem

    Public strConnectionString As String
    Public intLevelID As Integer
    Public intItemID As Integer

    Public Function InitializeControls(wb As WebBrowser, SplitContainer1 As SplitContainer, lbl As ToolStripLabel)
        wb.Url = New Uri("http://www.coe.int/hy/web/yerevan/strengthening-the-independence-professionalism-and-accountability-of-the-justice-system-in-armenia")
        SuppressScriptErrorsOnly(wb)
        SplitContainer1.Panel2Collapsed = False
        frmSplashScreen.ShowDialog()
        lbl.Text = ""
        Return True
    End Function

    Public Function InitializeConnection(lbl As ToolStripLabel, SplitContainer1 As SplitContainer, MainBindingNavigator As BindingNavigator, MenuMain As ToolStripMenuItem, MenuSystem As ToolStripMenuItem)

        'Dim frm As New frmLogin()
        'Dim d As DialogResult = frm.ShowDialog()

        'If Not d = DialogResult.OK Then
        '    lbl.Text = My.Resources.MsgSQLNoConnection
        '    SplitContainer1.Panel2.Enabled = False
        '    MainBindingNavigator.Enabled = False
        '    MenuMain.Enabled = False
        '    MenuSystem.Enabled = False

        '    Return False
        'Else

        '    strConnectionString = frm.strConnectionString

        '    intLevelID = frm.intLevelID
        '    intItemID = frm.intItemID

        '    lbl.Text = ""
        '    SplitContainer1.Panel2.Enabled = True
        '    MainBindingNavigator.Enabled = True
        '    MenuMain.Enabled = True
        '    MenuSystem.Enabled = True

        '    Return True
        'End If

        'strConnectionString = My.MySettings.Default.SqlConnectionstring

        If Not Connect(strConnectionString) Then
            lbl.Text = My.Resources.MsgSQLNoConnection
            SplitContainer1.Panel2.Enabled = False
            MainBindingNavigator.Enabled = False
            MenuMain.Enabled = False
            Return False
        Else
            lbl.Text = ""
            SplitContainer1.Panel2.Enabled = True
            MainBindingNavigator.Enabled = True
            MenuMain.Enabled = True
            Return True
        End If

        Return True
    End Function

    Public Function InitializeDatabase(lbl As ToolStripLabel, TimerMain As Timer) As Boolean
        Try
            If New SqlConnectionStringBuilder(strConnectionString).InitialCatalog = "master" Then
                'If MessageBox.Show("Ցանկանում էք սկսել տվյալների բազայի վերականգնման գործընթացը՞:", "Ուշադրություն", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                '    Dim clsFtp As New Ftpsettings(strConnectionString)
                '    clsFtp.ShowDialog()
                '    Dim objRestoreType As New Restoreform(strConnectionString, My.Settings.Language, New DataTable)
                '    If objRestoreType.ShowDialog() = Windows.Forms.DialogResult.OK Then
                '        SqlConnection.ClearAllPools()
                '        Dim objConnector As New Connmanager(My.Settings.Key1, My.Settings.Key2, My.Settings.Language)
                '        If objConnector.Customize() = 1 Then
                '            strConnectionString = objConnector.ConnectionString
                '            objConnector.Save()
                '            Return True
                '            TimerMain.Enabled = True
                '        Else
                '            lbl.Text = My.Resources.MsgRestoreInterrupted
                '            Return False
                '        End If
                '    Else
                '        lbl.Text = My.Resources.MsgRestoreInterrupted
                '        Return False
                '    End If
                'Else
                '    lbl.Text = My.Resources.MsgRestoreInterrupted
                '    Return False
                'End If
            Else
                Return True
            End If
        Catch ex As Exception
            lbl.Text = My.Resources.MsgRestoreInterrupted
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function SetupDomainSettings(lbl As ToolStripLabel) As Boolean
        Try
            'Using Connection As SqlConnection = New SqlConnection(strConnectionString)
            '    Connection.Open()
            '    Dim selectcmd As New SqlCommand("SELECT  *  FROM  dbo.Database_Setting WHERE Database_Setting_ID = 4 AND Database_Setting_Key = 'Domain_Setting'", Connection)
            '    Dim DataReader = selectcmd.ExecuteReader
            '    If DataReader.HasRows Then
            '        DataReader.Read()
            '        Dim db = New StoreDataContext(strConnectionString)
            '        Dim strItemCode = (From p In db.vItems Where p.Item_ID = DataReader("Database_Setting_Value").ToString.Trim Select p.Item_Code).First().ToString()
            '        lbl.Text = "Ծրագրի տեղակայման վայրի կոդ: " + strItemCode
            '        DataReader.Close()
            '        Return True
            '    Else
            '        Dim objFacilitree As New Facilitree(strConnectionString, 3, 0)
            '        If objFacilitree.ShowDialog = Windows.Forms.DialogResult.OK Then
            '            DataReader.Close()
            '            Dim insertcmd As New SqlCommand("INSERT INTO Database_Setting(Database_Setting_ID, Database_Setting_Key, Database_Setting_Value) VALUES (4, 'Domain_Setting', '" + objFacilitree.FacilityItem + "')", Connection)
            '            insertcmd.ExecuteNonQuery()
            '            SetupDomainSettings(lbl)
            '            Return True
            '        Else
            '            lbl.Text = My.Resources.MsgNotRegistered
            '            Return False
            '        End If
            '    End If
            '    Connection.Close()
            'End Using
            Return True
        Catch ex As SqlException
            lbl.Text = My.Resources.MsgNotRegistered
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function ChangeMajorStructure(lbl As ToolStripLabel) As Boolean
        Try
            Dim intDatabaseMajorVersion = DatabaseMajorVersion(strConnectionString)
            Dim intSoftwareMajorVersion = My.Resources.strSoftwareMajorVersion

            If intDatabaseMajorVersion = intSoftwareMajorVersion Then
                Return True
            End If

            If intDatabaseMajorVersion > intSoftwareMajorVersion Then
                MessageBox.Show(My.Resources.MsgWorkFailed, My.Resources.MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If intDatabaseMajorVersion < intSoftwareMajorVersion Then
                If MessageBox.Show(My.Resources.MsgRefreshAndArchieveBase, My.Resources.MsgBoxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then

                    'Dim bckForm As Backupform
                    'Dim strBackupName As String
                    'Dim db As New StoreDataContext(strConnectionString)
                    'Dim strDatabaseName As String = New SqlConnectionStringBuilder(strConnectionString).InitialCatalog
                    'Dim qry = From p In db.Database_Settings Where p.Database_Setting_Key = "Domain_Setting" Select p
                    'If (qry.Count > 0) Then
                    '    strBackupName = "T-" & qry.First().Database_Setting_Value & "-" & DateTime.Now.ToString("ddMMyyyyHHmm") & ".bak"
                    '    bckForm = New Backupform(strConnectionString, My.Settings.Language, strDatabaseName, strBackupName)
                    'Else
                    '    strBackupName = ""
                    '    bckForm = New Backupform(strConnectionString, My.Settings.Language, strDatabaseName)
                    'End If

                    'If bckForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    '    Dim cls As New frmChangeMajor(strConnectionString)
                    '    cls.ShowDialog()
                    '    Return True
                    'End If
                End If
            End If

            lbl.Text = My.Resources.MsgRefreshBase
            Return False
        Catch ex As SqlException
            MessageBox.Show(ex.Message, My.Resources.MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ChangeMinorStructure(lbl As ToolStripLabel) As Boolean
        Try
            Dim intDatabaseMinorVersion = DatabaseMinorVersion(strConnectionString)
            Dim intSoftwareMinroVersion = My.Resources.strSoftwareMinorVersion

            If intDatabaseMinorVersion = intSoftwareMinroVersion Then
                Return True
            End If

            If intDatabaseMinorVersion > intSoftwareMinroVersion Then
                MessageBox.Show(My.Resources.MsgWorkFailed, My.Resources.MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            'If intDatabaseMinorVersion < intSoftwareMinroVersion Then
            '    Dim cls As New frmChangeMinor(strConnectionString)
            '    cls.ShowDialog()
            'End If

            Return True
        Catch ex As SqlException
            lbl.Text = My.Resources.MsgRefreshBase
            MessageBox.Show(ex.Message, My.Resources.MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#Region "Private Functions"

    Private Function Connect(ByRef ConnectionString As String) As Boolean
        Dim objConnector As New Connmanager(My.Settings.Key1, My.Settings.Key2, My.Settings.Language)
        If objConnector.Connect() = 0 Then
            If MessageBox.Show("Հնարավոր չէ կապ հաստատել SQL սերվերի հետ: Ցանկանում էք փոխել սերվերի հետ կապի փոփոխականները?", "Ուշադրություն", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objConnector.Customize() = 1 Then
                    ConnectionString = objConnector.ConnectionString
                    objConnector.Save()
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            ConnectionString = objConnector.ConnectionString
            Return True
        End If
    End Function

    Private Function DatabaseMajorVersion(strConnectionString As String) As Integer
        Try
            Dim Database_Version As String
            Dim conn = New SqlConnection(strConnectionString)
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            conn.Open()
            cmd.CommandText = "SELECT Count(*) FROM dbo.Database_Setting WHERE Database_Setting_Key = 'Major_Version'"
            If cmd.ExecuteScalar = 0 Then
                cmd.CommandText = "INSERT INTO Database_Setting (Database_Setting_ID, Database_Setting_Key, Database_Setting_Value) VALUES (2, 'Minor_Version','1')"
                cmd.ExecuteNonQuery()
                Database_Version = "1"
            Else
                cmd.CommandText = "SELECT Database_Setting_Value FROM dbo.Database_Setting WHERE Database_Setting_Key = 'Major_Version'"
                Database_Version = cmd.ExecuteScalar
            End If
            conn.Close()
            Return Database_Version
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Private Function DatabaseMinorVersion(strConnectionString As String) As String
        Try
            Dim Software_Version As String
            Dim conn = New SqlConnection(strConnectionString)
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            conn.Open()
            cmd.CommandText = "SELECT Count(*) FROM dbo.Database_Setting WHERE Database_Setting_Key = 'Minor_Version'"
            If cmd.ExecuteScalar = 0 Then
                cmd.CommandText = "INSERT INTO Database_Setting (Database_Setting_ID, Database_Setting_Key, Database_Setting_Value) VALUES (3, 'Minor_Version','1.0.0.0')"
                cmd.ExecuteNonQuery()
                Software_Version = "1.0.0.0"
            Else
                cmd.CommandText = "SELECT Database_Setting_Value FROM dbo.Database_Setting WHERE Database_Setting_Key = 'Minor_Version'"
                Software_Version = cmd.ExecuteScalar
            End If
            conn.Close()
            Return Software_Version
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Private Sub SuppressScriptErrorsOnly(ByVal browser As WebBrowser)
        ' Ensure that ScriptErrorsSuppressed is set to false.
        browser.ScriptErrorsSuppressed = False
        ' Handle DocumentCompleted to gain access to the Document object. 
        AddHandler browser.DocumentCompleted, AddressOf Browser_DocumentCompleted
    End Sub

    Private Sub Browser_DocumentCompleted(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        AddHandler CType(sender, WebBrowser).Document.Window.Error, AddressOf Window_Error
    End Sub

    Private Sub Window_Error(ByVal sender As Object, ByVal e As HtmlElementErrorEventArgs)
        ' Ignore the error and suppress the error dialog box. 
        e.Handled = True
    End Sub

#End Region

End Class
