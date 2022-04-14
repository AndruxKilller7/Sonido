using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class castle : MonoBehaviour
{
    public Transform player;
    public Transform sol;
    public Transform rotdia;
    public Transform rotnoche;

    public GameObject prototipo;

    public float distance;
    [Range (0,1)]
    public float interpolacion;

    public ParticleSystem gotasLluvia;
   
    IEnumerator Start()
    {
        while (true)
        {
      
            yield return new WaitForSeconds(Random.Range(3, 8));
            //esperar hasta que 
            yield return new WaitUntil(
                ()=> { return (interpolacion == 0); }
                );
            Instantiate(prototipo);
            //espera mientras
            //yield return new WaitWhile();

        }           
    }
   
    void Update()
    {
     distance=  Vector3.Distance(player.position, transform.position);
         interpolacion = Mathf.InverseLerp(3, 18, distance);

        Quaternion rotacion=  Quaternion.Lerp(rotnoche.rotation,rotdia.rotation,interpolacion);
        sol.rotation = rotacion;

      //  if (interpolacion<0.5f && gotasLluvia.isPlaying==false)
        {
           // ParticleSystem.EmissionModule em = gotasLluvia.emission;
           // em.rateOverTimeMultiplier = 50;
           // gotasLluvia.Play();
            //gotasLluvia.emission.rateOverTime
        }
        if (interpolacion > 0.5f)
        {
           // gotasLluvia.Stop();
            //gotasLluvia.emission.rateOverTime
        }

    }
}
