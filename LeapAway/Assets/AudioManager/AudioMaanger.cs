using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioMaanger : MonoBehaviour
{
    public SOUND[] sounds;

    public static AudioMaanger instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach(SOUND s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        SOUND s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound : " + name + " not found! ");
            return; 
        }
        s.source.Play();
    }
}
