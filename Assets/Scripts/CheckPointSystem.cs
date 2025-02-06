using UnityEngine;

public class CheckPointSystem : MonoBehaviour
{
    public Mechanic mechanic;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            mechanic.CheckPointPos = collision.transform.position;
        }
    }

}
