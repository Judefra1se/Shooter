using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public int Nombre_Points;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();    
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.score++;
        Destroy(gameObject);
    }

    
}
