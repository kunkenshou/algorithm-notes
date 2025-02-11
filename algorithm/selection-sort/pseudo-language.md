配列の最初の要素のインデックス値は「０」

A←[3,1]


Minimum　←　A(0)
MinimumIndex  ← 0

繰り返し　J ← 0 から 2 - 1 まで

繰り返し　I ← 1 から 2 まで 

もし Minimum ＞ A(I) なら
　Minimum　←　A（I）
　MinimumIndex　←　I

終了　繰り返し

X ← Ａ（J）
A(J) ← Minimum
A(MinimumIndex) ← Ｘ

終了 繰り返し