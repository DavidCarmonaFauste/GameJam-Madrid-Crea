using UnityEngine;

public class MusicClass : MonoBehaviour
{
    private static MusicClass _instance;
    private AudioSource _audioSource;
    private void Awake()
    {
        
        _audioSource = GetComponent<AudioSource>();

        //if we don't have an [_instance] set yet
        if (!_instance)
            _instance = this;
        //otherwise, if we do, kill this thing
        else
            Destroy(this.gameObject);


        DontDestroyOnLoad(this.gameObject);
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}