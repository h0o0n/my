using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.비동기메서드
{
    class AsyncMain
    {
        public void main() { }

        public async Task at()
        {
            await Task.Delay(1000);

            Console.WriteLine("비동기 메인 메서드");
        }

    }
}
