using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] List<AudioClip> clips;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Earthquake.earthquakeIsStart){
            audioSource.PlayOneShot(clips.Find(a=> a.name.Equals("deprem")));
        }
    }
}
