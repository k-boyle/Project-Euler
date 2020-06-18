function sequence(n) {
    //ulam spiral
    return 4 * n * n - 6 * (n - 1)
}

let n = 1
for (i = 3; i <= 1001; n += sequence(i), i += 2);

console.log(n)