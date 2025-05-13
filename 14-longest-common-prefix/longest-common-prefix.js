/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function(strs) {
    let run = true
    let i = 0
    let i2 = 0
    let stack = []
    let result = ""

    while (run){
        if (i >= strs.length){
            if (stack.length !== strs.length) break

            i = 0
            i2++
            result += stack[0];
            stack = [];
        }

        const l = strs?.[i]?.[i2]

        if (!l){
            break
        }

        if (stack[stack.length -1] === l){
            stack.push(l);
        } 
        else if (i === 0){
            stack.push(l);
        }

        i++
    }

    return result

};