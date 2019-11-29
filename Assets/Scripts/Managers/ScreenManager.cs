using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    public Image bgImage;
    public Question[] questions;
    public InteractionManager interactionManager;
    private int currentQuestionIndex = 0;

    void Start()
    {
        bgImage.sprite = questions[currentQuestionIndex].bgImage;
        interactionManager.question = questions[currentQuestionIndex];
    }

    public void nextQuestion()
    {
        if (currentQuestionIndex < questions.Length - 1)
        {
            currentQuestionIndex++;
            interactionManager.question = questions[currentQuestionIndex];
            interactionManager.setUpInteraction();
        }
    }

    public void prevQuestion()
    {
        if (currentQuestionIndex > 0)
        {
            currentQuestionIndex--;
            interactionManager.question = questions[currentQuestionIndex];
            interactionManager.setUpInteraction();
        }
    }
}
