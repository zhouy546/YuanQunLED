using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeGroupCtr : MonoBehaviour
{
    public List<LineGroupCtr> lineGroupCtrs = new List<LineGroupCtr>();

    public bool enable_DEBUG_Interaction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enable_DEBUG_Interaction)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                ShowAll();
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                HideAll();
            }
            //else if (Input.GetKeyDown(KeyCode.Alpha1)) {
            //    ShowOneNode(lineGroupCtrs[0]);
            //}
            //else if (Input.GetKeyDown(KeyCode.Alpha2))
            //{
            //    ShowOneNode(lineGroupCtrs[1]);
            //}
            //else if (Input.GetKeyDown(KeyCode.Alpha3))
            //{
            //    ShowOneNode(lineGroupCtrs[2]);
            //}
            //else if (Input.GetKeyDown(KeyCode.Alpha4))
            //{
            //    ShowOneNode(lineGroupCtrs[3]);
            //}
            //else if (Input.GetKeyDown(KeyCode.Alpha5))
            //{
            //    ShowOneNode(lineGroupCtrs[4]);
            //}
        }
    }

    public void HideNode(int index) {
        lineGroupCtrs[index].Hide();
    }

    public void ShowOneNode(int index) {
        foreach (LineGroupCtr item in lineGroupCtrs)
        {
            if (lineGroupCtrs[index] == item)
            {
                item.Show();
            }
            else {
                item.Hide();
            }
        }
    }

    public void HideAll()
    {
        foreach (LineGroupCtr item in lineGroupCtrs)
        {
            item.Hide();
        }
    }

    public void ShowAll() {
        foreach (LineGroupCtr item in lineGroupCtrs)
        {
            item.Show();
        }
    }
}
