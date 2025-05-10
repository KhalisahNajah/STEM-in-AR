using UnityEngine;

public class ToggleCanvas : MonoBehaviour
{
    // Assign this in the Inspector
    public GameObject multiplicationTableCanvas;

    private bool isVisible = false;

    public void ToggleMultiplicationTable()
    {
        if (multiplicationTableCanvas == null)
        {
            Debug.LogWarning("Multiplication Table Canvas is not assigned.");
            return;
        }

        isVisible = !isVisible;
        multiplicationTableCanvas.SetActive(isVisible);
    }
}
