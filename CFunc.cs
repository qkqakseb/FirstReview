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
        Random random = new Random();
        int sourIndex = 0; 
        int destIndex = 0; 

        for (int i = 0; i < array.Length; i++)
        {
            sourIndex = random.Next(0, array.Length);
            destIndex = random.Next(0, array.Length);
            ShuffleOnce(ref array[sourIndex], ref array[destIndex]);
        }
    }       // ShuffleStrArray()

    //! 여러 번 섞어주는 함수
    public static void Shuffle(int[] array, int shuffleCount)
    {
        Random random = new Random();
        int sourIndex = 0;
        int destIndex = 0;

        for (int i=0; i<array.Length; i++)
        {
            sourIndex = random.Next(0, array.Length);
            destIndex = random.Next(0, array.Length);
            ShuffleOnce(ref array[sourIndex], ref array[destIndex]);
        }
    }       // Shuffle()

    //! 한 번 섞어주는 함수
    private static void ShuffleOnce(ref int firstValue, ref int secondValue)
    {
        int temp = firstValue;
        firstValue = secondValue;
        secondValue = temp;
    }

    //! 한 번 섞어주는 함수
    private static void ShuffleOnce(ref string firstValue, ref string secondValue)
    {
        string temp = firstValue;
        firstValue = secondValue;
        secondValue = temp;
    }
}