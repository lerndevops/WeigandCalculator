Option Explicit On ''Added 6/25/2019 thomas d. 
Option Strict On ''Added 6/25/2019 thomas d. 
''
''' <summary>
''' This is for shared functions and procedures.   (module modUtilities)  ----Added 6/25/2019  td 
''' </summary>

Module modUtilities

    Public Structure VB6_ArrayWithLowerBound ''Added 6/25/2019
        Dim array_ofStrings() As String ''added 6/25/2019 & 7/02/2016
        Dim lowerBound As Integer ''Added 6/25/2019
        Dim upperBound As Integer ''Added 6/25/2019
    End Structure

    Public Sub ReDim_VB6(ByRef par_array As VB6_ArrayWithLowerBound, par_intLowerBound As Integer, par_intUpperBound As Integer)
        ''
        ''Added 6/25/2019 td
        ''
        ''  This is overloaded. 
        ''
        par_array.lowerBound = par_intLowerBound ''Added 6/25/2019 td
        par_array.upperBound = par_intUpperBound ''Added 6/25/2019 td

        ReDim par_array.array_ofStrings(par_intUpperBound)

        ''
        ''Caution against using the lower indices.  
        ''
        Dim intIndex As Integer
        For intIndex = 0 To (par_intLowerBound - 1)
            ''par_array(intIndex) = "This VB6/VBA array out of bounds!"
            par_array.array_ofStrings(intIndex) = "Array out of bounds!"
        Next intIndex

    End Sub ''End of "Public Sub ReDim_VB6(mod_arrayPowersOf16_Dec, static_intLBound, static_intLBound)"

    Public Sub ReDim_VB6(ByRef par_array As String(), par_intLowerBound As Integer, par_intUpperBound As Integer)
        ''
        ''Added 6/25/2019 td
        ''
        ''  This is overloaded. 
        ''
        ReDim par_array(par_intUpperBound)

        ''
        ''Caution against using the lower indices.  
        ''
        Dim intIndex As Integer
        For intIndex = 0 To (par_intLowerBound - 1)
            ''par_array(intIndex) = "This VB6/VBA array out of bounds!"
            par_array(intIndex) = "Array out of bounds!"
        Next intIndex

    End Sub ''End of "Public Sub ReDim_VB6(mod_arrayPowersOf16_Dec, static_intLBound, static_intLBound)"

    Public Sub ReDim_VB6_Preserve(ByRef par_array As VB6_ArrayWithLowerBound, par_intLowerBound As Integer, par_intUpperBound As Integer)
        ''
        ''Added 6/25/2019 td
        ''
        ''  This is overloaded. 
        ''
        par_array.lowerBound = par_intLowerBound ''Added 6/25/2019 td
        par_array.upperBound = par_intUpperBound ''Added 6/25/2019 td

        ReDim Preserve par_array.array_ofStrings(par_intUpperBound)

        ''
        ''Caution against using the lower indices.  
        ''
        Const c_boolClearOuterLowerIndexItems As Boolean = False ''Not needed, and goes against the "Preserve" concept. 

        If (c_boolClearOuterLowerIndexItems) Then
            Dim intIndex As Integer
            For intIndex = 0 To (par_intLowerBound - 1)
                ''par_array(intIndex) = "This VB6/VBA array out of bounds!"
                par_array.array_ofStrings(intIndex) = "Array out of bounds!"
            Next intIndex
        End If ''End of "If (c_boolClearOuterLowerIndexItems) Then"

    End Sub ''End of "Public Sub ReDim_VB6(mod_arrayPowersOf16_Dec, static_intLBound, static_intLBound)"

    Public Sub ReDim_VB6_Preserve(ByRef par_array As String(), par_intLowerBound As Integer, par_intUpperBound As Integer)
        ''
        ''Added 6/25/2019 td
        ''
        ''  This is overloaded. 
        ''
        ReDim Preserve par_array(par_intUpperBound)

        ''
        ''Caution against using the lower indices.  
        ''
        Const c_boolClearOuterLowerIndexItems As Boolean = False ''Not needed, and goes against the "Preserve" concept. 

        If (c_boolClearOuterLowerIndexItems) Then
            Dim intIndex As Integer
            For intIndex = 0 To (par_intLowerBound - 1)
                ''par_array(intIndex) = "This VB6/VBA array out of bounds!"
                par_array(intIndex) = "Array out of bounds!"
            Next intIndex
        End If ''End of "If (c_boolClearOuterLowerIndexItems) Then"

    End Sub ''End of "Public Sub ReDim_VB6(mod_arrayPowersOf16_Dec, static_intLBound, static_intLBound)"

End Module
