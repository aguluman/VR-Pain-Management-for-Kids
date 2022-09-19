using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPrincess : MonoBehaviour
{
    void Start()
 {
     StartCoroutine(SelfDestruct());
 }


    IEnumerator SelfDestruct()
 {
     yield return new WaitForSeconds(65f);
     Destroy(gameObject);
 }
}