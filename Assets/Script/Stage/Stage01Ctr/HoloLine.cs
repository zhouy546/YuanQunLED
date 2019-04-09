using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class HoloLine : MonoBehaviour
{

    public VisualEffect visualEffect;

    private bool isEnable = true;
    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        if (!isEnable) {
            visualEffect.SetBool("TurnOnLight", true);
            isEnable = true;
        }
    }

    public void Hide() {
        if (isEnable) {
            visualEffect.SetBool("TurnOnLight", false);
            isEnable = false;
        }
    }
}
