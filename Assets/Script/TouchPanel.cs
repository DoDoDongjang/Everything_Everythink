using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TouchPanel : MonoBehaviour, IPointerDownHandler
{
    public int count;
    public void OnPointerDown(PointerEventData data)
    {
        switch (count)
        {
            case 0:
                Debug.Log("c1");
                SceneManager.LoadScene("FirstHint");
                break;
            case 1:
                Debug.Log("c2");
                SceneManager.LoadScene("FirstEnd");
                break;
            case 2:
                Debug.Log("c3");
                SceneManager.LoadScene("FirstQuestion");
                break;
            case 3:
                Debug.Log("c4");
                SceneManager.LoadScene("SecondHint");
                break;
            case 4:
                Debug.Log("c5");
                SceneManager.LoadScene("SecondEnd");
                break;
            case 5:
                Debug.Log("c6");
                SceneManager.LoadScene("SecondQuestion");
                break;
            case 6:
                Debug.Log("c7");
                SceneManager.LoadScene("SecondQuestion");
                break;
            case 7:
                Debug.Log("c8");
                SceneManager.LoadScene("ThirdHint");
                break;
            case 8:
                Debug.Log("c9");
                SceneManager.LoadScene("ThirdEnd");
                break;
            case 9:
                Debug.Log("c10");
                SceneManager.LoadScene("ThirdQuestion");
                break;
            case 10:
                Debug.Log("c11");
                SceneManager.LoadScene("ThirdQuestion");
                break;
            case 11:
                Debug.Log("c12");
                SceneManager.LoadScene("FourthQuestion");
                break;
            case 12:
                Debug.Log("c13");
                SceneManager.LoadScene("FourthHint");
                break;
            case 13:
                Debug.Log("c14");
                SceneManager.LoadScene("FourthEnd");
                break;
            case 14:
                Debug.Log("c15");
                SceneManager.LoadScene("FourthQuestion");
                break;
            case 15:
                Debug.Log("c16");
                SceneManager.LoadScene("FifthQuestion");
                break;
            case 16:
                Debug.Log("c17");
                SceneManager.LoadScene("FifthHint");
                break;
            case 17:
                Debug.Log("c18");
                SceneManager.LoadScene("FifthEnd");
                break;
            case 18:
                Debug.Log("c19");
                SceneManager.LoadScene("FifthQuestion");
                break;
            case 19:
                Debug.Log("c20");
                SceneManager.LoadScene("Last");
                break;
            case 20:
                Debug.Log("c21");
                SceneManager.LoadScene("FirstQuestion");
                break;
        }
    }
}