# bubble_sort

## 手順
[左の要素と右の要素を比較して交換を繰り返す]
# 繰り返す範囲
  　1.１周目
    ・実際に比較すべき範囲「要素のインデックス値「0～3」範囲」
    2.２週目
    ・実際に比較すべき範囲「要素のインデックス値「0～2」の範囲」
    3.３週目
    ・実際に比較すべき範囲「要素のインデックス値「0～1」の範囲」

# 交換する条件
もし、左の要素が右の要素より大きいとき交換
もし、左の要素が右の要素より小さいときはそのまま

# 具体例
配列の初期値＝ [7,1,8,2]

# １周目（左から右へ）　
1. 左[7]と右[1]比較　→　交換　→　結果[1,7,8,2]
2. 左[7]と右[8]比較　→　そのまま　→　結果[1,7,8,2]
3. 左[8]と右[2]比較　→　交換　→　結果[1,7,2,8]
ソートして右端の最大値[8]が確定

# ２周目（左から右へ）　
1. 左[1]と右[7]比較　→　そのまま　→　結果[1,7,2,8]
2. 左[7]と右[2]比較　→　交換　→　結果[1,2,7,8]
ソートして右端の最大値[7]が確定

# ３周目（左から右へ）
1. 左[1]と右[2]比較　→　そのまま　→　結果[1,2,7,8]
「2番目の最小値[2]の位置が確定」
「最後の比較が不要であることが確認できたため、ソートが完了」
