using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float health, maxHealth;
    public healthBarEnemy healthBarEnemy;
    public GameObject enemyPrefab;
    public Transform point;

    private ItemDrop getItem;

    private void Start()
    {
        //eneemies = FindGameObjectWithTag("Enemy");
        //eneemies = FindGameObjectsWithTag("Enemy"); enemies[0],enemies[1]
        getItem = GetComponent<ItemDrop>();


    }


    public void spawn()
    {
        Instantiate(enemyPrefab, point.position, Quaternion.identity);
    }


    public void TakeDamage(int damage)
    {
        health -= damage;

      
        if (health <= 0)
        {
            if (getItem != null)
            {
                getItem.DropItem();
                Debug.Log("Dropped an Item " + getItem);
            }
            Destroy(gameObject);
            spawn();
        }

        healthBarEnemy.UpdateHealthBarEnemy();
    }


    


}
