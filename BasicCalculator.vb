Option Explicit On
Option Strict On

'Dylan Nelson
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/dylannelson58/basiccalculator

Module BasicCalculator

    Sub Main()

        Dim firstNumber As Decimal
        Dim secondNumber As Decimal
        Dim thirdNumber As Decimal

        Console.WriteLine("Enter a number!")
        firstNumber = CDec(Console.ReadLine())
        Console.WriteLine("Enter another number!")
        secondNumber = CDec(Console.ReadLine())

        Console.WriteLine("You entered " & firstNumber & " and " & secondNumber & ".")
        Console.WriteLine("Would you like to add or multiply these numbers?")
        Console.WriteLine("1 for addition, 2 for multiplication.")
        thirdNumber = CDec(Console.ReadLine)

        If thirdNumber = 1 Then
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
        End If

        If thirdNumber = 2 Then
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
        End If

        If thirdNumber > 2 Then
            Console.WriteLine("Please enter 1 or 2 next time.")
        End If

        Console.WriteLine("Operation complete, have a good day.")

        Console.Read()


    End Sub

End Module
