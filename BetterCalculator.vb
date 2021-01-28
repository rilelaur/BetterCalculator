'Laura Riley
'RCET0265
'Spring 2021
'Better Calculator
'https://github.com/rilelaur/BetterCalculator.git

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

        'Outer while loop keeps the program running until the user ends it
        While programRun = True And userinput <> "Q" And userinput <> "q"

            'Tells the user they can enter Q to quit
            Console.WriteLine("Enter ""Q"" at any time to quit" & vbCrLf)

            'Prompts the user to enter a number and makes sure that they enter a number and haven't quit.
            'If the user didn't enter a number then it will prompt the user again.
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

            'Prompts the user to enter a number and makes sure that they enter a number and haven't quit.
            'If the user didn't enter a number then it will prompt the user again.
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

            'If the user has entered Q the program will clear and tell them to have a nice day and to press enter to exit
            If userinput = "Q" Or userinput = "q" Then
                Console.Clear()
                Console.WriteLine("Have a nice day" & vbCrLf & "Press enter to close this window")
                programRun = False
            End If

            problem = True

            'Prompts the user to enter a number from 1 to 4 and makes sure that they enter a number and haven't quit.
            'If they didn't enter 1, 2, 3, or 4 it will prompt the user again
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

            'clears the math function
            Console.Clear()

            'If the user has entered Q the program will clear and tell them to have a nice day and to press enter to exit
            If userinput = "Q" Or userinput = "q" Then
                Console.Clear()
                Console.WriteLine("Have a nice day." & vbCrLf & "Press enter to close this window")
                programRun = False
            End If

            'If the user chose 1, 2, 3, or 4 the program will do the math associated with what they chose
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

            'If the user has entered Q the program will clear and tell them to have a nice day and to press enter to exit
            If userinput = "Q" Or userinput = "q" Then
                Console.Clear()
                Console.WriteLine("Have a nice day." & vbCrLf & "Press enter to close this window")
                programRun = False
            End If

            'Turns problem true if the user hasn't quit and will run the program again.
            problem = True
        End While

        Console.Read()
    End Sub

End Module
