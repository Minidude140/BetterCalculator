'Zachary Christensen
'RCET 2265
'Fall 2023
'Better Calculator
'https://github.com/Minidude140/BetterCalculator.git


Option Explicit On
Option Strict On

Module BetterCalculator

    Sub Main()

        'TODO
        '[~]Prompt user for a number and reflect back thier input
        '[~]Prompt user for a second number and reflect back both thier inputs
        '[~]Ask user if they would like to multiply or divide thier input
        '[~]Return computated value
        '[~]Prompt to exit program
        '[~]Update prompts to submission instructions
        '[~]Add Loop and Quit Functionality
        '[~]Add try catch exeption number one
        '[~]Add try catch exeption number two
        '[~]Add try catch exeption operation
        '[~]Add subract and Divide operations


        Dim exitFlag As Boolean = False
        Dim userInput As String
        Dim numberOne As Integer
        Dim numberTwo As Integer
        Dim operation As Integer

        Do
            Dim numOneLoop As Boolean = False
            Dim numTwoLoop As Boolean = False
            Dim operationLoop As Boolean = False

            Console.WriteLine("Please enter two numbers." & vbLf & "Enter Q at anytime to quit.")

            'First Number Aquisition
            Do While numOneLoop = False
                Console.WriteLine(vbLf & "Choose a Number: ")
                userInput = Console.ReadLine()
                Try
                    numberOne = CInt(userInput)
                    Console.WriteLine($"You entered: {userInput}." & vbLf)
                    numOneLoop = True
                Catch ex As Exception
                    If userInput = "q" Or userInput = "Q" Then
                        numOneLoop = True
                        numTwoLoop = True
                        operationLoop = True
                        exitFlag = True
                    Else
                        Console.WriteLine($"You entered: {userInput}, please enter a whole number.")
                    End If
                End Try
            Loop

            'Second Number Aquistion
            Do While numTwoLoop = False
                Console.WriteLine(vbLf & "Choose a Number: ")
                userInput = Console.ReadLine()
                Try
                    numberTwo = CInt(userInput)
                    Console.WriteLine($"You entered: {userInput}." & vbLf)
                    numTwoLoop = True
                Catch ex As Exception
                    If userInput = "q" Or userInput = "Q" Then
                        numOneLoop = True
                        numTwoLoop = True
                        operationLoop = True
                        exitFlag = True
                    Else
                        Console.WriteLine($"You entered: {userInput}, please enter a whole number.")
                    End If
                End Try
            Loop

            'Prompt, compute, Return
            Do While operationLoop = False
                Console.WriteLine("Choose one of the following options:" & vbLf & "1. Add" & vbLf & "2. Subtract" & vbLf & "3.Multiply" & vbLf & "4. Divide")
                userInput = Console.ReadLine()
                Try
                    operation = CInt(userInput)
                    Select Case operation
                            'Wrong input repeats loop
                        Case <= 0
                            Console.WriteLine($"You entered: {userInput}" & vbLf)
                            'Wrong input repeats loop
                        Case >= 5
                            Console.WriteLine($"You entered: {userInput}" & vbLf)
                            'Input within range exit loop
                        Case = 1
                            operationLoop = True
                            'Should not ever reach this point
                        Case Else
                            Console.WriteLine("This should not have happened...")
                    End Select
                Catch ex As Exception
                    If userInput = "q" Or userInput = "Q" Then
                        numOneLoop = True
                        numTwoLoop = True
                        operationLoop = True
                        exitFlag = True
                    Else
                        Console.WriteLine($"You entered: {userInput}" & vbLf)
                    End If
                End Try
            Loop
            Select Case operation

                     'Add two inputs
                Case = 1
                    Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}" & vbLf)
                    'Subtract one from two
                Case = 2
                    Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}" & vbLf)
                    'Multiply two inputs
                Case = 3
                    Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}" & vbLf)
                    'Divide one from two
                Case = 4
                    Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo}" & vbLf)
                    'Should not run this cases oustide range handled in the about try/catch
                Case Else
                    Console.WriteLine("This should not have happened...")
            End Select
        Loop Until exitFlag = True
        Console.WriteLine("You entered: q")
        Console.WriteLine("Have a nice day." & vbLf & "Press enter to close this window.")
        Console.Read()

    End Sub

End Module
