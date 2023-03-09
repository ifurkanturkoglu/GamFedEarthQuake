using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renkdegistirme : MonoBehaviour
{
    public float lerpTime = 1f; 
    public Color startColor = Color.white; 
    public Color endColor = Color.black; 

    private Renderer cubeRenderer;
    private float currentLerpTime = 5f;

    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        currentLerpTime += Time.deltaTime;

        if (currentLerpTime > lerpTime)
        {
            currentLerpTime = 0f;
            Color temp = startColor;
            startColor = endColor;
            endColor = temp;
        }

        float t = currentLerpTime / lerpTime;
        cubeRenderer.material.color = Color.Lerp(startColor, endColor, t);
    }
}
