/**
 * @param {string} s
 * @return {number}
 */

const romanValues = {
    I: 1,
    V: 5,
    X: 10,
    L: 50,
    C: 100,
    D: 500,
    M: 1000,
}

var romanToInt = function(s) {
    const arr = Array.from(s);

    const numersArr = arr.map((x, index) => {
        const currentValue = romanValues[x];
        const nextValue = romanValues[arr[index + 1]]
        const operation = currentValue < nextValue ?  '-' : '+'

        return `${operation}${currentValue}`

    }).join("")

    return eval(numersArr)
};