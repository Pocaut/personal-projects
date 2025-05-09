let digits = [1, 2, 3];

function plusOne(array) {
    for (let i = array.length - 1; i >= 0; i--) {
        if (array[i] === 9) {
            array[i] = 0;
        } else {
            array[i]++;
            return array;
        }
    }

    array.unshift(1);
    return array;
};

plusOne(digits);
console.log(digits);