using System;
using System.Threading.Tasks;

namespace Study
{
    // async / await -> 비동기 프로그래밍
    // 비동기라고 해도 꼭 멀티쓰레드가 아님 비동기가 중요
    // 유니티 코루틴도 일종의 비동기 -> 그치만 싱글쓰레드

    class Program
    {
        static Task Test()
        {
            Console.WriteLine("Start Test");

            // 호출한 순간부터 3초
            Task t = Task.Delay(3000);
            return t;
        }

        // 아이스 아메리카노 제조중(1분)
        // 주문 대기 
        static async Task<int> TestAsync()
        {
            Console.WriteLine("Start TestAsync");
            Task t = Task.Delay(3000);
            //t.Wait();
            // 내부에서 해도 됨
            // 복잡한 작업(DB나 파일작업) 등을 할 때 쓸 수 있기는 한데 웨이트 하는 동안 다른 코드를 실행 못함
            // 오래 걸리는 작업을 할 때 제어권을 다른 코드한테 넘기겠다~

            await Task.Delay(3000);
            //await t;
            // await 걸리면 거의 바로 와일 스타트문 출력 -> 3초 뒤에 End TestAsync 출력
            // 멀티쓰레드로 잡히긴 함 그치만 비동기 식으로 빠져나간다는게 중요!!
            Console.WriteLine("End TestAsync");

            return 1;

        }

        static async Task Main(string[] args)
        {
            //// 테스크가 완료 되었는지 안되어있는지는 별개의 문제 
            //Task t = Test();
            //// wait를 사용하면 해당 테스크가 끝나기 까지 기다림
            //t.Wait();

            Task<int> t = TestAsync();
            int ret = await t;
            // 요렇게 나눠서 동작을 실행할 수 있음

            //int ret = await TestAsync();
            //// 인자를 넣어서 값을 받아올 수도 있음

            Console.WriteLine("while start");
            Console.WriteLine(ret);
            while(true)
            {

            }
        }
    }
}
