using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Personaje Luisito = new Personaje("Luisito");

        Luisito.Hablar("¡Qué día tan bonito para una aventura!", Emotion.Alegria);
        Debug.Log("Emoción Actual: " + Luisito.ObtenerEmocion());
        Debug.Log("Conversación completa: " + Luisito.ObtenerConversacion());

        Luisito.Hablar("No me gusta este lugar... algo no está bien.", Emotion.Miedo);
        Debug.Log("Emoción Actual: " + Luisito.ObtenerEmocion());
        Debug.Log("Conversación completa: " + Luisito.ObtenerConversacion());

        Luisito.Hablar("¡Esto es injusto! ¡Siempre me dejan atrás!", Emotion.Enojo);
        Debug.Log("Emoción Actual: " + Luisito.ObtenerEmocion());
        Debug.Log("Conversación completa: " + Luisito.ObtenerConversacion());

        Luisito.Hablar("Echo de menos a mis amigos...", Emotion.Tristeza);
        Debug.Log("Emoción Actual: " + Luisito.ObtenerEmocion());
        Debug.Log("Conversación completa: " + Luisito.ObtenerConversacion());
    }
}
