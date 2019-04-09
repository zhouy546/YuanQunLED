using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorggleDebugGrid : MonoBehaviour
{
    public List<Image> images = new List<Image>();
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        hide();

        EventCenter.AddListener(EventDefine.PlayAnimation, PlayAnim);
    }


    

    public void PlayAnim() {
        animator.SetTrigger("PlayVideo");
    }

    public void SetToIdle() {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            show();
        }
        else if (Input.GetKeyDown(KeyCode.A)) {
            hide();
        }
    }

    public void show() {
        foreach (var item in images)
        {
            item.enabled = true;
        }
    }

    public void hide() {
        foreach (var item in images)
        {
            item.enabled = false;
        }
    }
}
