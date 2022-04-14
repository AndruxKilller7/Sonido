using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour
{
    AudioSource sound;
    public int min=6;
    public int max = 9;
    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }
     IEnumerator Start()
    {
        while (true)
        {
            int t = Random.Range(min, max+1);
            yield return new WaitForSeconds(t);
            sound.Play();
        }
   

        //Debug.Log("start 1");
        //sound.Play();
        //yield return new WaitForSeconds(6);
        //Debug.Log("start 2");
        //sound.Play();
        //yield return new WaitForSeconds(5);
        //Debug.Log("start 3");
        //sound.Play();
    }
    void Update()
    {
        
    }
}
