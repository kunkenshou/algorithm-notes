
配列のインデックス値は0から始まる

A　←　[3,1,4,2]
N　←　（配列の最後のインデックス値）


繰り返し  I ←　0 から　N ー１ まで

	Minimum　← A（I）
	MiniIndex ← I

繰り返し J ← I + 1 から　N まで

	もし　A(J)　＜　Minimum なら
	Minimum　← A(J)
	MiniIndex ← J

終了 繰り返し
	
	もし 　A（I）　＞　Minimum　なら

	X　←　A（I）
　　　　A（I）← Minimum
	A（MiniIndex）←　X


終了 繰り返し


結果

A　←　[1,2,3,4]