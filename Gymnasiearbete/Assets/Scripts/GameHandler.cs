using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private Snake snake;
    private LevelGrid levelGrid;
    private void Start()
    {
        Debug.Log("GameHandler.Start");

        levelGrid = new LevelGrid(19, 19);

        snake.Setup(levelGrid);
        levelGrid.Setup(snake);
    }
}
