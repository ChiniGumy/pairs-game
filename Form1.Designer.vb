<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radioButtonEasy = New System.Windows.Forms.RadioButton()
        Me.radioButtonIntermedian = New System.Windows.Forms.RadioButton()
        Me.radioButtonHard = New System.Windows.Forms.RadioButton()
        Me.newGameButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(93, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DIFICULTADES"
        '
        'radioButtonEasy
        '
        Me.radioButtonEasy.AutoSize = True
        Me.radioButtonEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radioButtonEasy.Location = New System.Drawing.Point(156, 97)
        Me.radioButtonEasy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioButtonEasy.Name = "radioButtonEasy"
        Me.radioButtonEasy.Size = New System.Drawing.Size(74, 29)
        Me.radioButtonEasy.TabIndex = 1
        Me.radioButtonEasy.TabStop = True
        Me.radioButtonEasy.Text = "Facil"
        Me.radioButtonEasy.UseVisualStyleBackColor = True
        '
        'radioButtonIntermedian
        '
        Me.radioButtonIntermedian.AutoSize = True
        Me.radioButtonIntermedian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radioButtonIntermedian.Location = New System.Drawing.Point(128, 145)
        Me.radioButtonIntermedian.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioButtonIntermedian.Name = "radioButtonIntermedian"
        Me.radioButtonIntermedian.Size = New System.Drawing.Size(124, 29)
        Me.radioButtonIntermedian.TabIndex = 2
        Me.radioButtonIntermedian.TabStop = True
        Me.radioButtonIntermedian.Text = "Intermedio"
        Me.radioButtonIntermedian.UseVisualStyleBackColor = True
        '
        'radioButtonHard
        '
        Me.radioButtonHard.AutoSize = True
        Me.radioButtonHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radioButtonHard.Location = New System.Drawing.Point(153, 194)
        Me.radioButtonHard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioButtonHard.Name = "radioButtonHard"
        Me.radioButtonHard.Size = New System.Drawing.Size(78, 29)
        Me.radioButtonHard.TabIndex = 3
        Me.radioButtonHard.TabStop = True
        Me.radioButtonHard.Text = "Dificil"
        Me.radioButtonHard.UseVisualStyleBackColor = True
        '
        'newGameButton
        '
        Me.newGameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.newGameButton.Location = New System.Drawing.Point(121, 244)
        Me.newGameButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.newGameButton.Name = "newGameButton"
        Me.newGameButton.Size = New System.Drawing.Size(149, 39)
        Me.newGameButton.TabIndex = 4
        Me.newGameButton.Text = "Nuevo Juego"
        Me.newGameButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1512, 1055)
        Me.Controls.Add(Me.newGameButton)
        Me.Controls.Add(Me.radioButtonHard)
        Me.Controls.Add(Me.radioButtonIntermedian)
        Me.Controls.Add(Me.radioButtonEasy)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Juego de Pares"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents radioButtonEasy As RadioButton
	Friend WithEvents radioButtonIntermedian As RadioButton
	Friend WithEvents radioButtonHard As RadioButton
	Friend WithEvents newGameButton As Button
End Class
