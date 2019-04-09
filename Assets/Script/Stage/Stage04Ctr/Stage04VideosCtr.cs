using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage04VideosCtr : MonoBehaviour
{
    public List<VideoCanvasCtr> videoCanvasCtrs = new List<VideoCanvasCtr>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VideosHide() {
        foreach (var item in videoCanvasCtrs)
        {
            item.Hide();
        }
    }

    public void VideosShow() {
        foreach (var item in videoCanvasCtrs)
        {
            item.Show();
        }
    }
}
