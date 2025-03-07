using UnityEngine;

public class Activate5thStencil : MonoBehaviour
{
    [SerializeField] GameObject frStencil, ffStencil;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("ActivateStencil", 5f);
    }

    
    private void ActivateStencil()
    {
        frStencil.SetActive(false);
        ffStencil.SetActive(true);
    }
}
