Public Class Form1
	Dim game As New Juego

	Public Sub unCheckRadioButtons()
		radioButtonEasy.Checked = False
		radioButtonIntermedian.Checked = False
		radioButtonHard.Checked = False
		newGameButton.Enabled = True
	End Sub
	Public Sub enableRadioButtons()
		radioButtonEasy.Enabled = True
		radioButtonIntermedian.Enabled = True
		radioButtonHard.Enabled = True
	End Sub
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		newGameButton.Enabled = False
		radioButtonHard.TabStop = False
		radioButtonEasy.TabIndex = 0
		radioButtonIntermedian.TabIndex = 0
		radioButtonHard.TabIndex = 0

	End Sub

	Private Sub radioButtonEasy_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonEasy.CheckedChanged
		game.generateBoard(1)
		radioButtonIntermedian.Enabled = False
		radioButtonHard.Enabled = False
		newGameButton.Enabled = True

	End Sub

	Private Sub radioButtonIntermedian_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonIntermedian.CheckedChanged
		game.generateBoard(2)
		radioButtonEasy.Enabled = False
		radioButtonHard.Enabled = False
		newGameButton.Enabled = True

	End Sub

	Private Sub radioButtonHard_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonHard.CheckedChanged
		game.generateBoard(3)
		radioButtonEasy.Enabled = False
		radioButtonIntermedian.Enabled = False
		newGameButton.Enabled = True

	End Sub

	Private Sub newGameButton_Click(sender As Object, e As EventArgs) Handles newGameButton.Click
		unCheckRadioButtons()
		enableRadioButtons()
		game.eraseBoard()
	End Sub

End Class