using UnityEngine;

public class continuPlayer : MonoBehaviour
{
    public float startTime; //temps entre chaque tir
    private float time; //d�but du compte a rebourmkfrsjg
    public GameObject bulletPrefab;
    public Transform point;
    Rigidbody2D rb;
    [SerializeField] float speed;
    public int damage = 40;
    //public GameObject bulletg;
    //public Transform pointg;
    //public GameObject bulletd;
    //public Transform pointd;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        time = startTime;
        rb.velocity = transform.up * speed;
    }

    void Update()
    {
        if (time <= 0)
        {
            Instantiate(bulletPrefab, point.position, Quaternion.identity);
            //Instantiate(bulletg, pointg.position, Quaternion.identity);
            //Instantiate(bulletd, pointd.position, Quaternion.identity);
            time = startTime;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

    


}
