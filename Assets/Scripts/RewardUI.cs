using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RewardUI : MonoBehaviour
{
    public Image rewardImage;
    public TextMeshProUGUI rewardNameText;

    public void setup(string name, Sprite image)
    {
        rewardNameText.text = name;
        rewardImage.sprite = image;
    }
}
