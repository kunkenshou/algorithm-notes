Sub SelectionSort()

Dim A As Variant
Dim X As Integer
Dim Z As Integer
Dim Lower As Integer
Dim Upper As Integer
Dim Mini As Integer
Dim MiniIndex As Integer

A = Array(2, 1, 3, 4, 6, 5, 9, 8, 10)

Lower = LBound(A)
Upper = UBound(A)

Mini = A(0)
MiniIndex = Lower

For I = Lower To Upper - 1

    For J = Lower To Upper
        If Mini > A(J) Then
            Mini = A(J)
            MiniIndex = J
        End If
    Next J
    
    If A(0) > A(I) Then
         X = A(I)
         A(MiniIndex) = X
         A(0) = Mini
    End If
    
    If A(I) > A(I + 1) Then
         Z = A(I)
         A(I) = A(I + 1)
         A(I + 1) = Z
    End If
Next I

'    Debug.Print A(0)
    For N = Lower To Upper
        Debug.Print A(N)
    Next N
    
End Sub