Imports MaterialSkin
Module myCustomSkin
    Public Sub myCustomSkin()
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        'Add your forms here
        With SkinManager
            .AddFormToManage(splash)
            .AddFormToManage(login)
            .AddFormToManage(dashboard)
            .AddFormToManage(manageStudents)
            .AddFormToManage(manageEvents)
            .AddFormToManage(scanQR)
            .AddFormToManage(viewStudent)
            .AddFormToManage(manageUsers)
            .AddFormToManage(filterReports)
            .AddFormToManage(importMultipleStudents)
            .AddFormToManage(recoverPassword)
            .Theme = MaterialSkinManager.Themes.LIGHT
            .ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE)
        End With
    End Sub
End Module
