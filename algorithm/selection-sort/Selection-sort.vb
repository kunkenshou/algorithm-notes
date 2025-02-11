Sub Main()

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

    For I = Lower To Upper - 1
        Mini = A(0)
        MiniIndex = Lower

        If Mini > A(I) Then
            Mini = A(I)
            MiniIndex = I
        End If

        X = A(0)
        A(0) = Mini
        A(MiniIndex) = X

        If A(I) > A(I + 1) Then
             Z = A(I + 1)
             A(I + 1) = A(I)
             A(I) = Z
        End If
    Next I

    For N = Lower To Upper
        Debug.Print A(N)
    Next N

End Sub