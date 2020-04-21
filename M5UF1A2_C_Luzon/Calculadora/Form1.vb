Public Class frm_Calculator
	'Main variables
	Private result As Double = 0
	Private displayText As String = ""
	Private currentText As String = ""
	Private Enum states
		EMPTY           'Aún no se ha introducido nada
		BEGINING        'La operación ya tiene al menos un número
		OPERATOR_USED   'Ya se puede operar la operación introducida (Tiene al menos 2 números con su operador)
	End Enum
	Private currentState As states = states.EMPTY

	'Button inputs' Es una función larga, pero no complicada:
	' En esta función se representan los 3 estados (Explicados arriba) y lo que se puede hacer en cada estado
	' Tiene en cuenta los datos introducido y si se puede hacer algo con ello.
	' Por ejemplo; no tiene sentido poder usar el equlas con algo así "1 / ", no hay nada con lo que operar. Se necesita al menos otro número.
	Private Sub buttons_Click(sender As Object, e As EventArgs) Handles btn_0.Click, btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click, btn_Clean.Click, btn_Delete.Click, btn_Div.Click, btn_Mult.Click, btn_Sub.Click, btn_Add.Click, btn_Equal.Click, btn_Coma.Click
		Select Case currentState
			Case states.EMPTY
				Select Case CType(sender, Button).Name
					Case Me.btn_0.Name
						UpdateFirst("0")
					Case Me.btn_1.Name
						UpdateFirst("1")
					Case Me.btn_2.Name
						UpdateFirst("2")
					Case Me.btn_3.Name
						UpdateFirst("3")
					Case Me.btn_4.Name
						UpdateFirst("4")
					Case Me.btn_5.Name
						UpdateFirst("5")
					Case Me.btn_6.Name
						UpdateFirst("6")
					Case Me.btn_7.Name
						UpdateFirst("7")
					Case Me.btn_8.Name
						UpdateFirst("8")
					Case Me.btn_9.Name
						UpdateFirst("9")
				End Select
			Case states.BEGINING
				Select Case CType(sender, Button).Name
					Case Me.btn_0.Name
						Update("0")
					Case Me.btn_1.Name
						Update("1")
					Case Me.btn_2.Name
						Update("2")
					Case Me.btn_3.Name
						Update("3")
					Case Me.btn_4.Name
						Update("4")
					Case Me.btn_5.Name
						Update("5")
					Case Me.btn_6.Name
						Update("6")
					Case Me.btn_7.Name
						Update("7")
					Case Me.btn_8.Name
						Update("8")
					Case Me.btn_9.Name
						Update("9")
					Case Me.btn_Clean.Name
						currentText = ""
						tb_Display.Text = ""
						currentState = states.EMPTY
					Case Me.btn_Delete.Name
						currentText = currentText.Remove(currentText.Length - 1)
						tb_Display.Text = currentText
					Case Me.btn_Div.Name
						Update(" / ")
						currentState = states.OPERATOR_USED
					Case Me.btn_Mult.Name
						Update(" * ")
						currentState = states.OPERATOR_USED
					Case Me.btn_Sub.Name
						Update(" - ")
						currentState = states.OPERATOR_USED
					Case Me.btn_Add.Name
						Update(" + ")
						currentState = states.OPERATOR_USED
					Case Me.btn_Coma.Name
						Update(",")
						currentState = states.OPERATOR_USED
					Case Me.btn_Equal.Name
						If (CanUseEquals()) Then
							CalculateResult(currentText)
						End If
				End Select
			Case states.OPERATOR_USED
				Select Case CType(sender, Button).Name
					Case Me.btn_0.Name
						UpdateOperatorUsed("0")
					Case Me.btn_1.Name
						UpdateOperatorUsed("1")
					Case Me.btn_2.Name
						UpdateOperatorUsed("2")
					Case Me.btn_3.Name
						UpdateOperatorUsed("3")
					Case Me.btn_4.Name
						UpdateOperatorUsed("4")
					Case Me.btn_5.Name
						UpdateOperatorUsed("5")
					Case Me.btn_6.Name
						UpdateOperatorUsed("6")
					Case Me.btn_7.Name
						UpdateOperatorUsed("7")
					Case Me.btn_8.Name
						UpdateOperatorUsed("8")
					Case Me.btn_9.Name
						UpdateOperatorUsed("9")
					Case Me.btn_Clean.Name
						currentText = ""
						tb_Display.Text = ""
						currentState = states.EMPTY
					Case Me.btn_Delete.Name
						currentText = currentText.Remove(currentText.Length - 3)
						tb_Display.Text = currentText
						currentState = states.BEGINING
				End Select
		End Select
	End Sub
	'Keyboard Inputs



	'-------------------------------------------------
	'Estas 4 funciones actualizan lo que se muestra en los text box de la operación superiro y el log historico de la inferior
	Private Function UpdateFirst(text As String)
		currentState = states.BEGINING
		currentText += text
		tb_Display.Text = currentText
	End Function
	Private Function UpdateOperatorUsed(text As String)
		currentState = states.BEGINING
		currentText += text
		tb_Display.Text = currentText
	End Function
	Private Function Update(text As String)
		currentText += text
		tb_Display.Text = currentText
	End Function
	Private Function UpdateResult(text As String)
		tb_Display.Text = currentText + text
		displayText += currentText + text + vbNewLine
		currentText = ""
		tb_Debug.Text = displayText
	End Function
	'-------------------------------------------------
	'Independientemente del número de operaciones, calcula todo en orden de inserción y obtiene un resultado (no hace distinción por prioridad matemática)
	Private Function CalculateResult(diplayerText As String)
		'Almacena todos los números y sus decimales en un array. De tal manera que los impares son números, y los pares son signos de operación.
		Dim parts As String() = currentText.Split(" ")
		Dim size As Integer = parts.Length
		'Se almace el primer número para despues, usando el bucle. Hacer un calculo con este número, el tipo de operación y el siguiente número
		result = Convert.ToDouble(parts(0))
		For index = 1 To size - 2
			If (parts(index).Equals("+")) Then
				result = Convert.ToDouble(result) + Convert.ToDouble(parts(index + 1))
			ElseIf (parts(index).Equals("-")) Then
				result = Convert.ToDouble(result) - Convert.ToDouble(parts(index + 1))
			ElseIf (parts(index).Equals("*")) Then
				result = Convert.ToDouble(result) * Convert.ToDouble(parts(index + 1))
			ElseIf (parts(index).Equals("/")) Then
				result = Convert.ToDouble(result) / Convert.ToDouble(parts(index + 1))
			End If
			index = index + 2
		Next
		UpdateResult(" = " + Convert.ToString(result))
	End Function
	'Comprueba si con la opeeración actual se puede operar
	Private Function CanUseEquals() As Boolean
		Dim length As Integer = currentText.Split(" ").Length
		If (length <= 2) Then
			Return False
		Else
			Return True
		End If
	End Function

	'Funcion para cambiar el tamaño de la venta y mostar el historial de calculos
	Private Sub btn_DD_Click(sender As Object, e As EventArgs) Handles btn_DD.Click
		'269; 674
		'269; 480
		If (Me.Size.Height <= 480) Then
			Me.btn_DD.Text = "V"
			Me.Size = New Size(Me.Size.Width, 674)
		ElseIf (Me.Size.Height >= 674) Then
			Me.btn_DD.Text = "^"
			Me.Size = New Size(Me.Size.Width, 480)
		End If
	End Sub

End Class
