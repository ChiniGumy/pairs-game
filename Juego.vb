Public Class Juego
	Public Const gameButtonWidth As Integer = 150
	Public Const gameButtonHeigth As Integer = 200

	Public Function generateBoard(difficulty As Integer)

		Dim buttons As Integer

		If difficulty = 1 Then
			Dim xPos As Integer = 400
			Dim yPos As Integer = 40
			buttons = 6

			' Row 1 '
			For i = 1 To buttons - 3
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = i
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next

			xPos = 400
			yPos = 250

			' Row 2 '
			For i = 4 To buttons
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = i
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next


		ElseIf difficulty = 2 Then
			Dim xPos As Integer = 400
			Dim yPos As Integer = 40
			buttons = 12

			' Row 1 '
			For i = 1 To buttons - 8
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = i
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next

			xPos = 400
			yPos = 250

			' Row 2 '
			For i = 5 To buttons - 4
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = i
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next

			xPos = 400
			yPos = 460

			' Row 3 '
			For i = 9 To buttons
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = i
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next


		ElseIf difficulty = 3 Then
			Dim xPos As Integer = 300
			Dim yPos As Integer = 40
			buttons = 20

			' Row 1 '
			For i = 1 To buttons - 15

				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = i
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next

			xPos = 300
			yPos = 250

			' Row 2 '
			For i = 6 To buttons - 10
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = i
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next

			xPos = 300
			yPos = 460

			' Row 3 '
			For i = 11 To buttons - 5
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = i
				xPos += 160
				Form1.Controls.Add(gameButton)
			Next

			xPos = 300
			yPos = 670

			' Row 4 '
			For i = 16 To buttons
				Dim gameButton As New Button
				gameButton.Width = gameButtonWidth
				gameButton.Height = gameButtonHeigth
				gameButton.Location = New Point(xPos, yPos)
				gameButton.Text = i
				xPos += 160
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