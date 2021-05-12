using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpeBoss : MonoBehaviour
{
    bool movermeDerecha = false;
    public int rapidez = 5;
    public GameObject cuboIzquierdo;
    public GameObject cuboDerecho;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    void Derecha()
    {
        //transform.position = transform.position + new Vector3(-rapidez * Time.deltaTime, 0, 0);

    }

    void Izquierda()
    {
        transform.position += -transform.right * rapidez * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("cuboIzquierdo"))
        {
            Izquierda();
        }
    }
}
