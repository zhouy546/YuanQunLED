using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_ParticleCtr : MonoBehaviour
{
    public List<ParticleCtr> particleCtrs = new List<ParticleCtr>();
    public NodeGroupCtr nodeGroupCtr;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        HideAllParticle();

        EventCenter.AddListener(EventDefine.PlayAnimation, TriggerAnimation);
    }

    private void TriggerAnimation() {
        animator.SetTrigger("PlayVideo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// 显示一个隐藏一个
    /// </summary>
    /// <param name="_id">要显示粒子编号</param>
    public void ShowOneHideOneParticle(string _id) {
        foreach (ParticleCtr item in particleCtrs)
        {
            if (item.id == _id)
            {
                item.ShowParticle();
            }
            else {
                item.HideParticle();
            }
        }
    }
    /// <summary>
    /// 显示一个
    /// </summary>
    /// <param name="_id">要显示粒子编号</param>
    public void ShowOneParticle(string _id) {
        foreach (ParticleCtr item in particleCtrs)
        {
            if (item.id == _id)
            {
                item.ShowParticle();
            }
        }
    }

    /// <summary>
    /// 隐藏一个
    /// </summary>
    /// <param name="_id">要隐藏粒子编号</param>
    public void HideOneParticle(string _id) {
        foreach (ParticleCtr item in particleCtrs)
        {
            if (item.id == _id)
            {
                item.HideParticle();
            }
        }
    }

    /// <summary>
    /// 隐藏全部
    /// </summary>
    public void HideAllParticle() {
        foreach (ParticleCtr item in particleCtrs)
        {
            item.HideParticle();
        }
    }


    public void hideAllNode() {
        nodeGroupCtr.HideAll();
    }

    public void showAllNode() {
        nodeGroupCtr.ShowAll();
    }

    public void showOneNode(int index) {
       // nodeGroupCtr.ShowOneNode(nodeGroupCtr.lineGroupCtrs[index]);
    }
}
