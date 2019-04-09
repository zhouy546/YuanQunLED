using RenderHeads.Media.AVProVideo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoCanvasCtr : MonoBehaviour
{
    public MediaPlayer mediaPlayer;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayVideo() {
        mediaPlayer.Play();
    }

    private void stopVideo() {
        //mediaPlayer.Stop();
    }

    public void Show() {
        animator.SetBool("Show", true);
        PlayVideo();
    }

    public void Hide() {
        animator.SetBool("Show", false);
        //stopVideo();
    }


}
