using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeBarGroupCtr : MonoBehaviour
{

    public List<VolumBarCtr> volumBarCtrs = new List<VolumBarCtr>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowAll() {
        foreach (var item in volumBarCtrs)
        {
            item.ShowBar();
        }
    }

    public void HideAll() {
        foreach (var item in volumBarCtrs)
        {
            item.HideBar();
        }
    }
}
