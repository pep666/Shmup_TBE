using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float health ;
    public float maxHealth ;
    public healthBar healthBar;


    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        healthBar.UpdateHealthBar();
    }


}
