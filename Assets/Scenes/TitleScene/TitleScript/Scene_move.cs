using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_move : MonoBehaviour
{

    public void OnclickStartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
