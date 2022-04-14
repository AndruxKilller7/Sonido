using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trueno : MonoBehaviour
{
    public AnimationCurve intesidad;

    [Range(0, 1)]
    public float tiempo;
    Light luz;
    
    void Start()
    {
        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        luz.intensity = intesidad.Evaluate(tiempo);
    }
}
