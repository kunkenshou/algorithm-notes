Sub Selection_sort_0210()

Dim Minimum As Variant
Dim MinimumIndex As Variant
Dim X As Variant
Dim A As Variant
A = Array(3, 1, 4, 2)

Upper = UBound(A)

For I = 0 To Upper - 1

    'Debug.Print A(I)

    Minimum = A(I)
    MinimumIndex = I

For J = I + 1 To Upper

    If A(J) < Minimum Then

        Minimum = A(J)
        MinimumIndex = J

    End If

Next J

    If A(I) > Minimum Then
        X = A(I)
        A = Minimum
        'A(MinimumIndex) = X

    End If

Next I

End Sub
