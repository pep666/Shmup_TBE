using UnityEngine.InputSystem;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public int damage;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
