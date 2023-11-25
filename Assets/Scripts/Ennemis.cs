using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis : MonoBehaviour
{
    public GameManager gameManager;
    public int Pv;
    public GameObject Bonus;
    public GameObject Balle_Ennemis;
    public GameObject Ennemi_Gros;
    public int Ennemi_mort = 0;
    public float Timer;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
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
                Timer = Random.Range(1f,40f);
            }
        }

        if (gameManager.Ennemis_Morts == 5)
        {
            Instantiate(Ennemi_Gros, transform.position, Quaternion.Euler(0, 3, 3));
            gameManager.Ennemis_Morts = 0;
        }

    }
    public void ReduceHP(int amount)
    {
        Pv -= amount;
        if (Pv <= 0)
        {
            Instantiate(Bonus, transform.position, Quaternion.Euler(0, 1, 2));
            gameManager.Ennemis_Morts++;
            Destroy(gameObject);
        }
    }

}
