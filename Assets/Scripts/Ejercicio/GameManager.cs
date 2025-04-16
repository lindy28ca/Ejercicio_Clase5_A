using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Personaje Luisito = new Personaje("Luisito");

        Luisito.Hablar("�Qu� d�a tan bonito para una aventura!", Emotion.Alegria);
        Debug.Log("Emoci�n Actual: " + Luisito.ObtenerEmocion());
        Debug.Log("Conversaci�n completa: " + Luisito.ObtenerConversacion());

        Luisito.Hablar("No me gusta este lugar... algo no est� bien.", Emotion.Miedo);
        Debug.Log("Emoci�n Actual: " + Luisito.ObtenerEmocion());
        Debug.Log("Conversaci�n completa: " + Luisito.ObtenerConversacion());

        Luisito.Hablar("�Esto es injusto! �Siempre me dejan atr�s!", Emotion.Enojo);
        Debug.Log("Emoci�n Actual: " + Luisito.ObtenerEmocion());
        Debug.Log("Conversaci�n completa: " + Luisito.ObtenerConversacion());

        Luisito.Hablar("Echo de menos a mis amigos...", Emotion.Tristeza);
        Debug.Log("Emoci�n Actual: " + Luisito.ObtenerEmocion());
        Debug.Log("Conversaci�n completa: " + Luisito.ObtenerConversacion());
    }
}
