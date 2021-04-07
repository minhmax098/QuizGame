using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.UI; 

public class AnswerData : MonoBehaviour
{

    #region Variables

    [Header("UI Elements")]
    [SerializeField]
    TextMeshProGUI infoTextObject = null; 
    [SerializeField]
    Image toggle = null; 

    [Header("Textures")]
    [SerializeField]
    Sprite uncheckedToggle = null; 
    [SerializeField]
    Sprite checkedToggle = null; 

    [Header("References")]
    [SerializeField]
    GameEvents events = null; 


    private RectTransform _rect = null; 
    public RectTransform Rect 
    {
        get 
        {
            if(_rect == null)
            {
                _rect =  GetComponent<RectTransform>() ?? gameObject.AddComponent<RectTransform>();

            }
            return _rect; 
        }
    }

    private int _answerType = -1; 
    public int AnswerIndex
    {
        get 
        {
            return _answerType; 
        }
    }

    #endregion

    // That is called to update the answer data
    public void UpdateData(string info, string index)
    {
        infoTextObject.text = info; 
        _answerIndex = index; 
    }




    // Function that is called to reset values back to default.
    public void Reset()
    {
        Checked = false; 
        UpdateUI();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {
        
    }
}
