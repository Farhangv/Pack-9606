(function () {
    console.log(1 == '1');
    console.log(1 === '1');

    if (typeof age == 'undefined')
        console.log("Age is not defined");
    var age = 0;
    if (!age)
        console.log('true');

    //Array
    //var names = ["C#", "Java", "PHP"];
    //var names = new Array();
    var names = [];
    names[0] = "C#";
    names[1] = "Java";
    names.push("PHP");
    console.log(typeof names);
    for (var i = 0; i < names.length; i++) {
        console.log(names[i]);
    }


    var data = 1;
    console.log(data);
    data = "Hello";
    console.log(data);

    console.log(names.pop());
    for (var i = 0; i < names.length; i++) {
        console.log(names[i]);
    }

})();