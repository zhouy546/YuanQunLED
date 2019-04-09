using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private float WaveIntensity = 1f;
    private float Y_StartLocalPos;
    private float speed;

    float RandomStart = 0;
    private float LocalStartPosY;
    private float LocalHidePosY=-1f;
    public bool b = false;
    // Start is called before the first frame update
    void Start()
    {
        LocalStartPosY = this.transform.localPosition.y;

        RandomStart = Random.Range(-Mathf.PI, Mathf.PI);
        speed = Random.Range(0.1f, 0.5f);
        WaveIntensity = Random.Range(0.1f, 0.3f);
        Y_StartLocalPos = this.transform.localPosition.y;
        //b = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (b)
        {
         //  UpdateMovement();
        }

    }

    public void UpdateMovement()
    {
        //float y = 

        float y = Y_StartLocalPos + WaveIntensity * Mathf.Sin(Time.time * speed + RandomStart);

        Vector3 LocalPos = new Vector3(this.transform.localPosition.x, y, this.transform.localPosition.z);

        this.transform.localPosition = LocalPos;
    }

    public void HideBall() {
        LeanTween.moveLocalY(this.gameObject, LocalHidePosY, 0.25f).setEase(LeanTweenType.easeInOutQuad);
    }

    public void ShowBall() {
        LeanTween.moveLocalY(this.gameObject, LocalStartPosY, 1f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);

    }


}
