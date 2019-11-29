using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Create New Question")] // para criar uma navegação dentro da interface da unity
public class Question : ScriptableObject
{
    public Interaction interaction; // recebe uma classe interação, que já estará configurada
    public Sprite bgImage;
}
