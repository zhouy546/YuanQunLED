using RenderHeads.Media.AVProVideo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugVideoCtr : MonoBehaviour
{
    public MediaPlayer mediaPlayer;
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.AddListener(EventDefine.PlayAnimation, playVideo);

        EventCenter.AddListener(EventDefine.StopAnimation, StopVideo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playVideo() {
        mediaPlayer.Play();
    }

    public void StopVideo() {
        mediaPlayer.Play();
    }
}
