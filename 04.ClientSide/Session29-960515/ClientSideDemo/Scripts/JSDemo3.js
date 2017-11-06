(function () {
    //Object
    //1. JSON JavaScript Object Notation

    //var person =
    //    {
    //        name: "John",
    //        family: "Doe",
    //        age: 40,
    //        address: {
    //            city: "Tehran",
    //            street: "Ebn Sina",
    //            postalCode : "1234567890"
    //        },
    //        programmingLanguages: ["C#", "Java", "PHP"],
    //        writeMyName: function () {
    //            console.log(this.name + " " + this.family);
    //        }
    //    };
    //console.log(person);
    //console.log(person.name);
    //console.log(person.address.city);
    //person.writeMyName();

    //person.nationalCode = "1234567890";
    //console.log(typeof person);


    //var person = new Object();
    //person.name = "John";
    //person.family = "Doe";

    //console.log(person.name);
    //console.log(person.family);

    //var person = {};


    function Person()//constructor
    {
        this.name = "";
        this.family = "";
        this.age = 0;
        var birthDate = "";
        console.log("Function is invoked");
    }

    var john = new Person();
    john.name = "John";
    john.family = "Doe";
    john.age = 40;

    var sarah = new Person();
    sarah.name = "Sarah";
    sarah.family = "Doe";
    sarah.age = 40;


    Person();
})();