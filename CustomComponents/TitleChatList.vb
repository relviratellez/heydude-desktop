﻿Public Class TitleChatList
    Property UserName() As String
        Get
            Return LblUserName.Text
        End Get
        Set(value As String)
            LblUserName.Text = value
        End Set
    End Property

    Property UserState() As String
        Get
            Return LblUserState.Text
        End Get
        Set(value As String)
            LblUserState.Text = value
        End Set
    End Property

    WriteOnly Property Connected() As State
        Set(value As State)
            Select Case value
                Case State.Connected
                    ImgConnected.BackColor = Color.FromArgb(57, 144, 68)
            End Select
        End Set
    End Property
End Class
