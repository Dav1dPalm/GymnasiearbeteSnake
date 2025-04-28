using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid  {
    
    private Vector2Int foodGridposition;
    private GameObject foodGameObject;
    private int width;
    private int height;
    private Snake snake;
    public LevelGrid(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void Setup(Snake snake) 
    {
        this.snake = snake;

        SpawnFood();
    }

    private void SpawnFood()
    {
        do
        {
            foodGridposition = new Vector2Int(Random.Range(0, width), Random.Range(0, height));
        } while (snake.GetFullSnakeGridPositionList().IndexOf(foodGridposition) != -1);

        foodGameObject = new GameObject("Food", typeof(SpriteRenderer));
        foodGameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.i.foodSprite;
        foodGameObject.transform.position = new Vector3(foodGridposition.x, foodGridposition.y);
    }

    public bool TrySnakeEatFood(Vector2Int snakeGridPosition)
    {
        if(snakeGridPosition == foodGridposition)
        {
            Object.Destroy(foodGameObject);
            SpawnFood();
            return true;
        } else
        {
            return false;
        }

    }

}
