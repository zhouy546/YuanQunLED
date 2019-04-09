using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class BannerValue {
    public float DefaultYPos;
    public float FirstYPos;
    public float SecondPos;

    public string DefaultUDP;
    public string FirstUDP;
    public string SecondUDP;
}

public class BannerCtr : MonoBehaviour
{
    public BannerValue bannerValue;
    public Animator[] animators;
    // Start is called before the first frame update
    void Start()
    {
        toDefaultPos();

        ValueSheet.udp_Action.Add(bannerValue.DefaultUDP, toDefaultPos);
        ValueSheet.udp_Action.Add(bannerValue.FirstUDP, FirstPos);
        ValueSheet.udp_Action.Add(bannerValue.SecondUDP, SecondPos);

        ValueSheet.bannerCtrs.Add(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void toDefaultPos() {
        LeanTween.moveLocalY(this.gameObject, bannerValue.DefaultYPos, 0.5f).setOnComplete(delegate () {
            IdleFirstNode();
            IdleSecondNode();
        });

    }

    public void FirstPos() {
        LeanTween.moveLocalY(this.gameObject, bannerValue.FirstYPos, 0.5f).setOnComplete(ShowFirstNode);
        foreach (var item in ValueSheet.bannerCtrs)
        {
            if (item != this) {
                item.toDefaultPos();
            }
        }
    }

    public void SecondPos() {
        LeanTween.moveLocalY(this.gameObject, bannerValue.SecondPos, 0.5f).setOnComplete(ShowSecondNode);
        foreach (var item in ValueSheet.bannerCtrs)
        {
            if (item != this)
            {
                item.toDefaultPos();
            }
        }
    }

    public void ShowFirstNode() {
        animators[0].SetTrigger("Show");
    }
    public void IdleFirstNode()
    {
        animators[0].SetTrigger("Idle");
    }


    public void ShowSecondNode() {
        animators[1].SetTrigger("Show");
    }

    public void IdleSecondNode()
    {
        animators[1].SetTrigger("Idle");
    }
}
