''
''
''' <summary>
''' Unit testing of the Addition module.  
''' </summary>

''---Imports System.Diagnostics ''Added 9/16/2020 thomas downes
Imports NUnit.Framework ''Added 9/16/2020 thomas downes

Module modTestingSubtraction

    Public Sub TestSpaceMinusSpace_ReturnSpace() ''As Boolean
        ''----Public Function TestSpacePlusSpace() As Boolean

        ''Return a value of True if successful. 
        ''
        Dim charDigitResult As Char
        Dim boolBorrow10 As Boolean
        Dim strMessage As String = ""

        charDigitResult = mod_SubtractDecs_Char.SubDecDigits_ByArrays(" ", " ", boolBorrow10, strMessage)

        ''----Return (charDigitResult = " " And boolBorrow10 = False)
        Dim result = (charDigitResult = " " And boolBorrow10 = False)

        ''
        ''   https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
        ''
        Assert.IsTrue(result, "Two blank characters should produce a blank character.")

    End Sub ''End of "Public Function TestSpacePlusSpace() As Boolean"

    Public Sub TestFiveSubtractSpace_Return5() ''As Boolean
        ''----Public Function TestSpacePlusSpace() As Boolean
        ''
        ''Return a value of True if successful. 
        ''
        Dim charDigitResult As Char
        Dim boolBorrow10 As Boolean
        Dim strMessage As String = ""

        charDigitResult = mod_SubtractDecs_Char.SubDecDigits_ByArrays("5"c, " "c, boolBorrow10, strMessage)

        ''----Return (charDigitResult = " " And boolBorrow10 = False)
        Dim result = (charDigitResult = "5"c And boolBorrow10 = False)

        ''
        ''   https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
        ''
        Assert.IsTrue(result, "Digit Five minus Space character should produce a digit 5 (five).")
        Assert.IsTrue(result, strMessage)

    End Sub ''End of "Public Function TestFiveSubtractSpace() As Boolean"

    Public Sub TestThreeMinusDigitTwo_ReturnOne() ''As Boolean
        ''----Public Function TestSpacePlusSpace() As Boolean
        ''
        ''Return a value of True if successful. 
        ''
        Dim charDigitResult As Char
        Dim boolBorrow10 As Boolean
        Dim strMessage As String = ""

        charDigitResult = mod_SubtractDecs_Char.SubDecDigits_ByArrays("3"c, "2"c, boolBorrow10, strMessage)

        ''----Return (charDigitResult = " " And boolBorrow10 = False)
        Dim result = (charDigitResult = "1"c And boolBorrow10 = False)

        ''
        ''   https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
        ''
        Assert.IsTrue(result, "3 minus 2 should produce a 1 (one).")
        Assert.IsTrue(result, strMessage)

    End Sub ''End of "Public Function TestThreeMinusDigitTwo_ReturnOne() As Boolean"

    Public Sub TestNineSubDigitSix_ReturnThree() ''As Boolean
        ''----Public Function TestSpacePlusSpace() As Boolean
        ''
        ''   Return a value of True if successful. 
        ''
        Dim charDigitResult As Char
        Dim boolBorrow10 As Boolean
        Dim strMessage As String = ""

        charDigitResult = mod_SubtractDecs_Char.SubDecDigits_ByArrays("9"c, "6"c, boolBorrow10, strMessage)

        ''----Return (charDigitResult = " " And boolCarryThe1= False)
        Dim result = (charDigitResult = "3"c And boolBorrow10 = False)

        ''
        ''   https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
        ''
        Assert.IsTrue(result, "9 minus 6 should produce a 3 (three) and a Borrow10 = False.")
        Assert.IsTrue(result, strMessage)

    End Sub ''End of "Public Function TestNineSubDigitSix_ReturnThree() As Boolean"

    Public Sub TestSixSubDigitSeven_ReturnNine() ''As Boolean
        ''
        ''   Return a value of True if successful. 
        ''
        Dim charDigitResult As Char
        Dim boolBorrow10 As Boolean
        Dim strMessage As String = ""

        charDigitResult = mod_SubtractDecs_Char.SubDecDigits_ByArrays("6"c, "7"c, boolBorrow10, strMessage)

        Dim result = (charDigitResult = "9"c And boolBorrow10 = True)

        ''
        ''   https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
        ''
        Assert.IsTrue(result, "6 (>> 16) minus 7 should produce (>> 9) (nine after borrowing & subtracting) and a Borrow10 = True.")
        Assert.IsTrue(result, strMessage)

    End Sub ''End of "Public Function TestSixSubDigitSeven_ReturnNine() As Boolean"

    Public Sub TestZeroSubDigit7_ReturnThree() ''As Boolean
        ''
        ''   Return a value of True if successful. 
        ''
        Dim charDigitResult As Char
        Dim boolBorrow10 As Boolean
        Dim strMessage As String = ""

        charDigitResult = mod_SubtractDecs_Char.SubDecDigits_ByArrays("0"c, "7"c, boolBorrow10, strMessage)

        Dim result = (charDigitResult = "3"c And boolBorrow10 = True)

        ''
        ''   https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
        ''
        Assert.IsTrue(result, "0 (>> 10) minus 7 should produce (>> 3) (three after borrowing & subtracting) and a Borrow10 = True.")
        Assert.IsTrue(result, strMessage)

    End Sub ''End of "Public Function TestZeroSubDigit7_ReturnNine() As Boolean"

End Module
