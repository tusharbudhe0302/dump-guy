/**Given a list of dominoes, dominoes[i] = [a, b] is equivalent to dominoes[j] = [c, d] if and only if either (a==c and b==d), or (a==d and b==c) - that is, one domino can be rotated to be equal to another domino.

Return the number of pairs (i, j) for which 0 <= i < j < dominoes.length, and dominoes[i] is equivalent to dominoes[j].

Example 1:
Input: dominoes = [[1,2],[2,1],[3,4],[5,6]]
Output: 1
Constraints:
1 <= dominoes.length <= 40000
1 <= dominoes[i][j] <= 9
 */

/**
* @param {number[][]} dominoes
* @return {number}
*/
var numEquivDominoPairs = function (dominoes) {
    let arr = Array(100).fill(0), pairCount = 0;
    for (const d of dominoes) {
        const num = d[0] < d[1] ? d[0] * 10 + d[1] : d[1] * 10 + d[0];
        pairCount += arr[num];
        arr[num]++;
        console.log(`num : ${num} pairCount: ${pairCount} arr : ${arr}`);
    }

    return pairCount;
};
