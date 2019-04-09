using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StageGroupCtr : MonoBehaviour
{

    public List<StageAnim> stageAnims = new List<StageAnim>();
    // Start is called before the first frame update

    public PlayableDirector playableDirector; 
    void Start()
    {
        EventCenter.AddListener(EventDefine.PlayAnimation, playAnim);
        EventCenter.AddListener(EventDefine.StopAnimation, stopAnim);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAnim() {
        playableDirector.Play();
    }

    public void stopAnim() {
        playableDirector.Stop();

    }

    public void ShowStage(int index) {
        stageAnims[index].show();
    }

    public void HideStage(int index) {
        stageAnims[index].Hide();
    }
}
