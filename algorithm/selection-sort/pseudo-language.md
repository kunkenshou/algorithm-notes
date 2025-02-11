配列の最初の要素のインデックス値は「０」

A←[3,1,4,2]

Minimum←Ａ（0）
MinimumMiniIndex←0


繰り返し　I←1　から　4 - 1　まで

もし　Minimum　＞　Ａ（I）なら

　Minimum ← A（I）
　MinimumMiniIndex ← I

  Ｘ←Ａ（Ｉ）
  Ａ（Ｉ）←Minimum
  Ａ（MinimumIndex）←X

繰り返し　終了