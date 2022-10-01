using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TitleButtonAnimation : MonoBehaviour
{
    public GameObject PlayButton, GalleryButton, CreditsButton, ExitButton;
    
    void Start()
    {
        AnimationFromLeftToRight();
        
    }

    void AnimationFromLeftToRight()
    {
        PlayButton.transform.DOMoveX(320f, 1f);
        GalleryButton.transform.DOMoveX(350f, 1.33f);
        CreditsButton.transform.DOMoveX(380f, 1.66f);
        ExitButton.transform.DOMoveX(410f, 2f);

    }

}
