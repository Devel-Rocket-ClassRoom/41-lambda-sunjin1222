using System;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Func<string, string> func1 = s1 => s1.ToUpper();

Func<string, string> func2 = s2 => s2.Substring(0, 2) + "***";

Func<string, string> func3 = s3 => "안녕하세요, "+ s3+"님";

void ApplyAndPrint(string input, Func<string, string> formatter)
{
    Console.WriteLine($"{formatter(input)}");
}

ApplyAndPrint("hello world",s=> $"[대문자 변환]{s}->{func1(s)}");
ApplyAndPrint("SecretCode", s => $"[마스킹 처리]{s}->{func2(s)}");
ApplyAndPrint("민수", s => $"[인사말 생성]{s}->{func3(s)}");

