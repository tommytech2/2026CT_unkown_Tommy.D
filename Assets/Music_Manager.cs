using UnityEngine;

public class Music_Manager : MonoBehaviour
{
    [Header("------------- Audio Source ------------")]
    [SerializeField] AudioSource musicSource;

    [Header("------------- Audio Clip ------------")]
    public AudioClip Moonspire;


    private void Start()
    {
        musicSource.clip = Moonspire;
        musicSource.Play();
    }





}
