using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject gameBoard;
    public Sprite[] images;
    bool unplayed = true;
    

    private void Start()
    {
        spriteRenderer.sprite = null;
    }

    private void OnMouseDown()
    {
        int currentlayer = spriteRenderer.name[0] - '0';
        int currentIndex = spriteRenderer.name[2] - '0';
        if (currentlayer == 1)
        {
            if (unplayed)
            {
                int index = gameBoard.GetComponent<GameScript>().PlayerTurn();
                spriteRenderer.sprite = images[index];
                gameBoard.GetComponent<GameScript>().indexList[currentIndex - 1] = 1;
                unplayed = false;
            }
        }
        else if (currentlayer == 2)
        {
            if ((unplayed) && (gameBoard.GetComponent<GameScript>().indexList[currentIndex - 1] > 0))
            {
                int index = gameBoard.GetComponent<GameScript>().PlayerTurn();
                spriteRenderer.sprite = images[index];
                gameBoard.GetComponent<GameScript>().secindexList[currentIndex - 1] = 1;
                unplayed = false;
            }
        }
        else {
            if ((unplayed) && (gameBoard.GetComponent<GameScript>().secindexList[currentIndex - 1] > 0))
            {
                int index = gameBoard.GetComponent<GameScript>().PlayerTurn();
                spriteRenderer.sprite = images[index];
                unplayed = false;
            }

        }
    }


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameBoard = GameObject.Find("GameBoard");
    }
}