using TMPro;
using UnityEngine;

public class UIObjective : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;    

    public void SetObjective(string newObjective)
    {
        text.text = newObjective;
    }
}
