using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SoundSystem.instance.PlayDisparop();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            SoundSystem.instance.PlayRecarga();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            SoundSystem.instance.PlayDead();
        }
    }
}
