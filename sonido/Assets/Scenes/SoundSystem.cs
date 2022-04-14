using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    public static SoundSystem instance;

    public AudioClip audioCamina;
    public AudioClip audioSalto;
    public AudioClip audioRecarga;
    public AudioClip audioDisparo;
    public AudioClip audioMuerte;

    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource audioSource3;

    private void Awake()
    {
        if (SoundSystem.instance == null)//si no tiene nada asigando se lo asigna 
        {
            SoundSystem.instance = this;

        }
        else if (SoundSystem.instance != this)//si tiene asigando y no es la instancia se destuye
        {
            Destroy(gameObject);

        }
    }

    public void PlayCamina()
    {
        PlayAudioClip(audioCamina);
    }
    public void PlaySalto()
    {
        PlayAudioClip2(audioSalto);
    }
    public void PlayRecarga()
    {
        PlayAudioClip2(audioRecarga);
    }
    public void PlayDisparop()
    {
        PlayAudioClip3(audioDisparo);
    }

    public void PlayDead()
    {
        PlayAudioClip(audioMuerte);
    }

   


    private void PlayAudioClip(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
    private void PlayAudioClip2(AudioClip audioClip2)
    {
        audioSource2.clip = audioClip2;
        audioSource2.Play();
    }
    private void PlayAudioClip3(AudioClip audioClip3)
    {
        audioSource3.clip = audioClip3;
        audioSource3.Play();
    }

    private void OnDestroy()
    {
        if (SoundSystem.instance == this)
        {
            SoundSystem.instance = null;
        }
    }
}
