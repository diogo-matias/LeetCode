/**
 * @param {string[]} words
 * @return {string[]}
 */
var stringMatching = function(words) {
    const result = [];

    for (let i = 0; i < words.length ** 2; i++){
        const loop =  Math.floor(i / words.length);
        const itemIndex = i % words.length;

        if (loop === itemIndex){
            continue;
        }

        const currentItem = words[itemIndex];
        const currentLoopItem = words[loop];

        const isSubstring = currentLoopItem.includes(currentItem);
        
        if (isSubstring) {
            const alreadyAdded = result.includes(currentItem);

            if (!alreadyAdded){
                result.push(currentItem);
            }
          
        }
    }

     return result;  
};