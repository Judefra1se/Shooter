using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis : MonoBehaviour
{
    public int Pv;
    public GameObject Bonus;
    public GameObject Balle_Ennemis;
    public float Timer;

    void Start()
    {
        Timer = Random.Range(1f, 10f);
    }

    void Update()
    {
        if(Balle_Ennemis == true)
        {
            Timer -= Time.deltaTime;

            if (Timer <= 0)
            {
                Instantiate(Balle_Ennemis, transform.position, Quaternion.Euler(0, 1, 2));
                Timer = Random.Range(1f,10f);
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Pv <= 0)
        {
            Instantiate(Bonus, transform.position, Quaternion.Euler(0, 1, 2));
            Destroy(gameObject);
        }
    }

}
