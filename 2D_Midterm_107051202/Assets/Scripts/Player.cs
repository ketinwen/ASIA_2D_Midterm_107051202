using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject final;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送門");
    }

}
