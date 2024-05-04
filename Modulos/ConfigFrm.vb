
Module ConfigFrm
    Sub limpatexto(ByVal parentControl As Control)
        For Each ctrl As Control In parentControl.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = ""
            ElseIf TypeOf ctrl Is Panel Then
                limpatexto(ctrl)
            End If
        Next
    End Sub
End Module



