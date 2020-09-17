''
''
''' <summary>
''' Unit testing of the Addition module.  
''' </summary>

''---Imports System.Diagnostics ''Added 9/16/2020 thomas downes
Imports NUnit.Framework ''Added 9/16/2020 thomas downes

Module modTestingAddition

    Public Sub TestSpacePlusSpace() ''As Boolean
        ''----Public Function TestSpacePlusSpace() As Boolean

        ''Return a value of True if successful. 
        ''
        Dim charDigitResult As Char
        Dim boolCarryThe1 As Boolean
        Dim strMessage As String = ""

        charDigitResult = modAddingDecs_Char.AddDecDigits_ByArrays(" ", " ", boolCarryThe1, strMessage)

        ''----Return (charDigitResult = " " And boolCarryThe1 = False)
        Dim result = (charDigitResult = " " And boolCarryThe1 = False)

        ''
        ''   https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
        ''
        Assert.IsTrue(result, "Two blank characters should produce a blank character.")

    End Sub ''End of "Public Function TestSpacePlusSpace() As Boolean"

    Public Sub TestSpacePlusDigitTwo() ''As Boolean
        ''----Public Function TestSpacePlusSpace() As Boolean
        ''
        ''Return a value of True if successful. 
        ''
        Dim charDigitResult As Char
        Dim boolCarryThe1 As Boolean
        Dim strMessage As String = ""

        charDigitResult = modAddingDecs_Char.AddDecDigits_ByArrays(" ", "2"c, boolCarryThe1, strMessage)

        ''----Return (charDigitResult = " " And boolCarryThe1 = False)
        Dim result = (charDigitResult = "2"c And boolCarryThe1 = False)

        ''
        ''   https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
        ''
        Assert.IsTrue(result, "Space plus 2 should produce a 2 (two).")
        Assert.IsTrue(result, strMessage)

    End Sub ''End of "Public Function TestSpacePlusDigit2() As Boolean"

    Public Sub TestTwoPlusDigitThree() ''As Boolean
        ''----Public Function TestSpacePlusSpace() As Boolean
        ''
        ''Return a value of True if successful. 
        ''
        Dim charDigitResult As Char
        Dim boolCarryThe1 As Boolean
        Dim strMessage As String = ""

        charDigitResult = modAddingDecs_Char.AddDecDigits_ByArrays("2"c, "3"c, boolCarryThe1, strMessage)

        ''----Return (charDigitResult = " " And boolCarryThe1 = False)
        Dim result = (charDigitResult = "5"c And boolCarryThe1 = False)

        ''
        ''   https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
        ''
        Assert.IsTrue(result, "2 plus 3 should produce a 5 (five).")
        Assert.IsTrue(result, strMessage)

    End Sub ''End of "Public Function TestTwoPlusDigitThree() As Boolean"

    Public Sub TestFivePlusDigitSix() ''As Boolean
        ''----Public Function TestSpacePlusSpace() As Boolean
        ''
        ''   Return a value of True if successful. 
        ''
        Dim charDigitResult As Char
        Dim boolCarryThe1 As Boolean
        Dim strMessage As String = ""

        charDigitResult = modAddingDecs_Char.AddDecDigits_ByArrays("5"c, "6"c, boolCarryThe1, strMessage)

        ''----Return (charDigitResult = " " And boolCarryThe1 = False)
        Dim result = (charDigitResult = "1"c And boolCarryThe1 = True)

        ''
        ''   https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
        ''
        Assert.IsTrue(result, "5 plus 6 should produce a 1 (one) and a Carry = True.")
        Assert.IsTrue(result, strMessage)

    End Sub ''End of "Public Function TestFivePlusDigitSix() As Boolean"

End Module
