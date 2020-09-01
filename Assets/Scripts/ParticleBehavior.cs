using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBehavior : MonoBehaviour
{
    [SerializeField] ParticleSystem shipThrusterParticles_01;

    [SerializeField] ParticleSystem shipThrusterParticles_02;
    private void Update()
    {
        //shipThrusterParticles.SetActive(false);

        if (Input.GetKey(KeyCode.W))
        {
            shipThrusterParticles_01.Play();

            shipThrusterParticles_02.Play();
        }
            else
        {
            shipThrusterParticles_01.Stop();

            shipThrusterParticles_02.Stop();
        }
    }


}
