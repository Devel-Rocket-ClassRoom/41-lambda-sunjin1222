using System;
using System.Runtime.CompilerServices;

// README.md를 읽고 아래에 코드를 작성하세요.



/*
// 1. 가장 간단한 람다식
PrintMessage hello = () => Console.WriteLine("안녕하세요.");
hello();
delegate void PrintMessage();
// 2. 매개변수와 반환값이 있는 람다식

Transformer square = x => x * x;
Console.WriteLine(square(3));
Console.WriteLine(square(4));

delegate int Transformer(int x);

// 3. 여러 매개변수가 있는 람다식
IsLonger IsLonger =(string msg, int len) => msg.Length > len;
Console.WriteLine(IsLonger("안녕하세요.", 5));
Console.WriteLine(IsLonger("반갑습니다.", 10));

delegate bool IsLonger(string s, int i);
// 4. 문장 람다
Greeting greeting = () =>
{
    Console.WriteLine("안녕하세요");
    Console.WriteLine("반갑습니다");
};
greeting();
delegate void Greeting();
*/
// 5. 문장 람다에서 값 반환

Calculator calculator = (a, b) =>
{
    int result = a + b;
    Console.WriteLine($"{a}+{b}={result}");
    return result;
};

int sum = calculator(3,5);

Console.WriteLine($"합계: {sum}");


delegate int Calculator(int a, int b);
