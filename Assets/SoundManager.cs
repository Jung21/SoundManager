using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource _musicSource, _effectSource, _spawnsource;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip);

    }


    public void ChanngeMasterVolume(float value)
    {

        AudioListener.volume = value;

    }

    public void ToggleEffects()
    {
        _effectSource.mute = !_effectSource.mute;


    }

    public void ToggleMusic()
    {
        _musicSource.mute = !_musicSource.mute;


    }


    public void ToggleSpawn()
    {
        _musicSource.mute = !_musicSource.mute;


    }

}
