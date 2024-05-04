Module Mod_ControleCampos
    Public Sub ChangeFocusOnEnterKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True ' Para evitar que o caractere Enter seja inserido no campo de texto
            If TypeOf sender Is Control Then
                Dim currentControl As Control = DirectCast(sender, Control)
                currentControl.Parent.SelectNextControl(currentControl, True, True, True, True)
            End If
        End If
    End Sub
End Module
