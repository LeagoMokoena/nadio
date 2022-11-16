using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXmanger : MonoBehaviour
{
    public static SFXmanger Instance { get; private set; }

    public Hashtable hash;
    public Hashtable _hash;
    public AudioSource applause;
    public AudioClip _applause;
    public AudioSource check;
    public AudioClip _check;
    public AudioSource engine;
    public AudioClip _engine;
    public AudioSource crash;
    public AudioClip _crash;
    public AudioSource death;
    public AudioClip _death;
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

    // Start is called before the first frame update
    void Start()
    {
        hash = new Hashtable();
        hash.Add(1, "applause");
        hash.Add(2, "check");
        hash.Add(3, "engine");
        hash.Add(4, "crash");
        hash.Add(5, "death");

        Dictionary<int, AudioSource> audio = new Dictionary<int, AudioSource>();
        audio.Add(1, applause);
        audio.Add(2, check);
        audio.Add(3, engine);
        audio.Add(4, crash);
        audio.Add(5, death);

        _hash = new Hashtable(audio);
    }


    public void PlaySound(string soundName)
    {
        switch (soundName)
        {
            case "applause": applause.PlayOneShot(_applause);
                break;
            case "check": check.PlayOneShot(_check);
                break;
            case "engine": engine.PlayOneShot(_engine);
                break;
            case "crash": crash.PlayOneShot(_crash);
                break;
            case "death": death.PlayOneShot(_death);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
