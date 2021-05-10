using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroScript : MonoBehaviour
{
    //Movimiento hacia delante
    public float Jumpv = 5f;

    //Vida
    public int Health;
  
    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(0, -Jumpv * Time.deltaTime, 0);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            PlayerController.Vida -= 15;
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
