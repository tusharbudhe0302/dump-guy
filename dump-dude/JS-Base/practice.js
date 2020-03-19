let matrix = [
    [1, 2, 3, 4],
    [5, 6, 7, 8],
    [9, 10, 11, 12],
    [13, 14, 15, 16]
]
// let matrix = [
//     [1, 2, 3],
//     [4, 5, 6],
//     [7, 8, 9]
// ]

function rotate90degrees(matrix) {
    let n = matrix.length;
    let x = Math.floor(n / 2);
    let y = n - 1;
    for (let i = 0; i < x + 1; i++) {
        for (let j = i; j < y - i; j++) {
            console.log(`Before Iteration I: ${i} J: ${j} matrix ${matrix}`);
            let k = matrix[i][j];
            matrix[i][j] = matrix[y - j][i];
            matrix[y - j][i] = matrix[y - i][y - j];
            matrix[y - i][y - j] = matrix[j][y - i];
            matrix[j][y - i] = k;
            console.log(`After Iteration I: ${i} J: ${j} matrix ${matrix}`);

        }
    }
}
rotate90degrees(matrix);
console.log(matrix);