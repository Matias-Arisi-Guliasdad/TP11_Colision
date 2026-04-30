using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive_Area : MonoBehaviour
{
    public ScoreUIManager scoreUIMgr;
    public HealthUIManager HealthUI;
   void OnCollisionEnter(Collision papu)
   {
    if(papu.gameObject.CompareTag("Pickable"))
    {
        Destroy(papu.gameObject);
        scoreUIMgr.AddPointAndUptateScore();
     
    }
    if(papu.gameObject.CompareTag("HurtingPickable")){
        Destroy(papu.gameObject);
        HealthUI.ReducePointAndUptadeHealth();
    }
   }
}
