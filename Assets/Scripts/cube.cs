using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello your a bitch");
        //GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
         BoxCollider collider = GetComponent<BoxCollider>();
            float bounciness = collider.material.bounciness;
            Debug.Log("Bounciness: " + bounciness);


    }

    // Update is called once per frame
    void Update()
    { float yPos=transform.position.y;
        if (yPos >= 1.424494)
        {
            Debug.Log("y position: " + yPos);
        }

       
       

    }
}
