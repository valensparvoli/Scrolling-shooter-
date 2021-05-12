using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public float Jumpv = 5f;

    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(0, -Jumpv * Time.deltaTime, 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
