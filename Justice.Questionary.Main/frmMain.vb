Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms
Imports AspNetMembershipMgr
Imports Justice.Questionary.Data
Imports Justice.Questionary.Input
Imports SQL.Core.Connector
Imports Justice.Questionary.Catalogs
Imports Justice.Questionary.Output

Public Class frmMain

    Private strLanguage As String
    Private strConnectionString As String

#Region "Init Operations"

    Public Sub New()

        Dim culture As New CultureInfo(My.Settings.Language)
        culture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        culture.DateTimeFormat.DateSeparator = "/"
        culture.DateTimeFormat.ShortTimePattern = String.Empty
        Thread.CurrentThread.CurrentCulture = culture
        Thread.CurrentThread.CurrentUICulture = culture
        strLanguage = My.Settings.Language
        InitializeComponent()
        Me.Text = Me.Text + " version " + My.Resources.strSoftwareMinorVersion

    End Sub

    Private Sub Tmer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMain.Tick

        Try

            Me.TimerMain.Enabled = False

            Dim initClass As New InitSystem()

            If Not initClass.InitializeControls(Me.wbControl, Me.splContainer, Me.lblStatus) Then
                Return
            End If

            If Not initClass.InitializeConnection(Me.lblStatus, splContainer, MainBindingNavigator, MenuMain, MenuSystem) Then
                Return
            Else
                strConnectionString = initClass.strConnectionString
            End If

            If Not initClass.InitializeDatabase(Me.lblStatus, Me.TimerMain) Then
                Return
            End If

            If Not initClass.SetupDomainSettings(Me.lblStatus) Then
                Return
            End If

            'If Not initClass.ChangeMajorStructure(Me.lblStatus) Then
            '    Return
            'End If

            'If Not initClass.ChangeMinorStructure(Me.lblStatus) Then
            '    Return
            'End If

            Dim objLogin As New frmLogin(My.Settings.Language, strConnectionString)
            If objLogin.ShowDialog() = Windows.Forms.DialogResult.OK Then
                GlobalClass.UserName = objLogin.strUserName
                splContainer.Panel2.Enabled = True
                MainBindingNavigator.Enabled = True
                MenuMain.Enabled = True

                If (GlobalClass.checkUserStatus() <> 1) Then
                    MenuSystem.Enabled = False
                Else
                    MenuSystem.Enabled = True
                End If

            Else
                GlobalClass.UserName = Nothing
                splContainer.Panel2.Enabled = False
                MainBindingNavigator.Enabled = False
                MenuMain.Enabled = False
                MenuSystem.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Panel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPanel.Click
        Try
            If Me.splContainer.Panel2Collapsed = True Then
                Me.splContainer.Panel2Collapsed = False
            Else
                Me.splContainer.Panel2Collapsed = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "File Menu"

    Private Sub Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmConnect.Click
        Try
            Dim objConnector As New Connmanager(My.Settings.Key1, My.Settings.Key2, My.Settings.Language)
            If objConnector.Customize() = 1 Then
                strConnectionString = objConnector.ConnectionString
                objConnector.Save()
                For Each Item As TabPage In Me.TabControl1.TabPages
                    If Item.Name <> "TbpGeneral" Then
                        Me.TabControl1.TabPages.Remove(Item)
                    End If
                Next
                Me.TimerMain.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub Script_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmUpdateDatabase.Click
    '    Try
    '        Dim ChildForm As New SchemaUpdateForm(strConnectionString)
    '        ChildForm.ShowDialog()
    '        ChildForm.Dispose()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmExit.Click
        Application.Exit()
    End Sub

#End Region

