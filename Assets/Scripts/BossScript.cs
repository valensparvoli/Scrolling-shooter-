using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public float Movimiento = 5f;
    public GameObject bulletBoss;
    public Transform firepoint;
    public float tiempo;
    public GameObject meteoro1;

    void Moverse()
    {
        transform.position = transform.position + new Vector3(0, -Movimiento * Time.deltaTime, 0);

    }


    private void Update()
    {
        if (transform.position.y >= 14)
        {
            Moverse();
            
        }
       
    }



}
