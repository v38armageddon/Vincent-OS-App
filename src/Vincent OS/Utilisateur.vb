Public Class Utilisateur

    Private Sub Utilisateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            If Login.Label2.Text = "Superutilisateur" Then
                Me.Label2.Text = "Superutilisateur"
            Else
                Me.Label2.Text = Login.Label2.Text
            End If
        ElseIf Bureau2.Visible = True Then
            If Login.Label3.Text = "Invité" Then
                Me.Label2.Text = "Invité"
            Else
                Me.Label2.Text = Login.Label3.Text
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Bureau.Visible = True Then
            Login.Label2.Text = Me.TextBox1.Text
            Login2bureau.Text = "Bienvenue sur Vincent OS : " + Me.TextBox1.Text
            Bureau.Text = "Bureau - Session " + Me.TextBox1.Text
            Bureau.Label3.Text = Me.TextBox1.Text
            UAC.Label2.Text = Me.TextBox1.Text
            Paramètres.Label7.Text = "Utilisateur : " + Me.TextBox1.Text
            Label2.Text = TextBox1.Text
        ElseIf Bureau2.Visible = True Then
            Login.Label3.Text = Me.TextBox1.Text
            Login2bureau2.Text = "Bienvenue sur Vincent OS : " + Me.TextBox1.Text
            Bureau2.Text = "Bureau - Session " + Me.TextBox1.Text
            Bureau2.Label3.Text = Me.TextBox1.Text
            Paramètres.Label7.Text = "Utilisateur : " + Me.TextBox1.Text
            Label2.Text = TextBox1.Text
        End If
    End Sub
End Class