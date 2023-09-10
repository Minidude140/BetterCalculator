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
        '[1/2]Add Loop and Quit Functionality
        '[~]Add try catch exeption number one
        '[~]Add try catch exeption number two
        '[]Add try catch exeption operation
        '[]Add subract and Divide operations


        Dim userInput As String
        Dim numberOne As Integer
        Dim numberTwo As Integer
        Dim operation As String
        Dim exitFlag As Boolean = False
        Dim numOneLoop As Boolean = False
        Dim numTwoLoop As Boolean = False
        Dim operationLoop As Boolean = False

        Do While exitFlag = False
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

            [operation] = CStr(userInput)

            'Prompt, Compute, and Return
            Console.WriteLine("Would you like to add or multiply these two numbers?" & vbLf & "Please enter '+' or '*'")
            userInput = Console.ReadLine()

            'Determine Desired Operation
            If (operation = "+") Then
                'Add
                Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}" & vbLf)
            ElseIf (operation = "*") Then
                'Multiply
                Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}" & vbLf)
            Else
                'not multiply or add
                Console.WriteLine($"{numberOne} {userInput} {numberTwo} = ???" & vbLf & "I don't know that kind of math." & vbLf)
            End If

            'End greeting and exit
        Loop
        Console.Read()

    End Sub

End Module
