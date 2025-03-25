using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Tower : CharacterBase
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("colliding with enemy");
            health = health - 10;
            Destroy(collision.gameobject);
        }
        
    }
}
