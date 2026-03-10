using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

var system = CreateLogger("시스템");
var network = CreateLogger("네트워크");

system("서버를 시작합니다.");
system("초기화가 완료되었습니다.");
network("클라이언트가 접속했습니다.");
system("요청을 처리합니다.");
network("데이터를 수신했습니다.");
network("클라이언트가 종료했습니다.");

static Action<string> CreateLogger(string scategory)
{
    int count = 0;
    return s =>
    {
        count++;
        Console.WriteLine($"[{scategory} #{count}] {s}");
    };
}