using UnityEngine;

public class OtherBallB11 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        mat.color = new Color(0, 0, 0);
    }
}
