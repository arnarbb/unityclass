using UnityEngine;
using UnityEngine.SceneManagement;
 
public class byrjaButton : MonoBehaviour
{
    public void NextScene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}