/**
 * @param {number[]} nums
 * @return {boolean}
 */
var isArraySpecial = function(nums) {
    for(let i = 0; i < nums.length -1; i++){
        const c1 = nums[i];
        const c2 = nums[i+1];

        if (isEven(c1) === isEven(c2)){
            return false;
        }
    }

    return true;
};

var isEven = (num) => {
    return num % 2 === 0;
}