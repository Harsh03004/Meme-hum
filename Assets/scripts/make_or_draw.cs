using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class make_or_draw : MonoBehaviour
{
    public Button makeMeme;
    public Button drawMeme;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        makeMeme = root.Q<Button>("make");
        drawMeme = root.Q<Button>("draw");
        makeMeme.clicked += makeMemePressed;
        drawMeme.clicked+= drawMemePressed;
    }
    // Update is called once per frame
    void makeMemePressed(){
        SceneManager.LoadScene("MEME_GENERATION_PROMPT");
    }
    void drawMemePressed(){
        SceneManager.LoadScene("Drawing_prompt");
    }
}
