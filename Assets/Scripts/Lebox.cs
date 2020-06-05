using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lebox : MonoBehaviour{

    void onCollisionEnter(Collision col) 
    {
        if (col.gameObject.name == "box") 
        {
            Destroy(col.gameObject);
        }
    }


}
