using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ennemis ennemiTouche = collision.gameObject.GetComponent<Ennemis>();
        if(ennemiTouche == true)
        {

            ennemiTouche.pv -= 1;



        }
        Destroy(gameObject);
    }

}
