using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBossScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public int damage;
    void Start()
    {

        rb.velocity = transform.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("BordeMeteoros"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController Player = collision.GetComponent<PlayerController>();
        if (Player != null)
        {
            Player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
