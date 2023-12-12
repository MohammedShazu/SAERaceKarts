using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusic : MonoBehaviour
{
    public bool playMusic;
    public GameObject MusicPlayer;
    // Start is called before the first frame update
    void Start()
    {
        playMusic = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(playMusic == true)
        {
            MusicPlayer.SetActive(true);
        }
        else
        {
            MusicPlayer.SetActive(false);
        }
    }
}
