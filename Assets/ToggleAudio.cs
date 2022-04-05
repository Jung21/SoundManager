using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
    [SerializeField] private bool _toggleMusic, _toggleEffects, _toggleSpawn;


    public void Toggle()
    {

        if (_toggleEffects) SoundManager.Instance.ToggleEffects();

        if (_toggleMusic) SoundManager.Instance.ToggleMusic();

        if (_toggleSpawn) SoundManager.Instance.ToggleSpawn();


    }
}
