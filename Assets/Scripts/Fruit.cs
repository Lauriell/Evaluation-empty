using UnityEngine;

public class Fruit : MonoBehaviour
{
    private Spawner spawner;
    public ScoreDisplayer scored;
    public SnakeController snakeController;

    private void Start()
    {
        snakeController = GetComponent<SnakeController>();
        spawner = GetComponent<Spawner>();
        scored = GetComponent<ScoreDisplayer>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.gameObject. == SnakeController)
        {
            spawner.SpawnFruit();
            //scored.SetScore(int)++;
            snakeController.EatFruit();
        }

    }
}
