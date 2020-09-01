using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardVolume : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
         playerShip playerShip = other.gameObject.GetComponent<playerShip>();

        if (playerShip != null)
            {
                playerShip.Kill();
            }       
    }

}
