using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Text cheeseCounter;

    private int cheese = 0;


    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Collectible")){
            Collect(other.GetComponent<Collectible>());
        }
    }

    private void Collect(Collectible collectible){
        if(collectible.Collect()){
            if(collectible is CheeseCollectible){
                cheese++;
            } 
            UpdateGUI();
        } 
    }

    private void UpdateGUI(){
       cheeseCounter.text = cheese.ToString();
    }
}
