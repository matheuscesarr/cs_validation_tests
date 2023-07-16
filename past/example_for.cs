
for (int i=1;i<101;i++){
        string message = "";
        if (i%3==0 && i%5==0){message = $"{i} - FizzBuzz";}
        else if (i%3==0) {message = $"{i} - Fizz";}
        else if (i%5==0) {message = $"{i} - Buzz";}
        else {message = $"{i}";}
        Console.WriteLine(message);
}