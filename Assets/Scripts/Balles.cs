using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balles : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float Vitesse;



    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*Vitesse;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ennemis Ennemis_Touche = collision.gameObject.GetComponent<Ennemis>();
        if(Ennemis_Touche != null)
        {
            Ennemis_Touche.ReduceHP(1);
            Destroy(gameObject);
        }
    }

}
