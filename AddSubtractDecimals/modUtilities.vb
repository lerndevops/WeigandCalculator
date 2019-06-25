Option Explicit On ''Added 6/25/2019 thomas d. 
Option Strict On ''Added 6/25/2019 thomas d. 
''
''' <summary>
''' This is for shared functions and procedures.   (module modUtilities)  ----Added 6/25/2019  td 
''' </summary>

Module modUtilities

    Public Sub ReDim_VB6(par_array As String(), par_intLowerBound As Integer, par_intUpperBound As Integer)
        ''
        ''Added 6/25/2019 td
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

    Public Sub ReDim_VB6_Preserve(par_array As String(), par_intLowerBound As Integer, par_intUpperBound As Integer)
        ''
        ''Added 6/25/2019 td
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
