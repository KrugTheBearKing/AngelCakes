using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(AudioClip))]
public class CollectableCakes : MonoBehaviour
{
    public AudioClip collectableSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //TODO: imp
            GetComponent<AudioSource>().PlayOneShot(collectableSound);
            GetComponent<Renderer>().enabled = false;
            GameObject.Destroy(gameObject, collectableSound?.length ?? 0.0f);
            Destroy(this);
        }
    }
}
