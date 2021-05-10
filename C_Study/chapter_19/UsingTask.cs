using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

// page 681 System.Threading.Tasks.Task 클래스는 우리가 비동기 코드를 손쉽게 작성할 수 있게 도와준다.
// 동기(Synchronous) 메소드를 호출한 뒤에 이 메소드의 실행이 완전히 종료되어야만(반환되어야지만) 다음 메소드를 호출 가능
// 비동기(Asynchronous) 메소드를 호출한 뒤 메소드의 종료를 기다리지 않고 다음 코드를 실행

// 병렬 처리: 하나의 작업을 여러 작업자가 나눠서 수행한 뒤 다시 하나의 결과로 만드는 것
// 비동기 처리: 작업 A를 시작한 뒤 A의 결과가 나올때 까지 마냥 대기하는 대신 곧 이어 다른 작업 B,C,D를 수행하다가 작업 A가 끝나면 그 때 결과를 받아내는 처리 방식
// 유니티의 코루틴은 테스크의 변형 
// 호출 될때 마다 디른 결과가 나와야 한다면 코루틴, 매번 똑같은 실행 결과를 리턴하려면 테스크
// Task의 클래스들은 하나의 작업을 쪼갠 뒤 쪼개진 작업들을 동시에 처리하는 코드와 비동기 코드를 위해 설계
// Thread의 클래스는 여러 개의 작업을 (나누지 않고) 각각 처리해야 하는 코드에 적합, Task도 사실 thread을 이용하여 구현되어 thread에서도 Task의 기능을 쓸수 있지만 뒤지기 싫으면 그러지 말것
namespace C_Study.chapter_19
{
    class UsingTask
    {
        static void Main(string[] args)
        {
            string srcFile = @"D:\a.txt";
            Action<object> FileCopyAction = (object state) =>
            {
                String[] paths = (String[])state;
                //File.CreateText(paths[0]);
                File.Copy(paths[0], paths[1]);

                Console.WriteLine($"TaskID: {Task.CurrentId} ThreadID: {Thread.CurrentThread.ManagedThreadId} {paths[0]} was copied to {paths[1]}");              
            };

            Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });

            Task t2 = Task.Run(() =>
            {
                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
            });

            t1.Start();

            Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });

            t3.RunSynchronously();

            t1.Wait();
            t2.Wait();
            t3.Wait();
        }
    }
}
