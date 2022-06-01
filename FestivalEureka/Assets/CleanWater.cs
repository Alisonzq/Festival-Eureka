using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanWater : MonoBehaviour
{
    public GameObject EauPropre;
    public GameObject EauPollue;

    void OnCollisionEnter (Collision target) 
    {
      if( target.gameObject.tag.Equals("bloc") == true )
      {
        //Écrit le code en dessous de cette ligne
        EauPropre.SetActive (true);
        EauPollue.SetActive(false); 
      }
    }
}


