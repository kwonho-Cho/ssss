using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //함수는 명령 집합을 하나의 이름으로 묶은것으로, 코드의 "재사용을 위해 만들어진다."
            //static수식 함수는 메모리에 자체 공간이 할당되어 바로 불러오는게 가능했던 것임. - Main이 포함된 클래스에 메소드는 static을 쓰자
            //일반적으로 객체를 만들어야 메모리에 공간이 할당됨.
            //int cnt = GetCountShowHello("Hello World", "Learn C#");
            //Console.WriteLine("출력된 문자 길이는 {0}글자 입니다.", cnt);
            //cnt = GetCountShowHello("내 이름은 홍길동", "난 남자다");
            //Console.WriteLine("출력된 문자 길이는 {0}글자 입니다.", cnt);
            //cnt = GetCountShowHello("오늘은 수요일!", "놀고 싶다");
            //Console.WriteLine("출력된 문자 길이는 {0}글자 입니다.", cnt);
            while (true)
            {
                Console.Write("1.출력\n2.종료\n번호를 선택하세요 : ");
                int num = int.Parse(Console.ReadLine());
                int num1 = 0, num2 = 0;
                if (num == 1)
                {

                    Console.Write("시작 숫자를 입력하세요 : ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("마지막 숫자를 입력하세요 : ");
                    num2 = int.Parse(Console.ReadLine());

                    PrintNumberRow(num1, num2);

                    Console.WriteLine("숫자의 총합은 {0}", TotalOfNumberRow(num1, num2));
                }
                else if (num == 2)
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못 입력하셨습니다.");
                }
            }
        }
        #region
        //static public void ShowHello(string str1, string str2) 
        //    //매개변수,반환형이 필요없는 메소드 : 함수 자체만으로 결과를 출력해내는 메소드
        //{
        //    Console.WriteLine("{0}",str1);
        //    Console.WriteLine("{0}",str2);
        //    Console.WriteLine();
        //}
        #endregion
        static void PrintNumberRow(int num1, int num2)
        {
            for(int i = num1; i <= num2; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static int TotalOfNumberRow(int num1, int num2)
        {
            int total = 0;
            for (int i = num1; i <= num2; i++)
            {
                
                total += i;
            }
            return total;
        }
    }
}
