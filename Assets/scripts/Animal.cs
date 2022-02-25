using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    Rigidbody2D myBody;

    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //1. definir limites
        //2 cambiar velocidad si la posicion X es >,< de esos limites 
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }



}
