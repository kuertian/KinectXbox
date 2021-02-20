using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovieTest : MonoBehaviour
{
    public GameObject gameObj;
    public GameObject RawImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayMovie()
    {
        gameObj.SetActive(true);
        RawImage.SetActive(true);
    }
    public void CloseMovie()
    {
        gameObj.SetActive(false);
        RawImage.SetActive(false);
    }
}
