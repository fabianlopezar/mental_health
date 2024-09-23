using UnityEngine;

public class HonorController : MonoBehaviour
{
    public int honor=0;
    void Start()
    {
        
    }   
    void Update()
    {
        
    }
    public void GanarHonor()
    {
        honor += 1;
    }
    public void PerderHonor()
    {
        honor -= 1;
    }
}
