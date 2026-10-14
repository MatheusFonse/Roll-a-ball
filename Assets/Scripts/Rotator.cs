using UnityEngine;

public class GiraGira : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, -2, 3) * Time.deltaTime);
    }
}
