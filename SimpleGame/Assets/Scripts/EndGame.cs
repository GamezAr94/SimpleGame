
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameManager gameManeger;
    private void OnTriggerEnter(Collider other)
    {
        gameManeger.CompleteLevel();
    }
}
