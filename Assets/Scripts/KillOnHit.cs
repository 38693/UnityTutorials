using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class KillOnHit : MonoBehaviour
 {
     public string targetTag;    
     public GameObject effect; 
     private AudioSource audioSource; 
 
     void Start()
     {
         audioSource = GetComponent<AudioSource>();
     }
 
     private void OnCollisionEnter(Collision coll)
     {
         CheckCollision(coll.gameObject);
     }
 
     private void OnTriggerEnter(Collider coll)
     {
         CheckCollision(coll.gameObject);
     }
 
     private void CheckCollision(GameObject collidedObject)
     {
         if (collidedObject.CompareTag(targetTag))
         {
             //GameObject expl = Instantiate(effect, transform.position, Quaternion.identity);
             //Destroy(expl, 2f); 
 
             Destroy(collidedObject, 0.1f);  
             if (audioSource != null)
             {
                 audioSource.Play();
             }
             Destroy(gameObject, 0.1f);
         }
     }
 }