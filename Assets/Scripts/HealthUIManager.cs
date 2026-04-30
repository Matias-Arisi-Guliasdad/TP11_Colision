using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthUIManager : MonoBehaviour
{
    public TextMeshProUGUI txtHealth;
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        txtHealth.text =health.ToString();
    }
    public void ReducePointAndUptadeHealth(){
        health--;
           txtHealth.text = health.ToString();
        if(health<=0){
            txtHealth.text="Perdiste";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
