using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [SerializeField] AudioSource audioSourceMusic,audioSourceSFX;
    [SerializeField] List<AudioClip> clips;
    bool earthquakeIsPlay;
    void Awake()
    {
        audioSourceMusic.clip = clips.Find(a=> a.name.Equals("InGameMusic"));
        audioSourceMusic.Play();
    }
    void Start()
    {
        Instance = this;
        //audioSource.PlayOneShot(clips.Find(a=> a.name.Equals("mainGameMusic")));
    }

    
    void Update()
    {
        
        if(Earthquake.earthquakeIsStart &&!earthquakeIsPlay){
            earthquakeIsPlay = true;
            StartCoroutine(earthquakeMusicTimer("deprem","InGameMusic",Earthquake.timer));
        }
    }
    public void playOneShotAudioClip(string clipName){
        audioSourceSFX.PlayOneShot(clips.Find(a=> a.name.Equals(clipName)));
    }
    IEnumerator earthquakeMusicTimer(string firstAudio,string secondAudio,float transitionTime){
        audioSourceMusic.Pause();
        audioSourceMusic.clip = clips.Find(a=> a.name.Equals(firstAudio));
        audioSourceMusic.Play();
        yield return new WaitForSeconds(transitionTime);
        audioSourceMusic.Pause();
        audioSourceMusic.clip = clips.Find(a=> a.name.Equals(secondAudio));
        audioSourceMusic.Play();
    }
}
