/**
 * @param {number[]} nums
 * @param {number} k
 * @param {number} multiplier
 * @return {number[]}
 */
var getFinalState = function(nums, k, multiplier) {
    let stack = nums;

    for(let i = 0; i < k; i++){
        let lowestValue = Infinity;
        let pos = 0;

        for ( let index = 0; index < stack.length; index++ ){
            const cn = stack[index];
            if (cn < lowestValue){
                lowestValue = cn;
                pos = index;
            }
        }
        
        stack[pos] = stack[pos] * multiplier

    }

    return stack;
};