using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public List<QnA> QnAList;
    public GameObject[] options;
    public int currentQuestion;

    private void Start()
    {

    }

    void SetAnswers()
    {
        for(int i = 0;  i < options.Length; i++)
        {
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnAList[currentQuestion].Answers[i];
        }
    }
    void generateQuestion ()
    {
        currentQuestion = Random.Range(0, QnAList.Count);
    }
}
