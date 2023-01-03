using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class CFunc
{

    //! 여러 번 섞어주는 함수
    public static void ShuffleStrArray(string[] array, int shuffleCount)
    {
        Random random = new Random();   // 랜덤이라는 새로운 개체를 생성
        int sourIndex = 0;              //  int 정수형에 sourIndex 라는 변수를 선언하고, 0으로 초기화를 시켰다. 랜덤 변수를 저장하기 위해서 만듬
        int destIndex = 0;              //  int 정수형에 destIndex 라는 변수를 선언하고, 0으로 초기화를 시켰다. 랜덤 변수를 저장하기 위해서 만듬
            

        for (int i = 0; i < array.Length; i++)  // 0부터 array.Length까지 1씩 증가하며 반복
        {
            sourIndex = random.Next(0, array.Length);                          // 0부터 array.Length 사이에 난수를 써서 sourIndex에 저장
            destIndex = random.Next(0, array.Length);                         // 0부터 array.Length 사이에 난수를 써서 destIndex에 저장
            ShuffleOnce(ref array[sourIndex], ref array[destIndex]);          // ShuffleOnce 함수에 변수로서 array[sourIndex] 와 array[destIndex]를 사용하겠다.
        }
    }       // ShuffleStrArray()

    //! 여러 번 섞어주는 함수
    public static void Shuffle(List<int> array)
    {
        Random random = new Random();
        int sourIndex = 0;
        int destIndex = 0;

        for (int i=0; i<array.Count; i++)
        {
            sourIndex = random.Next(0, array.Count);
            destIndex = random.Next(0, array.Count);
            int tmp = array[sourIndex];
            array[sourIndex] = array[destIndex];
            array[destIndex] = tmp;
        }
    }       // Shuffle()
     
    //! 한 번 섞어주는 함수
    private static void ShuffleOnce( int firstValue, int secondValue)
    {
        int temp = firstValue;                                         // int형 temp변수에 선언하고, firstValue에 값을 저장한다.
        firstValue = secondValue;                                      // fistValue에 secondValue에 값을 저장한다.
        secondValue = temp;                                            // secondValue에 temp 값을 저장한다.
    }

    //! 한 번 섞어주는 함수
    private static void ShuffleOnce(ref string firstValue, ref string secondValue)
    {
        string temp = firstValue;
        firstValue = secondValue;
        secondValue = temp;
    }
}