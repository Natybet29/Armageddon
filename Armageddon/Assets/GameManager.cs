using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Armageddon : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PLAY()
    {       
       SceneManager.LoadScene("NavesSpace");
    }
    public void Menu()
    {
        SceneManager.LoadScene("NavesSpace");
    }

    public void  OUT()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}