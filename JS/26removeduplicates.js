// Solution for the 26 - Remove Duplicates from Sorted Array problem on LeetCode
let nums = [0,0,1,1,1,2,2,3,3,4];

function removeDuplicates(nums) {
    for (let i = 0; i < nums.length; i++) {
        for (let j = i + 1; j < nums.length; j++) {
            if (nums[i]===nums[j]){
                nums.splice(j, 1);
                j--;
            }
        }
    }
};

removeDuplicates(nums);
let k = nums.length;
console.log(k);
