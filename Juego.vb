Public Class Juego
	Public Const gameButtonWidth As Integer = 150
	Public Const gameButtonHeigth As Integer = 150
	Public randomNumber As Integer

	Public Function isStringAlreadyInButton()

	End Function

	Public Function generateRandomString()

	End Function

	Public Function generateBoard(difficulty As Integer)
		Dim buttons As Integer

		If difficulty = 1 Then

			Dim xPos As Integer = 300
			Dim yPos As Integer = 40
			buttons = 20

			' Row 1 '
			For i = 1 To buttons - 15
				randomNumber = Int((10 * Rnd()) + 1)
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = randomNumber
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next

			xPos = 300
			yPos = 200

			' Row 2 '
			For i = 6 To buttons - 10
				randomNumber = Int((10 * Rnd()) + 1)
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = randomNumber
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next

			xPos = 300
			yPos = 360

			' Row 3 '
			For i = 11 To buttons - 5
				randomNumber = Int((10 * Rnd()) + 1)
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = randomNumber
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next

			xPos = 300
			yPos = 520

			' Row 4 '
			For i = 16 To buttons
				randomNumber = Int((10 * Rnd()) + 1)
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = randomNumber
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next

		ElseIf difficulty = 2 Then
			buttons = 26

		ElseIf difficulty = 3 Then
			buttons = 30

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