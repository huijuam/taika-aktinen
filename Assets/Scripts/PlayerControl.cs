using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        Vector3 GDRef = transform.position; // (GDRef tarkottaa siis positionia, koska Geomtry Dashissä on StartPos-niminen triggeri)
        GDRef.x += speed * input * Time.deltaTime;
        transform.position = GDRef;
    }
}
