using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TitleButtonAnimation : MonoBehaviour
{
    public GameObject PlayButton, GalleryButton, CreditsButton, MinigameButton, ExitButton;
    
    void Start()
    {
        AnimationFromLeftToRight();
        
    }

    void AnimationFromLeftToRight()
    {
        PlayButton.transform.DOMoveX(320f, 1f);
        GalleryButton.transform.DOMoveX(350f, 1.26f);
        CreditsButton.transform.DOMoveX(380f, 1.50f);
        MinigameButton.transform.DOMoveX(410f, 1.75f);
        ExitButton.transform.DOMoveX(440f, 2f);

    }

}
