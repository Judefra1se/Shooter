using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis : MonoBehaviour
{
    public int pv;
    public GameObject bonus;
    public GameObject EnnemisBullet;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(1f, 10f);
    }

    void Update()
    {
        if(EnnemisBullet == true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                Instantiate(EnnemisBullet, transform.position, Quaternion.Euler(0, 1, 2));
                timer = Random.Range(1f,10f);
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (pv <= 0)
        {
            Instantiate(bonus, transform.position, Quaternion.Euler(0, 1, 2));
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
}
