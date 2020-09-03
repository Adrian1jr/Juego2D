using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //objeto de bulletPrefab
    public GameObject bulletPrefab;
    //con esta variable sabemos quien tiene el arma un personaje enemigo etc.
    public GameObject shooter;

    private Transform _firepoint;

    //este es el mejor para agarrar cualquier otro tipo de referencia u objetos etc.
    void Awake() 
    {
        //hijo firepoint con el metodo transform y encontrarlo (find) buscar en cualquier transform el firepoint y regresarlo.
        //con esto hacemos que nuestro arma busque el firepóint y pueda disparar con movimiento a derecha o izq
        _firepoint = transform.Find("Firepoint");
    }

    // Start is called before the first frame update
    void Start()
    {
       shoot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void shoot()
    {
        //con esto primero es para que el juego no se cierre viendo que los objetos no sean nulos 
        if(bulletPrefab != null && _firepoint != null && shooter != null)
        {
            //instancia de objeto en la weapon con la rotation de unity, quaternion es un tipo de rotaciones complejo
            //instanciandolo como un gameobject
            GameObject myBullet = Instantiate(bulletPrefab, _firepoint.position, Quaternion.identity) as GameObject;

             //con esto tomamos la bala de la clase bullet 
             Bullet bulletComponent = myBullet.GetComponent<Bullet>();
                
            //si la persona o objeto esta mirando a la izquierda haz una cosa si es a la derecha igual depende de la direccion    
            if(shooter.transform.localScale.x < 0f)
            {
                //vector left es para ahorrarse lo de new Vector2(-1f,0f) es lo mismo hacer eso que el left y es lo mismo en right pero aya es valor positivo en el 1
                bulletComponent.direction = Vector2.left;
            }
            else
            {
                bulletComponent.direction = Vector2.right;
            }
        }
    }
}
