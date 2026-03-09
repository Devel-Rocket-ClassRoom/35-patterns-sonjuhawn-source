using System;
using System.Runtime.InteropServices;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("'''");
object obj = "Hello";
if(obj is string s)
{
    Console.WriteLine(s.Length);
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
object num = 42;
if(num is int num1)
{
    Console.WriteLine($"정수값: {num1}");
    Console.WriteLine($"제곱: {num1 * num1}");
}
else
{
    Console.WriteLine("정수가 아님");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
PrintInfo(100);
PrintInfo(3.14);
PrintInfo("Hello");
PrintInfo(true);
PrintInfo(DateTime.Now);
void PrintInfo(object obj)
{
    switch (obj)
    {
        case int i :
            Console.WriteLine($"정수: {i}, 2배: {i * 2}");
            break;
        case double d:
            Console.WriteLine($"실수: {d}");
            break;
        case string s:
            Console.WriteLine($"문자열: {s}, 길이: {s.Length}");
            break;
        case bool b:
            Console.WriteLine($"불리언: {b}");
            break;
        default:
            Console.WriteLine($"기타 타입: {obj.GetType().Name}");
            break;
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
CheckValue(0);
CheckValue("Hello");
CheckValue(null);
CheckValue(42);
void CheckValue(object obj1)
{
    if(obj1 is 0)
    {
        Console.WriteLine("값이 0임");
    }
    else if(obj1 is "Hello")
    {
        Console.WriteLine($"값이 Hello임");
    }
    else if(obj1 is null)
    {
        Console.WriteLine($"값이 null임");
    }
    else
    {
        Console.WriteLine($"다른 값: {obj1}");
    }

}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine(GetDayType(DayOfWeek.Tuesday));
Console.WriteLine(GetDayType(DayOfWeek.Sunday));
string GetDayType(DayOfWeek day)
{
    switch (day)
    {
        case DayOfWeek.Saturday:
        case DayOfWeek.Sunday:
            return "주말";
            break;
        default:
            return"평일";
            break;
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
DescribeValue(42);
DescribeValue(3.14);
DescribeValue("Hello");
DescribeValue(null);
DescribeValue(true);
string DescribeValue(object obj) => obj switch
{
    int i => $"정수 {i}",
    double d => $"실수 {d}",
    string s => $"문자열 {s}",
    null => $"null 값",
    _ => $"알 수 없는 타입 ({obj.GetType().Name})"
};
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine($"95점: {GetGrade(95)}");
Console.WriteLine($"85점: {GetGrade(85)}");
Console.WriteLine($"75점: {GetGrade(75)}");
Console.WriteLine($"65점: {GetGrade(65)}");
Console.WriteLine($"55점: {GetGrade(55)}");
string GetGrade(int score) => score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"
};
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine($"-5도: {ClassifyTemperature(-5)}");
Console.WriteLine($"5도: {ClassifyTemperature(5)}");
Console.WriteLine($"15도: {ClassifyTemperature(15)}");
Console.WriteLine($"25도: {ClassifyTemperature(25)}");
Console.WriteLine($"35도: {ClassifyTemperature(35)}");
string ClassifyTemperature(int celsius) => celsius switch
{
    < 0 => "영하",
    <10 => "추움",
    <20 => "선선함",
    <30 => "따뜻함",
    _=> "더움"
};
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine($"25살 유효한 나이: {IsValidAge(25)}");
Console.WriteLine($"-5살 유효한 나이: {IsValidAge(-5)}");
Console.WriteLine($"15살 청소년: {IsTeenager(15)}");
Console.WriteLine($"25살 청소년: {IsTeenager(25)}");

bool IsValidAge(int age) => age is >= 0 and <= 150;
bool IsTeenager(int age) => age is >= 13 and <= 19;
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine($"토요일 주말: {IsWeekend(DayOfWeek.Saturday)}");
Console.WriteLine($"월요일 주말: {IsWeekend(DayOfWeek.Monday)}");
Console.WriteLine($"'a' 모음: {IsVowel('a')}");
Console.WriteLine($"'b' 모음: {IsVowel('b')}\"");
bool IsWeekend(DayOfWeek day) => day is DayOfWeek.Saturday or DayOfWeek.Sunday;
bool IsVowel(char c) => char.ToLower(c) is 'a' or 'e' or 'i' or 'o' or 'u';
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine($"\"Hello\" not null: {IsNotNull("Hello")}");
Console.WriteLine($"null not null: {IsNotNull(null)}");
Console.WriteLine($"\"Hi\" not empty: {IsNotEmpty("Hi")}");
Console.WriteLine($"\"\" not empty: {""}");
bool IsNotNull(object obj) => obj is not null;
bool IsNotEmpty(object obj) => obj is not (null or "");
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine($"0: {ClassifyNumber(0)}");
Console.WriteLine($"5: {ClassifyNumber(5)}");
Console.WriteLine($"42: {ClassifyNumber(42)}");
Console.WriteLine($"-3: {ClassifyNumber(-3)}");
Console.WriteLine($"100: {ClassifyNumber(100)}");
Console.WriteLine($"-50: {ClassifyNumber(-50)}");

string ClassifyNumber(int n) => n switch
{
    0 => "영",
    >0 and <10 => "한자리 양수",
    >10 and <20 => "두자리 양수",
    >-10 and <0 => "한 자리 음수",
    _ => "그 외"
};
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine($"Janet: {IsJanetOrJohn("Janet")}");
Console.WriteLine($"john: {IsJanetOrJohn("john")}");
Console.WriteLine($"Mike: {IsJanetOrJohn("Mike")}");
bool IsJanetOrJohn(string name) =>
    name.ToUpper() is var upper && (upper == "JANET" || upper == "JOHN");
Console.WriteLine("'''\n");

Console.WriteLine("'''");
var p = new Person[]
{
    new Person{Name = "철수" , Age = 15},
    new Person{Name = "영희" , Age = 30},
    new Person{Name = "할머니" , Age = 70 }
};

Console.WriteLine($"철수(15세): {DescribePerson(p[0])}");
Console.WriteLine($"영희(30세): {DescribePerson(p[1])}");
Console.WriteLine($"할머니(70세): {DescribePerson(p[2])}");
string DescribePerson(Person p) => p switch
{
    { Age: <= 18 } => "미성년자",
    { Age: < 65 } => "성인",
    { Age: >= 65 } => "노인"
};
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine(Greet(p[0]));
Console.WriteLine(Greet(p[1]));
string Greet(Person p) => p switch
{
    { Age: <= 18 } => $"안녕 {p.Name}",
    { Age: > 18 } => $"안녕하세요 {p.Name}님",
};
Console.WriteLine("'''\n");

Console.WriteLine("'''");
Person[] p1 = new Person[]
{
    new Student{Name = "철수", Age = 17, School = "서울고"},
    new Employee{Name = "영희", Age = 28, Company = "삼성"},
    new Person{Name = "민수" , Age = 40}
};
Console.WriteLine($"철수: {DescribeDetailed(p1[0])}");
Console.WriteLine($"영희: {DescribeDetailed(p1[0])}");
Console.WriteLine($"민수: {DescribeDetailed(p1[0])}");
string DescribeDetailed(Person p) => p switch
{
    Student { School: var school, Age: var age, } => $"{age}세 학생, {school} 재학",
    Employee { Company: var company, Age: var age, } => $"{age}세 직장인, {company} 근무",
    Person { Age: var age} => $"{age}세 일반인"
};
Console.WriteLine("'''\n");

Console.WriteLine("'''");
var points = new[] { (0, 0), (3, 0), (0, 5), (2, 3), (-2, 3), (-2, -3), (2, -3) };
foreach (var (x, y) in points)
{
    Console.WriteLine($"({x}, {y}): {ClassifyPoint(x, y)}");
}

string ClassifyPoint(int x, int y) => (x, y) switch
{
    (0, 0) => "원점",
    (_, 0) => "X축 위",  
    (0, _) => "Y축 위",  
    ( > 0, > 0) => "1사분면",
    ( < 0, > 0) => "2사분면",
    ( < 0, < 0) => "3사분면",
    ( > 0, < 0) => "4사분면"
};
Console.WriteLine("'''\n");

Console.WriteLine("'''");

string GetProductStatus(Product p) => p switch
{

}
Console.WriteLine("'''\n");

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Student : Person
{
    public string School {  get; set; }
    
}
class Employee : Person
{
    public string Company {  get; set; }
}
class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }
}