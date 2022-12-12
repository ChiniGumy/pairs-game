Public Class Juego

	Public tableroFacil(4, 4) As Integer
	Public tableroIntermedio(6, 6) As Integer
	Public tableroDificil(10, 10) As Integer

	Public Function generateBoard(difficulty As Integer)
		Dim buttons As Integer

		If difficulty = 1 Then
			buttons = 6

			' Row 1 '
			For i = 1 To buttons - 3

				Dim gameButton As New Button

				gameButton.Width = 150
				gameButton.Height = 200

				Select Case i
					Case 1
						gameButton.Location = New Point(400, 40)
					Case 2
						gameButton.Location = New Point(560, 40)
					Case 3
						gameButton.Location = New Point(720, 40)
				End Select

				gameButton.Text = i
				Form1.Controls.Add(gameButton)
			Next

			' Row 2 '
			For i = 4 To buttons

				Dim gameButton As New Button

				gameButton.Width = 150
				gameButton.Height = 200

				Select Case i
					Case 4
						gameButton.Location = New Point(400, 250)
					Case 5
						gameButton.Location = New Point(560, 250)
					Case 6
						gameButton.Location = New Point(720, 250)
				End Select


				gameButton.Text = i
				Form1.Controls.Add(gameButton)
			Next


		ElseIf difficulty = 2 Then
			buttons = 12

			' Row 1 '
			For i = 1 To buttons - 8

				Dim gameButton As New Button

				gameButton.Width = 150
				gameButton.Height = 200

				Select Case i
					Case 1
						gameButton.Location = New Point(400, 40)
					Case 2
						gameButton.Location = New Point(560, 40)
					Case 3
						gameButton.Location = New Point(720, 40)
					Case 4
						gameButton.Location = New Point(880, 40)
				End Select

				gameButton.Text = i
				Form1.Controls.Add(gameButton)
			Next

			' Row 2 '
			For i = 5 To buttons - 4

				Dim gameButton As New Button

				gameButton.Width = 150
				gameButton.Height = 200

				Select Case i
					Case 5
						gameButton.Location = New Point(400, 250)
					Case 6
						gameButton.Location = New Point(560, 250)
					Case 7
						gameButton.Location = New Point(720, 250)
					Case 8
						gameButton.Location = New Point(880, 250)
				End Select

				gameButton.Text = i
				Form1.Controls.Add(gameButton)
			Next

			' Row 3 '
			For i = 9 To buttons

				Dim gameButton As New Button

				gameButton.Width = 150
				gameButton.Height = 200

				Select Case i
					Case 9
						gameButton.Location = New Point(400, 460)
					Case 10
						gameButton.Location = New Point(560, 460)
					Case 11
						gameButton.Location = New Point(720, 460)
					Case 12
						gameButton.Location = New Point(880, 460)
				End Select

				gameButton.Text = i
				Form1.Controls.Add(gameButton)
			Next


		ElseIf difficulty = 3 Then
			buttons = 20
			' Row 1 '
			For i = 1 To buttons - 15

				Dim gameButton As New Button

				gameButton.Width = 150
				gameButton.Height = 200

				Select Case i
					Case 1
						gameButton.Location = New Point(300, 40)
					Case 2
						gameButton.Location = New Point(460, 40)
					Case 3
						gameButton.Location = New Point(620, 40)
					Case 4
						gameButton.Location = New Point(780, 40)
					Case 5
						gameButton.Location = New Point(940, 40)
				End Select

				gameButton.Text = i
				Form1.Controls.Add(gameButton)
			Next

			' Row 2 '
			For i = 6 To buttons - 10

				Dim gameButton As New Button

				gameButton.Width = 150
				gameButton.Height = 200

				Select Case i
					Case 6
						gameButton.Location = New Point(300, 250)
					Case 7
						gameButton.Location = New Point(460, 250)
					Case 8
						gameButton.Location = New Point(620, 250)
					Case 9
						gameButton.Location = New Point(780, 250)
					Case 10
						gameButton.Location = New Point(940, 250)
				End Select

				gameButton.Text = i
				Form1.Controls.Add(gameButton)
			Next

			' Row 3 '
			For i = 11 To buttons - 5

				Dim gameButton As New Button

				gameButton.Width = 150
				gameButton.Height = 200

				Select Case i
					Case 11
						gameButton.Location = New Point(300, 460)
					Case 12
						gameButton.Location = New Point(460, 460)
					Case 13
						gameButton.Location = New Point(620, 460)
					Case 14
						gameButton.Location = New Point(780, 460)
					Case 15
						gameButton.Location = New Point(940, 460)
				End Select

				gameButton.Text = i
				Form1.Controls.Add(gameButton)
			Next

			' Row 4 '
			For i = 16 To buttons

				Dim gameButton As New Button

				gameButton.Width = 150
				gameButton.Height = 200

				Select Case i
					Case 16
						gameButton.Location = New Point(300, 670)
					Case 17
						gameButton.Location = New Point(460, 670)
					Case 18
						gameButton.Location = New Point(620, 670)
					Case 19
						gameButton.Location = New Point(780, 670)
					Case 20
						gameButton.Location = New Point(940, 670)
				End Select

				gameButton.Text = i
				Form1.Controls.Add(gameButton)
			Next

		End If
	End Function

	Public Function eraseBoard()
		Dim btnList As List(Of Button) = Form1.Controls.OfType(Of Button).ToList()

		btnList.Remove(Form1.newGameButton)

		For Each btn As Button In btnList
			btn.Dispose()
		Next
	End Function


End Class