using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{

    Transform spider;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //obtengo la componente transform que me permitira mover a la araña por el terreno que he creado
        spider = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //cada frame voy a estar llamando la funcion move que maneja los movimientos a traves de inputs
        move();
    }

    //en esta funcion obtengo los inputs del usuario y los guardo en variables tipo float para mover o rotar laa araña haciendo uso del valor que obtuvo en sus respectivos vectores.
    public void move()
    {
        float v = Input.GetAxis("Vertical");
        if(v != 0)
        {
            //inicio la animacion de caminar cuando se recibe un input
            anim.SetFloat("walk", v);
        }
        spider.Translate(v * 20 * Time.deltaTime, 0, 0);
        float h = Input.GetAxis("Horizontal");
        spider.Rotate(0, 20 * Time.deltaTime * h, 0, Space.World);
    }
}
