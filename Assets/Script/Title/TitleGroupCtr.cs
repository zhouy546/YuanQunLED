using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleGroupCtr : MonoBehaviour
{

    public List<TitleCtr> titleCtrs = new List<TitleCtr>();
    // Start is called before the first frame update
    void Start()
    {
        hide();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            show();
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            hide();
        }
    }

    public void show() {
        foreach (var item in titleCtrs)
        {
            item.Show();
        }
    }

    public void hide() {
        foreach (var item in titleCtrs)
        {
            item.Hide();
        }
    }
}
