using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private AudioSource audioSource;
    public ParticleSystem ParticleSystem;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Player Player))
        {
            Player.ReachFinish();
            audioSource.Play();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Player Player))
        {
            Player.ReachFinish();
            audioSource.Play();
            var emission = ParticleSystem.emission;
            emission.enabled = true;
        }
    }
}
