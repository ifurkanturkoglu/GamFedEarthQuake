using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [SerializeField] AudioSource audioSource;
    [SerializeField] List<AudioClip> clips;
    bool earthquakeIsPlay;
    void Awake()
    {
        audioSource.clip = clips.Find(a=> a.name.Equals("mainGameMusic"));
        audioSource.Play();
    }
    void Start()
    {
        Instance = this;
        //audioSource.PlayOneShot(clips.Find(a=> a.name.Equals("mainGameMusic")));
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            
        }
        if(Earthquake.earthquakeIsStart &&!earthquakeIsPlay){
            earthquakeIsPlay = true;
            StartCoroutine(earthquakeMusicTimer("deprem","mainGameMusic",Earthquake.timer));
        }
    }
    public void playOneShotAudioClip(string clipName){
        audioSource.PlayOneShot(clips.Find(a=> a.name.Equals(clipName)));
    }
    IEnumerator earthquakeMusicTimer(string firstAudio,string secondAudio,float transitionTime){
        audioSource.Pause();
        audioSource.clip = clips.Find(a=> a.name.Equals(firstAudio));
        audioSource.Play();
        yield return new WaitForSeconds(transitionTime);
        audioSource.Pause();
        audioSource.clip = clips.Find(a=> a.name.Equals(secondAudio));
        audioSource.Play();
    }
}
