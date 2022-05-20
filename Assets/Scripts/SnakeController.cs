using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class SnakeController : MonoBehaviour
{
    private bool isAlive = true;
    private int NextMove;
    private Transform tail;
    [SerializeField] int timeBeforeMove;

    private void Start()
    {
        new GameObject("Tail");
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        if (!) ;
        return;

        while(isAlive == true)
        {
                StartCoroutine(Move());
        }
    }
    IEnumerator Move()
    {

        Debug.Log("IE Move");
        yield return null;
    }

    public void EatFruit()
    {

    }
}
