'Laura Riley
'RCET0265
'Spring 2021
'Better Calculator
'

Option Strict On
Option Explicit On
Module BetterCalculator

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim finalAnswer As Double
        Dim userinput As String = ""
        Dim mathFunction As String = ""
        Dim programRun As Boolean = True
        Dim problem As Boolean = True

        While programRun = True And userinput <> "Q" And userinput <> "q"
            Console.WriteLine("Enter ""Q"" at any time to quit" & vbCrLf)
            While problem = True And userinput <> "Q" And userinput <> "q"
                Console.WriteLine("Choose a Number:")
                Try
                    userinput = Console.ReadLine()
                    firstNumber = CInt(userinput)
                    problem = False
                Catch
                    Console.WriteLine(vbCrLf & $"You entered ""{firstNumber}""" & vbCrLf)
                    problem = True
                End Try
            End While

            problem = True

            While problem = True And userinput <> "Q" And userinput <> "q"
                Console.WriteLine("Choose a Number:")
                Try
                    userinput = Console.ReadLine()
                    secondNumber = CInt(userinput)
                    problem = False
                Catch
                    Console.WriteLine(vbCrLf & $"You entered ""{secondNumber}""" & vbCrLf)
                    problem = True
                End Try
            End While

            If userinput = "Q" Or userinput = "q" Then
                Console.Clear()
                Console.WriteLine("Have a nice day" & vbCrLf & "Press enter to close this window")
                programRun = False
            End If

            problem = True

            While problem = True And userinput <> "Q" And userinput <> "q"
                Console.WriteLine("Choose one of the following options:" & vbCrLf)
                Console.WriteLine("1. Add" & vbCrLf & "2. Subtract" & vbCrLf & "3. Multiply" & vbCrLf & "4. Divide")
                Try
                    userinput = Console.ReadLine()
                    mathFunction = userinput
                    If mathFunction = "1" Or mathFunction = "2" Or mathFunction = "3" Or mathFunction = "4" Then
                        problem = False
                    Else
                    End If
                Catch ex As Exception
                    Console.WriteLine($"You entered ""{userinput}""")
                    problem = True
                End Try
            End While

            Console.Clear()

            If userinput = "Q" Or userinput = "q" Then
                Console.Clear()
                Console.WriteLine("Have a nice day." & vbCrLf & "Press enter to close this window")
                programRun = False
            End If

            If mathFunction = "1" Then
                finalAnswer = firstNumber + secondNumber
                Console.WriteLine($"{firstNumber} + {secondNumber} = {finalAnswer}" & vbCrLf)
            ElseIf mathFunction = "2" Then
                finalAnswer = firstNumber - secondNumber
                Console.WriteLine($"{firstNumber} - {secondNumber} = {finalAnswer}" & vbCrLf)
            ElseIf mathFunction = "3" Then
                finalAnswer = firstNumber * secondNumber
                Console.WriteLine($"{firstNumber} * {secondNumber} = {finalAnswer}" & vbCrLf)
            ElseIf mathFunction = "4" Then
                finalAnswer = CDbl(firstNumber) / CDbl(secondNumber)
                Console.WriteLine($"{firstNumber} / {secondNumber} = {finalAnswer}" & vbCrLf)
            End If

            If userinput = "Q" Or userinput = "q" Then
                Console.Clear()
                Console.WriteLine("Have a nice day." & vbCrLf & "Press enter to close this window")
                programRun = False
            End If

            problem = True
        End While

        Console.Read()
    End Sub

End Module
