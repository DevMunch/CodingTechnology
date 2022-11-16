using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTechnology.Code01
{
    internal class Ex001
    {
        // var 사용에 관한 고민
        // - var가 자바스크립트 처럼 무엇이든 저장할 수 있는 마술 상자라고 생각한다.
        //   그러나 c#의 var는 형을 명시하지는 않지만 추론으로 확정한다. -> 변수에는 지정된 형만 지정할 수 있다.

        // 물론 c#에도 무엇이든 들어가는 마술 상자인 dynamic형이 존재한다. 하지만 이를 사용하는 순간 vs가 아무런 지원을
        // 하지 않는다. 무엇이든 들어가므로 예측이 불가능하기 때문이다.

        // 그러나 var는 형이 명시되어 있지 않아도 결국 하나의 형으로 정해지기 때문에 생산성도 떨어지지 않는다.
        public static void Test()
        {
            Dictionary<string, Action<TextWriter>> Dic = new Dictionary<string, Action<TextWriter>>();

            Dic.Add("Sample1", (writer) => { writer.WriteLine("I'm sample1!"); });
            Dic.Add("Sample2", (writer) => { writer.WriteLine("I'm sample2!"); });

            foreach (var item in Dic.Values) item(Console.Out);
        }

        // var를 사용한 코드
        public static void Test1()
        {
           var Dic = new Dictionary<string, Action<TextWriter>>();

            Dic.Add("Sample1", (writer) => { writer.WriteLine("I'm sample1!"); });
            Dic.Add("Sample2", (writer) => { writer.WriteLine("I'm sample2!"); });

            foreach (var item in Dic.Values) item(Console.Out);
        }

        // 결론.
        // var a = b의 경우 a는 b의 형을 알아야지만 파악할 수 있어 비효율적이지만,
        // 타입이 매우길다면 var를 꼭 사용하는 것이 좋다.
    }
}
