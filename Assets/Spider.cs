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
        spider = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    public void move()
    {
        float v = Input.GetAxis("Vertical");
        if(v != 0)
        {
            anim.SetFloat("walk", v);
        }
        spider.Translate(v * 20 * Time.deltaTime, 0, 0);
        float h = Input.GetAxis("Horizontal");
        spider.Rotate(0, 20 * Time.deltaTime * h, 0, Space.World);
    }
}
