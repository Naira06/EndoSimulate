using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem.Sample
{
public class KeypadButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Color lightPurple = new Color(0.808f, 0.663f, 0.831f); 
    
    Color purple = new Color(0.753f, 0.329f, 0.698f);

    private Image m_Image = null;

    private void Awake()
    {
        m_Image = GetComponent<Image>();
    }


    public void OnPointerEnter(PointerEventData eventData)           // Called when the hand pointer enters the object
    {
        Debug.Log("Enter");
        m_Image.color = purple;
    }

    public void OnPointerExit(PointerEventData eventData)              // Called when the hand pointer exits the object
    {
        Debug.Log("Exit");
        m_Image.color = lightPurple;
    }

}
}