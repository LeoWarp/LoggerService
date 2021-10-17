function checkPassword() {
    let colorDivs;
    const password = document.getElementById('inp_2').value;
    let sameSymbols = 0;
    let specialCharacters = 0;

    if (password.length !== 0) {
        let i;
        colorDivs = document.getElementsByClassName("demo4");
        colorDivs[0].style.backgroundColor = "#00fc54";
        document.getElementById("demo4").innerHTML = "Пароль не пустой";

        for (i = 0; i <= password.length; i++) {
            if (password[i] === "!" || password[i] === "@" || password[i] === "#" || password[i] === "$" || password[i] === "%" ||
                password[i] === "^" || password[i] === "&" || password[i] === "*" || password[i] === "(" || password[i] === "!)" ||
                password[i] === "-" || password[i] === "_" || password[i] === "=" || password[i] === "+" || password[i] === "|" ||
                password[i] === "1" || password[i] === "2" || password[i] === "3" || password[i] === "4" || password[i] === "5"
                || password[i] === "6" || password[i] === "7" || password[i] === "8" || password[i] === "9" || password[i] === "0"
                || password[i] === "[" || password[i] === "]" || password[i] === "{" || password[i] === "}" || password[i] === "/"
                || password[i] === "?" || password[i] === ".")
            {
                specialCharacters++;
            }
        }

        for (i = 0; i <= password.length; i++) {
            if (password[i] === password[i + 1])
                sameSymbols++;
        }

        if (specialCharacters <= 2) {
            colorDivs = document.getElementsByClassName("demo4");
            colorDivs[0].style.backgroundColor = "#fc0d0d";
            document.getElementById("demo4").innerHTML = "Введите специальные символы";
        }
        else {
            colorDivs = document.getElementsByClassName("demo4");
            colorDivs[0].style.backgroundColor = "#00fc54";
            document.getElementById("demo4").innerHTML = "Специальные символы есть в пароле";
        }
        
        if (password.length < 8) {
            colorDivs = document.getElementsByClassName("demo3");
            colorDivs[0].style.backgroundColor = "#fc0d0d";
            document.getElementById("demo3").innerHTML = "Придумайте пароль больше 8 символов";
        }
        else {
            colorDivs = document.getElementsByClassName("demo3");
            colorDivs[0].style.backgroundColor = "#00fc54";
            document.getElementById("demo3").innerHTML = "Количество символов прошло проверку";
        }
        
        if (sameSymbols === password.length) {
            colorDivs = document.getElementsByClassName("demo2");
            colorDivs[0].style.backgroundColor = "#fc0d0d";
            document.getElementById("demo2").innerHTML = "Одинаковая последовательность символов";
        }
        else {
            colorDivs = document.getElementsByClassName("demo2");
            colorDivs[0].style.backgroundColor = "#00fc54";
            document.getElementById("demo2").innerHTML = "Последовательность символов прошла проверку";
        }
    }
    else {
        colorDivs = document.getElementsByClassName("demo4");
        colorDivs[0].style.backgroundColor = "#fc0d0d";
        document.getElementById("demo4").innerHTML = "Введите пароль!";
    }

}