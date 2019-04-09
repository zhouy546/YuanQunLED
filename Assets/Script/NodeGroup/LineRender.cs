using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRender : MonoBehaviour
{

    public LineRenderer lineRenderer;

    public Transform targetTrans;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3[] pos = new Vector3[2];
        pos[0] = this.transform.position;
        pos[1] = targetTrans.position;

        lineRenderer.SetPositions(pos);
    }
}
