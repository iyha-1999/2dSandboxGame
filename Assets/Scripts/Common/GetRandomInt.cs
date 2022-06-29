using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Common
{
    public class GetRandomInt
    {
        ////渡された重み付け配列からIndexを得る
        public static int GetRandomIndex(params int[] weightTable)
        {
            int totalWeight = weightTable.Sum();
            var value = Random.Range(1, totalWeight + 1);
            var retIndex = -1;
            for (var i = 0; i < weightTable.Length; ++i)
            {
                if (weightTable[i] >= value)
                {
                    retIndex = i;
                    break;
                }
                value -= weightTable[i];
            }
            return retIndex;
        }
    }
}

