using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Joueur : MonoBehaviour
{
    public GameObject Balle;
    public Transform Parent;
    public Transform LimitL;
    public Transform LimitR;
    public int Pv_Joueur = 15;
    public int Score = 0;

    public float Vitesse = 0.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*Vitesse;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right*Vitesse;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Balle, new Vector2(Parent.position.x, Parent.position.y + 0.7f), Parent.rotation);
        }

        if(transform.position.x < LimitL.position.x)
        {
            transform.position = new Vector3(LimitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > LimitR.position.x)
        {
            transform.position = new Vector3(LimitL.position.x, transform.position.y, transform.position.z);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Pv_Joueur -= 1;
        if (Pv_Joueur <= 0)
        {
            Destroy(gameObject);
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


}
