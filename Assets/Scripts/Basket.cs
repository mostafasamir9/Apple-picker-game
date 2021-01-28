using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public float speed = 0.5f;

        public static bool point = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 pos = this.transform.position;
            pos.x -= speed;
            this.transform.position = pos;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 pos = this.transform.position;
            pos.x += speed;
            this.transform.position = pos;
        }

    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
            point = true;
        }


    }
}
