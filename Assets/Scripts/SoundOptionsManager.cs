﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SoundOptionsManager : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider master;
    [SerializeField] Slider music;
    [SerializeField] Slider effects;
    [SerializeField] TextMeshProUGUI[] texts;
    string exposedParam;

    void Awake()
    {
        mixer.SetFloat("Master", CalculateVolume(PlayerPrefs.GetFloat("Master", 1)));
        mixer.SetFloat("Music", CalculateVolume(PlayerPrefs.GetFloat("Music", 1)));
        mixer.SetFloat("Effects", CalculateVolume(PlayerPrefs.GetFloat("Effects", 1)));

        master.value = PlayerPrefs.GetFloat("Master", 1);
        music.value = PlayerPrefs.GetFloat("Music", 0.75f);
        effects.value = PlayerPrefs.GetFloat("Effects", 1);
        UpdateTexts();
    }
    
    public void ExposedParam(string param)
    {
        exposedParam = param;
    }
    
    public void SetExposedParam(Slider slider) 
    {
        mixer.SetFloat(exposedParam, CalculateVolume(slider.value));
        PlayerPrefs.SetFloat(exposedParam, slider.value);
        UpdateTexts();
    }

    public float CalculateVolume(float decimalVolume)
    {
        float dbVolume = 20 * Mathf.Log10(decimalVolume);
        if (decimalVolume == 0.0f)
        {
            dbVolume = -80.0f;
        }
        return dbVolume;
    }

    public void UpdateTexts()
    {
        texts[0].text = "MASTER: " + Mathf.Round(100 * master.value).ToString();
        texts[1].text = "MUSIC: " + Mathf.Round(100 * music.value).ToString();
        texts[2].text = "EFFECTS: " + Mathf.Round(100 * effects.value).ToString();
    }
}
