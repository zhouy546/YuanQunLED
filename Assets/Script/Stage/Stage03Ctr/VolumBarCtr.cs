using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumBarCtr : MonoBehaviour
{

    private bool isenable = true;

    public Color emissionColor;
    public MeshRenderer meshRenderer;

    public float HeightVal;

    public bool enable_DEBUG_Interaction;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer.material.SetColor("_EmissionColor", emissionColor);
        //HideBar();
    }

    // Update is called once per frame
    void Update()
    {
        if (enable_DEBUG_Interaction)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                HideBar();
            }
            else if(Input.GetKeyDown(KeyCode.E)) {
                ShowBar();
            }
        }
     }
    
    public void HideBar() {
        if (isenable) {
            LeanTween.scaleY(this.gameObject, 0, 0.5f).setOnComplete(TurnOffMeshRender);
            isenable = false;
        }
     
    }

    public void ShowBar() {
        if (!isenable) {
            LeanTween.scaleY(this.gameObject, HeightVal, 0.5f).setOnStart(TurnOnMeshRender);
            isenable = true;
        }
    }

    private void TurnOnMeshRender() {
        meshRenderer.enabled = true;
    }

    private void TurnOffMeshRender()
    {
        meshRenderer.enabled = false;
    }
}
