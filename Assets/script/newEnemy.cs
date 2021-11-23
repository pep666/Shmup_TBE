using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEnemy : MonoBehaviour
{

    public int health = 40;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


}
