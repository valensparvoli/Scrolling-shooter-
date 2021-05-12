using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float velocidad = 5f;

    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(0, -velocidad * Time.deltaTime, 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            PlayerController.Speed = PlayerController.Speed+5;
        }
    }
}
