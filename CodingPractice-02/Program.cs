using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

/*
// 1. Func 대리자
Func<int> getNumber = () => 1234;
Console.WriteLine(getNumber());

Func<int, int> square = x => x * x;
Console.WriteLine(square(3));

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(3, 5));

// 2. Action 대리자

Action action = () => Console.WriteLine("안녕하세요!");
action();
Action<string> action1=s => Console.WriteLine(s);
action1("Hello, Lambda!");
Action<string, int> re = (msg, count) =>
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
};

re("반복!", 3);
*/
// 3. 익명 메서드와 람다식 비교

Func<int, int> anonymous = delegate (int x) { return x * x; };
Console.WriteLine(anonymous(2));

Func<int, int> lambda=x => x * x;
Console.WriteLine(lambda(2));
