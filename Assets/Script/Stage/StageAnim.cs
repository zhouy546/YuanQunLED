using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StageAnim : MonoBehaviour
{
    public int id;
    public PlayableDirector playableDirector;
    public PlayableAsset[] playableAssets = new PlayableAsset[2];

    private bool isenable = true;
    public bool enable_DEBUG_Interaction;
    // Start is called before the first frame update
    void Start()
    {
        Hide();

  //      EventCenter.AddListener(EventDefine.StopAnimation,);
    }

    // Update is called once per frame
    void Update()
    {
        if (enable_DEBUG_Interaction)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Hide();
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                show();
            }
        }
    }

    public void show() {
        if (!isenable) {
            playableDirector.Play(playableAssets[0]);
            isenable = true;
        }
    }

    public void  Hide() {
        if (isenable) {
            playableDirector.Play(playableAssets[1]);
            isenable = false;
        }
    }
}
