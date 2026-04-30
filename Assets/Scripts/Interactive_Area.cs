using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive_Area : MonoBehaviour
{
   void OnCollisionEnter(Collision papu)
   {
    if(papu.gameObject.CompareTag("Pickable"))
    {
        Destroy(papu.gameObject);
    }
   }
}
