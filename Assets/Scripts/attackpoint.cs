using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackpoint : MonoBehaviour
{
    public Rigidbody2D enemyRb;
    public bool inRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            inRange = true;
            enemyRb = collision.GetComponent<Rigidbody2D>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            inRange = false;
        }
    }

}
