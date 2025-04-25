/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    const a = x.toString()
    const b = [...x.toString()].reverse().join('')

    return a === b
};