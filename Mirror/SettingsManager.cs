
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;
using TMPro;

public class SettingsManager : UdonSharpBehaviour
{
    [SerializeField] AudioClip click;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void ToggleSetting()
    {
        audio.PlayOneShot(click);
    }
}
