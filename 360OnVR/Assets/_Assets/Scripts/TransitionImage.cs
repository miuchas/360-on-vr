using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionImage : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] List<GameObject> mount = new List<GameObject>();
    [SerializeField] int index = 0;
    bool backImage = false;
    
    public void NextImage()
    {
        index++;
        if (index >= mount.Count - 1) { index = mount.Count - 1; }
        anim.Play("Fade");
    }

    public void BackImage()
    {
        index--;
        if (index <= 0)  { index = 0; }
        backImage = true;
        anim.Play("Fade");
    }

    public void ActiveObject()
    {
        if (backImage)
        {
            mount[index + 1].SetActive(false);
            mount[index].SetActive(true);
            backImage = false;
        }
        else
        {
            mount[index - 1].SetActive(false);
            mount[index].SetActive(true);
        }
    }
}
