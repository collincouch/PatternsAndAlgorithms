let x = 2;
let y = 8;
const a = function (b) {
    //console.log('b:' + b);
    return function (c) {
        //console.log('x:' + x);
        //console.log('y:' + y);
        //console.log('b:' + b);
        //console.log('c:' + c);
        //console.log('abs B:' + Math.abs(b));
        return x + y + Math.abs(b) + c;
    };
};

//Statement will go here
y = 4;
const fn = a(x);
x = 4;
console.log(fn(Math.random() * 10));