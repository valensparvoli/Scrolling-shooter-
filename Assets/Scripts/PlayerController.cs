using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public static float Vida=100;
    public Text UIvida;
    public GameObject bullet;
    public Transform firepoint;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y).normalized;
        Move(direction);

        //Vida
        UIvida.text = "Vida:" + Vida.ToString();
        if (Vida <= 0)
        {
            SceneManager.LoadScene("Perdiste");
        }

        //Disparar
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public void Move(Vector2 direction)
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        min.x = min.x + 0.3f;
        max.x = max.x - 0.3f;

        min.y = min.y + 0.4f;
        max.y = max.y - 0.4f;

        Vector2 pos = transform.position;
        pos += direction * Speed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);

        transform.position = pos;
    }
    
    void Shoot()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }
    
}
