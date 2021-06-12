using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
   
    void Update()
    {
        if (transform.localPosition.y <= -50.0f)
        {
            Destroy(gameObject);

            //GameObject go = GameObject.Find("Text");
            //go.GetComponent<TextCount>().AddCount();

            FindObjectOfType<TextCount>().AddCount();
        }
        
    }
}
