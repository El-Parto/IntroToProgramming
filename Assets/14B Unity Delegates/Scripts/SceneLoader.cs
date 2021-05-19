using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    private Fader fader;



    // Start is called before the first frame update
    void Start() => fader = FindObjectOfType<Fader>();
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //power of delegates
            // * this is pass a reference to the load scene function to be run
            // * when the fade is complete
            fader.FadeDown(LoadScene);

            //what happened? Passed reference into this function
            // once fade is complete, invoke whatever delagate that was passed in.
            //when it's complete it'll callback to this function
            // is scaleable
            // as long as ait matches the delagate specified we can run it 
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

}
