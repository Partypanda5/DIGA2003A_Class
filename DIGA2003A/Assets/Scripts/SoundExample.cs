using UnityEngine;

public class SoundExample : MonoBehaviour
{
    public AudioClip[] Clips;
    private AudioSource audioSource;
    public ButtonSoundType soundType;

    public enum ButtonSoundType
    {
        Cute,
        Scary,
        Scifi
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(ButtonSoundType soundType)
    {
        switch (soundType)
        {
            case ButtonSoundType.Cute:
                audioSource.PlayOneShot(Clips[0]);
                break;

            case ButtonSoundType.Scary:
                audioSource.PlayOneShot(Clips[1]);
                break;

            case ButtonSoundType.Scifi:
                audioSource.PlayOneShot(Clips[2]);
                break;
        }
    }

    public void PlayAssignedSound()
    {
        PlaySound(soundType);
    }
}