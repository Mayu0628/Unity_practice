using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // floatという型のspeedという変数に1.0fを代入 publicはこのスクリプト以外でも使えるという意味
    public float speed =5.0f;
    // Start is called before the first frame update 起動直後に実行される
    void Start()
    {

    }

    // Update is called once per frame 毎フレーム、ずっと実行
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.transform.position.x > -4)
               this.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            if(this.transform.position.x < 4)
               this.transform.position += Vector3.right * speed * Time.deltaTime;
        }

    }
}
