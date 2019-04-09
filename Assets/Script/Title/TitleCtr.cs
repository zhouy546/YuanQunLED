using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class TitleCtr : MonoBehaviour
{
    public Animator animator;

    public VisualEffect visualEffect;
    // Start is called before the first frame update
    void Start()
    {
     

        visualEffect.SetFloat("ForceFieldIntensity", Random.Range(15f, 30f));
        Hide();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Show() {
        animator.SetBool("Show", true);
    }

    public void Hide() {
        animator.SetBool("Show", false);
    }
}
