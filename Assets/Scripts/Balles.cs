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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ennemis Ennemis_Touche = collision.gameObject.GetComponent<Ennemis>();
        if(Ennemis_Touche == true)
        {

            Ennemis_Touche.Pv -= 1;



        }
        Destroy(gameObject);
    }

}
