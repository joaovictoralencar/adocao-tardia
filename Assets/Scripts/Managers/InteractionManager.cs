using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InteractionManager : MonoBehaviour
{
    [HideInInspector]
    public Interaction interaction;
    [HideInInspector]
    public Question question;
    public GameObject dropDown;
    public GameObject slider;

    // Start is called before the first frame update
    void Start()
    {
        setUpInteraction();
    }
    public void setUpInteraction()
    {
        interaction = question.interaction; //pega a interação da questão atual. Lembrando q tudo vai ser definido em questão
        switch (interaction.type)
        {
            case "Drop Down":
                //precisamos acessar o componente dropdown, uma vez que a variável que já temos 
                //é apenas o GameObject que segura o component dropdown
                Dropdown dp = dropDown.GetComponent<Dropdown>();//esse é o verdadeiro dropdown da unity ui
                foreach (string value in interaction.values)
                {
                    Dropdown.OptionData option = new Dropdown.OptionData(value);
                    dp.options.Add(option);
                }
                openInteraction(dropDown);
                break;
            case "Slider":
                openInteraction(slider);
                break;
            default:
                openInteraction(dropDown);
                break;
        }
    }
    void openInteraction(GameObject gameObject)
    {
        foreach (Transform childObject in GetComponentInChildren<Transform>())
        {
            if (childObject.name == gameObject.gameObject.name) gameObject.gameObject.SetActive(true);
            else childObject.gameObject.SetActive(false);
        }
    }
}
