using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    int spriteIndex = -1;
    public int[] indexList = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    public int[] secindexList = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    public int PlayerTurn()
    {
        spriteIndex++;
        return spriteIndex % 2;
    }
}