using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;
using UnityEngine.Playables;

public class ParticleCtr : MonoBehaviour
{
    public PlayableAsset[] TIME_SHOW_HIDE;
    public PlayableDirector playableDirector;
    public bool enable_DEBUG_Interaction;

    private bool isEnable = true;

    public string id;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (enable_DEBUG_Interaction) {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                ShowParticle();
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                HideParticle();
            }
        }
    }

    public void ShowParticle() {
        if (!isEnable) {
            isEnable = true;
            playableDirector.Play(TIME_SHOW_HIDE[0]);
        }
    }

    public void HideParticle() {
        if (isEnable)
        {
            isEnable = false;
            playableDirector.Play(TIME_SHOW_HIDE[1]);
        }
    }
}
