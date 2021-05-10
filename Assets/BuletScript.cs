using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuletScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public int damage;
    void Start()
    {

        rb.velocity = transform.up*speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Borde"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MeteoroScript meteoro =collision.GetComponent<MeteoroScript>();
        if (meteoro != null)
        {
            meteoro.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
