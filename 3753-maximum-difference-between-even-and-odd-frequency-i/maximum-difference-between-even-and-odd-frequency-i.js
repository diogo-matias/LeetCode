/**
 * @param {string} s
 * @return {number}
 */
var maxDifference = function(s) {
     const freq = {};
    for (const char of s) {
        freq[char] = (freq[char] || 0) + 1;
    }
    
    const oddFreqs = [];
    const evenFreqs = [];
    
    for (const key in freq) {
        const count = freq[key];
        if (count % 2 === 1) {
            oddFreqs.push(count);
        } else {
            evenFreqs.push(count);
        }
    }
    
    if (oddFreqs.length === 0 || evenFreqs.length === 0) {
        return 0;
    }
    
    const maxOdd = Math.max(...oddFreqs);
    const minEven = Math.min(...evenFreqs);
    
    return maxOdd - minEven;
};