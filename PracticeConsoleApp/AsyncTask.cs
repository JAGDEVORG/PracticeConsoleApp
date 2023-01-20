using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class AsyncTask
    {
        public Task GetResult()
        {
            Task.Run(() => Method());
            Task.Factory.StartNew(() => Method());
            return Task.FromResult(0);
        }
        public void SlowTyper(int value)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Value: {value}");
        }

        private void Method()
        {
            Console.WriteLine("hello");
        }
        public static async Task Main()
        {
            AsyncTask asyncTask = new AsyncTask();
            var result=await asyncTask.getDesc(5, 6);
            Console.WriteLine(result);
            _ = asyncTask.GetResult();
            //asyncTask.SlowTyper(50);
        }


        public async Task<int> getDesc(int i, int p)
        {
           return await getDescResult(i, p);
        }
        public async Task<int> getDescResult(int i, int p)
        {
            return await Task.FromResult(i + p);
        }
    }
}
