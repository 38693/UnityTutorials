using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private Renderer r;
    private AudioSource source;
    private ParticleSystem ps;
    private KeepScore scoreScript;
    void Start()
    {
        r = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();

        if (ps != null)
        {
            ps.Stop();
        }

        scoreScript = FindObjectOfType<KeepScore>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Pickup hit by player!");

            r.enabled = false;
            if (source != null)
            {
                source.Play();
            }

            if (ps != null)
            {
                ps.Play();
            }
            if (scoreScript != null)
            {
                scoreScript.AddScore(5);
            }
            Destroy(gameObject, 0.5f);
        }
    }
}