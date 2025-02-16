﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleSceneTransitions : MonoBehaviour
{
    [SerializeField] RectTransform toTransition;
    [SerializeField] LeanTweenType toTransitionType;
    [SerializeField] float moveToTransition;
    [SerializeField] float toTransitionLength;
    [SerializeField] RectTransform fromTransition;
    [SerializeField] LeanTweenType fromTransitionType;
    [SerializeField] float fromTransitionLength;
    [SerializeField] TransitionToMenu menuTransition;
    [SerializeField] RectTransform toItselfTransition;

    void Start()
    {
        StartCoroutine(StartTransition());
    }

    IEnumerator StartTransition()
    {
        yield return null;
        LeanTween.moveX(toTransition, moveToTransition, toTransitionLength).setEase(toTransitionType);
        GameController.QuitGame += QuitGame;
        GameController.ToShipSelection += ShipSelection;
    }

    void QuitGame()
    {
        StartCoroutine(FromTransition());
    }

    void ShipSelection()
    {
        StartCoroutine(TransitionToItself());
    }
    
    IEnumerator FromTransition()
    {
        MusicPlayer.instance.FadeMusic(-1, FadeType.sceneSwitch);
        LeanTween.moveX(fromTransition, 0, fromTransitionLength).setEase(fromTransitionType);
        yield return new WaitForSeconds(fromTransitionLength);
        SceneManager.LoadScene("MainMenu");
        menuTransition.transition = true;
    }

    IEnumerator TransitionToItself()
    {
        MusicPlayer.instance.FadeMusic(-1, FadeType.sceneSwitch);
        LeanTween.moveX(toItselfTransition, 0, toTransitionLength).setEase(toTransitionType);
        yield return new WaitForSeconds(toTransitionLength);
        SceneManager.LoadScene("BattleScene");
    }

    private void OnDisable()
    {
        GameController.QuitGame -= QuitGame;
        GameController.ToShipSelection -= ShipSelection;
    }
}