#Region "Main Operations"

    Private Sub QuestionT1_Click(sender As System.Object, e As System.EventArgs) Handles TsbQuestionT.Click, TsmQuestionT.Click, lblQuestionT1.Click
        Try
            Dim cls As New Justice.Questionary.Input.ctlQuestionT1(strLanguage, strConnectionString)
            cls.Dock = DockStyle.Fill
            Me.splContainer.Panel2Collapsed = True
            For Each Item As TabPage In Me.TabControl1.TabPages
                If Item.Name = "TbpQuestionT1I" Then
                    Me.TabControl1.SelectedTab = Item
                    Return
                End If
            Next
            Me.TabControl1.TabPages.Add("TbpQuestionT1I", "Ընդհանուր իրավասության դատարանից օգտվողների հարցաթեթեր")
            Me.TabControl1.TabPages("TbpQuestionT1I").Controls.Add(cls)
            cls.BringToFront()
            Me.TabControl1.SelectedTab = Me.TabControl1.TabPages("TbpQuestionT1I")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub QuestionT2_Click(sender As System.Object, e As System.EventArgs) Handles lblQuestionT2.Click, TsmQuestionTB.Click, TsbQuestionTB.Click
        Try
            Dim cls As New Justice.Questionary.Input.ctlQuestionT2(strLanguage, strConnectionString)
            cls.Dock = DockStyle.Fill
            Me.splContainer.Panel2Collapsed = True
            For Each Item As TabPage In Me.TabControl1.TabPages
                If Item.Name = "TbpQuestionT2I" Then
                    Me.TabControl1.SelectedTab = Item
                    Return
                End If
            Next
            Me.TabControl1.TabPages.Add("TbpQuestionT2I", "Վերաքննիչ դատարանից օգտվողների հարցաթեթեր")
            Me.TabControl1.TabPages("TbpQuestionT2I").Controls.Add(cls)
            cls.BringToFront()
            Me.TabControl1.SelectedTab = Me.TabControl1.TabPages("TbpQuestionT2I")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub QuestionT3_Click(sender As System.Object, e As System.EventArgs) Handles lblQuestionT3.Click, TsmQuestionTZ.Click, TsbQuestionTZ.Click
        Try
            Dim cls As New Justice.Questionary.Input.ctlQuestionT3(strLanguage, strConnectionString)
            cls.Dock = DockStyle.Fill
            Me.splContainer.Panel2Collapsed = True
            For Each Item As TabPage In Me.TabControl1.TabPages
                If Item.Name = "TbpQuestionT3I" Then
                    Me.TabControl1.SelectedTab = Item
                    Return
                End If
            Next
            Me.TabControl1.TabPages.Add("TbpQuestionT3I", "Վճռաբեկ դատարանից օգտվողների հարցաթեթեր")
            Me.TabControl1.TabPages("TbpQuestionT3I").Controls.Add(cls)
            cls.BringToFront()
            Me.TabControl1.SelectedTab = Me.TabControl1.TabPages("TbpQuestionT3I")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub QuestionX_Click(sender As System.Object, e As System.EventArgs) Handles TsbQuestionX.Click, TsmQuestionX.Click, lblQuestionX.Click
        Try
            Dim cls As New Justice.Questionary.Input.ctlQuestionX(strLanguage, strConnectionString)
            cls.Dock = DockStyle.Fill
            Me.splContainer.Panel2Collapsed = True
            For Each Item As TabPage In Me.TabControl1.TabPages
                If Item.Name = "TbpQuestionXI" Then
                    Me.TabControl1.SelectedTab = Item
                    Return
                End If
            Next
            Me.TabControl1.TabPages.Add("TbpQuestionXI", "Փաստաբաններին ուղղված հարցաթեթեր")
            Me.TabControl1.TabPages("TbpQuestionXI").Controls.Add(cls)
            cls.BringToFront()
            Me.TabControl1.SelectedTab = Me.TabControl1.TabPages("TbpQuestionXI")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub QuestionT1Report_Click(sender As Object, e As EventArgs) Handles lblQuestionT1Report.Click, TsmQuestionT1Report.Click, TsbQuestionT1Report.Click
        Try
            Dim cls As New Justice.Questionary.Output.ctlQuestionT1(strLanguage, strConnectionString)
            cls.Dock = DockStyle.Fill
            Me.splContainer.Panel2Collapsed = True
            For Each Item As TabPage In Me.TabControl1.TabPages
                If Item.Name = "TbpQuestionT1O" Then
                    Me.TabControl1.SelectedTab = Item
                    Return
                End If
            Next
            Me.TabControl1.TabPages.Add("TbpQuestionT1O", "Ընդհանուր իրավասության դատարանից օգտվողների տվյալների վերլուծություն")
            Me.TabControl1.TabPages("TbpQuestionT1O").Controls.Add(cls)
            cls.BringToFront()
            Me.TabControl1.SelectedTab = Me.TabControl1.TabPages("TbpQuestionT1O")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub QuestionT2Report_Click(sender As Object, e As EventArgs) Handles lblQuestionT2Report.Click, TsmQuestionT2Report.Click, TsbQuestionT2Report.Click
        Try
            Dim cls As New Justice.Questionary.Output.ctlQuestionT2(strLanguage, strConnectionString)
            cls.Dock = DockStyle.Fill
            Me.splContainer.Panel2Collapsed = True
            For Each Item As TabPage In Me.TabControl1.TabPages
                If Item.Name = "TbpQuestionT2O" Then
                    Me.TabControl1.SelectedTab = Item
                    Return
                End If
            Next
            Me.TabControl1.TabPages.Add("TbpQuestionT2O", "Վերաքննիչ դատարանից օգտվողների տվյալների վերլուծություն")
            Me.TabControl1.TabPages("TbpQuestionT2O").Controls.Add(cls)
            cls.BringToFront()
            Me.TabControl1.SelectedTab = Me.TabControl1.TabPages("TbpQuestionT2O")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub QuestionT3Report_Click(sender As Object, e As EventArgs) Handles lblQuestionT3Report.Click, TsmQuestionT3Report.Click, TsbQuestionT3Report.Click
        Try
            Dim cls As New Justice.Questionary.Output.ctlQuestionT3(strLanguage, strConnectionString)
            cls.Dock = DockStyle.Fill
            Me.splContainer.Panel2Collapsed = True
            For Each Item As TabPage In Me.TabControl1.TabPages
                If Item.Name = "TbpQuestionT3O" Then
                    Me.TabControl1.SelectedTab = Item
                    Return
                End If
            Next
            Me.TabControl1.TabPages.Add("TbpQuestionT3O", "Վճռաբեկ դատարանից օգտվողների տվյալների վերլուծություն")
            Me.TabControl1.TabPages("TbpQuestionT3O").Controls.Add(cls)
            cls.BringToFront()
            Me.TabControl1.SelectedTab = Me.TabControl1.TabPages("TbpQuestionT3O")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub QuestionXReport_Click(sender As Object, e As EventArgs) Handles lblQuestionXReport.Click, TsmQuestionXReport.Click, TsbQuestionXReport.Click
        Try
            Dim cls As New Justice.Questionary.Output.ctlQuestionX(strLanguage, strConnectionString)
            cls.Dock = DockStyle.Fill
            Me.splContainer.Panel2Collapsed = True
            For Each Item As TabPage In Me.TabControl1.TabPages
                If Item.Name = "TbpQuestionXO" Then
                    Me.TabControl1.SelectedTab = Item
                    Return
                End If
            Next
            Me.TabControl1.TabPages.Add("TbpQuestionXO", "Փաստաբաններին ուղղված հարցաթերթիկների տվյալների վերլուծություն")
            Me.TabControl1.TabPages("TbpQuestionXO").Controls.Add(cls)
            cls.BringToFront()
            Me.TabControl1.SelectedTab = Me.TabControl1.TabPages("TbpQuestionXO")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Database management"

    Private Sub Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Dim cls As New frmExport(My.Settings.Language, strConnectionString)
            'cls.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Dim cls As New frmImport(My.Settings.Language, strConnectionString)
            'cls.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Catalog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Dim cls As New frmImportCatalogs(My.Settings.Language, strConnectionString)
            'cls.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Database tools"

    Private Sub Restore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Dim ChildForm As New Restoreform(strConnectionString, My.Settings.Language, New DataTable)
            'If ChildForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '    Try
            '        Dim objConnector As New Connmanager(My.Settings.Key1, My.Settings.Key2, My.Settings.Language)
            '        If objConnector.Customize() = 1 Then
            '            strConnectionString = objConnector.ConnectionString
            '            objConnector.Save()
            '        End If
            '    Catch ex As Exception
            '        MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    End Try
            '    Me.TimerMain.Enabled = True
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Dim cls As New frmBackup(strLanguage, strConnectionString)
            'cls.ShowDialog()
            'cls.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TsmUserManagement_Click(sender As System.Object, e As System.EventArgs) Handles TsmUserManagement.Click
        Try
            Dim frm As New frmUserManager(strLanguage, strConnectionString)
            frm.ShowDialog()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Help menu"

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmHelp.Click, TsbHelp.Click
        Try
            MessageBox.Show("Սույն բաժինը դեռևս մշակման մեջ է", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmAbout.Click
        Try
            Dim ChildForm As New About
            ChildForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Catalogs"
    Private Sub Catalogs_Click(sender As System.Object, e As System.EventArgs) Handles TsmCatalogs.Click
        Try
            Dim frm As New frmCatalogManager(strConnectionString)
            frm.ShowDialog()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#End Region

End Class