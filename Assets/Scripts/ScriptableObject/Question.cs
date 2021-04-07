using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct Answer
{
    [SerializeField]
    private string _info; 
    public string Info 
    {
        get {
            return _info; 
        }
    }

    [SerializeField]
    private bool IsCorrect; 
    public bool IsCorrect 
    {
        get {
            return _isCorrect; 
        }
    }
}
public class Question : ScriptableObject
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    public enum AnswerType 
    {
        Multi, 
        Single
    }
    [SerializeField] 
    private String _info = String.Empty; 

    public String Info 
    { get {
        return _info;
    }
    }

    [SerializeField]
    private bool _useTimer = false; 

    public bool UseTime 
    {
        get{
            return _useTimer; 
        }
    }

    [SerializeField]
    private int _timer = 0; 
    public int Timer 
    {
        get {
            return _timer; 
        }
    }

    [SerializeField]
    private AnswerType _answerType = AnswerType.Multi; 
    public AnswerType GetAnswerType 
    {
        get {
            return _answerType; 
        }
    }

    [SerializeField]
    private int _addScore = 10; 
    public int AddSco
    {
        get {
            return _addScore; 
        }
    }

    public List<int> GetCorrectAnswers()
    {
        List<int> CorrectAnswers = new List<int>();
        for(int i=0; i < Answers.Length; i++)
        {
            if(Answers[i].IsCorrect)
            {
                CorrectAnswers.Add(i);
            }
        }
        return CorrectAnswers; 
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
