using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingKeys : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 direction;
    public float speed = 2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse
        //cuando se ha pulsado un boton
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log("button pressed");
        // }
        // //cuando esta pulsado un boton
        // //si cambiamos el 0 por un 1 para click derecho
        // //si es 2 es el click de enmedio del mouse
        // if (Input.GetMouseButton(0))
        // {
        //     Debug.Log("button is pressed");
        // }
        // //cuando el boton se suelta
        // if (Input.GetMouseButtonUp(0))
        // {
        //     Debug.Log("button released");
        // }

        //para tener control del teclado
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("derecha");  
            Vector2 movement = direction.normalized * speed * Time.deltaTime;   
            transform.Translate(movement);
  
        }

         if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("izquierda");  
            Vector2 movement = direction.normalized * speed * Time.deltaTime;   
            transform.Translate(movement);
            direction.x=0;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("brincar");  
            Vector2 movement = direction.normalized * speed * Time.deltaTime;   
            transform.Translate(movement); 
        }

         if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("brincar");  
            Vector2 movement = direction.normalized * speed * Time.deltaTime;   
            transform.Translate(movement);
  
        }

        // 3. Getting axis for movement
		float horizontal = Input.GetAxis("Horizontal"); // Values from -1f to 1f
		float vertical = Input.GetAxis("Vertical"); 	// Values from -1f to 1f

		if (horizontal < 0f || horizontal > 0f) {
			Debug.Log("Horizontal axis is " + horizontal);
		}
		if (vertical < 0f || vertical > 0f) {
			Debug.Log("Vertical axis is " + vertical);
		}

        //asi lo recomienda unity por que tiene preestablecidos dentro de el como por ejemeplo para los joysticks y eso en teoria lo veo como unviersal
        // if (Input.GetKeyDown("jump"))
        // {
        //     Debug.Log("usando esto. puedo hacer que el jugador salte por ser el espacio");
        // }
    }
}
