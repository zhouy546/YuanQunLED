using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LineGroupCtr : MonoBehaviour
{

    public PlayableAsset[] TIME_SHOW_HIDE;
    public PlayableDirector playableDirector;

    public bool enable_DEBUG_Interaction;
    private bool isenable = true;
    // Start is called before the first frame update
    void Start()
    {
        playableDirector.Play(TIME_SHOW_HIDE[0]);
    }

    // Update is called once per frame
    void Update()
    {
        if (enable_DEBUG_Interaction)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                playableDirector.Play(TIME_SHOW_HIDE[0]);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                playableDirector.Play(TIME_SHOW_HIDE[1]);
            }
        }
    }

    public void Show() {
        if (!isenable) {
            playableDirector.Play(TIME_SHOW_HIDE[0]);
            isenable = true;
        }
    }

    public void Hide() {
        if (isenable) {
            playableDirector.Play(TIME_SHOW_HIDE[1]);
            isenable = false;
        }
    }
}
