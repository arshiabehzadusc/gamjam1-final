using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    int spriteIndex = -1;
    public int[] indexList = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    public int PlayerTurn()
    {
        spriteIndex++;
        for (int i = 0; i < 9; i++) {
            Debug.Log(indexList[i]);
        }
        return spriteIndex % 2;
    }
}
