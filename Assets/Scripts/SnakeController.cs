using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class SnakeController : MonoBehaviour
{
    private bool isAlive = true;
    private Transform tail;
    [SerializeField] int timeBeforeMove;

    private void Start()
    {
        new GameObject("Tail");
        //  var tail = GameObject("Tail").position;
        Instantiate(GameObject.Find("TailPart"), transform.parent);
    }
    public void OnMove(InputAction.CallbackContext context)
    {
      /*  if (!(check input)
        return;*/

        while(isAlive == true)
        {
                StartCoroutine(Move());
        }
    }
    IEnumerator Move()
    {
        if(timeBeforeMove == 0)
            Debug.Log("IE Move");
        var emptySpace = GetComponent<Rigidbody>().position;
        //   emptySpace = Vector2 + currentInput;
        yield return new WaitForFixedUpdate();
    }

    public void EatFruit()
    {

    }

    void Die()
    {
        isAlive = false;
        Instantiate(GameObject.Find("GameOverCanvas"));
        // if (GameObjet.FindGameObjectsWithTag("PlayZone").isTrigger = false)
        {
            Die();
        }
        Destroy(tail.GetChild(0)gameObject) ;
        Destroy(gameObject);
        if (tail.GetChild(0).istrigger)
        {
            Destroy(gameObject);
        }
    }
}
