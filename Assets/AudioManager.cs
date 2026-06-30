using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound gameOverSound;
    AudioSource source;

    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
    }

    public void playGameOver()
    {
        source.clip = gameOverSound.clip;
        source.volume = gameOverSound.volume;
        source.Play();
    }
}
