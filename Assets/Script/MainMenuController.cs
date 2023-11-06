using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class MainMenuController : MonoBehaviour
{
    // main menu elements
    private Button _Play;
    private Button _Option;
    private Button _Quit;
    // option menu elements


    // exit menu elements
    private Button _Yes;
    private Button _No;
    // Start is called before the first frame update
    void Start()
    {
        Inisiate();
        AddFunction();
    }

    void Inisiate()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        _Play = root.Q<Button>("PLAY");
        _Option = root.Q<Button>("OPTION");
        _Quit = root.Q<Button>("QUIT");
    }

    void AddFunction()
    {
        _Play.RegisterCallback<ClickEvent>(SelectPlay);
        _Option.RegisterCallback<ClickEvent>(SelectOption);
        _Quit.RegisterCallback<ClickEvent>(SelectQuit);
    }
    void SelectPlay(ClickEvent evet)
    {

    }
    void SelectOption(ClickEvent evet)
    {
    
    }

    void SelectQuit(ClickEvent evet)
    {

    }

}
