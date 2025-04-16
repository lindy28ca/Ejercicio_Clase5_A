using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Emotion
{
    Alegria,
    Tristeza,
    Miedo,
    Enojo
}

public class Personaje
{
    private string nombre;
    private string textoActual;
    private Emotion emocionActual;
    public Personaje(string nombre)
    {
        this.nombre = nombre;
    }
    public void Hablar(string texto)
    {
        textoActual = texto;
        Debug.Log(nombre + " dice: \"" + texto );
    }
    public void Hablar(string texto, Emotion emotion)
    {
        textoActual = texto;
        emocionActual = emotion;
        Debug.Log(nombre + " dice: \"" + texto + "\" [" + emotion + "]");
    }
    public Emotion ObtenerEmocion()
    {
        return emocionActual;
    }
    public string ObtenerConversacion()
    {
        return nombre + ": " + textoActual + " [" + emocionActual + "]";
    }
}
