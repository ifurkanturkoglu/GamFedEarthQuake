using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
public class Earthquake : MonoBehaviour
{
    [SerializeField] PlayableDirector playable;
    [SerializeField] GameObject[] fallObjects;
    [SerializeField]float timer = 20;
    [SerializeField] AudioSource audioSource;
    [SerializeField]public static bool earthquakeIsStart;
    

    void Start()
    {
        fallObjects = GameObject.FindGameObjectsWithTag("fallObject");
        StartCoroutine(EarthQuakeTimer());
    }


    void Update()
    {
        if(EarthquakeBag.qitFinish && !earthquakeIsStart){
            playable.Play();
        }
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        if(earthquakeIsStart){
            audioSource.Stop();
        }

    }
    IEnumerator EarthQuakeTimer()
    {
        while (timer >= 0)
        {
            int random = Random.Range(0, fallObjects.Length);
            fallObjects[random].GetComponent<FallObject>().fall();
            yield return new WaitForSeconds(1);
        }
    }
}
