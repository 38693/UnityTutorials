using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class KillOnHit : MonoBehaviour
 {
     public string targetTag;    
    // public GameObject effect; 
     private AudioSource audioSource; 

     private Hearts heartsScript;
 
     void Start()
     {
         audioSource = GetComponent<AudioSource>();
     }
 
     private void OnCollisionEnter(Collision coll)
    {
        handleHit(coll.gameObject);
    }
    private void OnTriggerEnter(Collider coll)
    {
        handleHit(coll.gameObject);
    }
    private void handleHit(GameObject other) {
        if (other.tag == targetTag)
        {
           // GameObject expl = Instantiate(effect);
           // expl.transform.position = other.transform.position;
           // Destroy(expl, 2f);
            if (targetTag == "Player")
            {
                if (heartsScript == null)
                {
                    heartsScript = FindObjectOfType<Hearts>();
                }
                
                heartsScript.Lives--;
                if (heartsScript.Lives == 0)
                {
                    Destroy(other, 0.1f);
                }
            }
            else {
                Destroy(other, 0.1f);
            }
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
 }