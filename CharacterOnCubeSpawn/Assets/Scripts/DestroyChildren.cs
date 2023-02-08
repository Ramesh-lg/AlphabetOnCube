using UnityEngine;

public class DestroyChildren : MonoBehaviour
{
    public void DestroyOnButton()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

}
