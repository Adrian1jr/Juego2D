using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //variables
    //esta nos sirve para la velocidad de la bala
    public float speed = 2f;
    //variable del vector para la direccion
    public Vector2 direction;

    //variable float livintTime para el tiempo que estara la bala y despues explote
    public float livintTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //destruye el objeto despues de el livinTime que pase que son 2f
        Destroy(gameObject,livintTime);
    }

    // Update is called once per frame
    void Update()
    {
        //variable temporal de tipo vector2 para el movimiento 
        //vector normalizado con magnitud 1 multiplicado x el speed
        Vector2 movement = direction.normalized * speed * Time.deltaTime;

        //con esto le vamos a decir que frame tiene que tener
        //mi posicion + la que tengo + la que me quieren mover 
        //esto es un objeto
        //transform eso es un vector de 2
        //transform.position = new Vector2(transform.position.x + movement.x, transform.position.y + movement.y);

        //el metodo translate es de unity para hacer el movimiento con 1 sola linea sin hacer todo lo de arriba
        transform.Translate(movement);
    }
}
