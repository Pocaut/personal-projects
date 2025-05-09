//solution for the 1 - Two Sum problem on LeetCode
const nums = [2,7,11,15];
const target = 9;

function twoSum(nums, target) {

for (i = 0;i <= 2;i++) {
let sum = nums[i] + nums[i + 1];

for (let i = 0; i < nums.length; i++) {
    for (let j = i + 1; j < nums.length; j++) {
      if (nums[i] + nums[j] === target) {
        return [i, j];
      }
    }
  }
}
};


console.log(twoSum(nums, target));
