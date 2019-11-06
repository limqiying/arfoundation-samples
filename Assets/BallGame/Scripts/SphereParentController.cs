using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SphereParentController : MonoBehaviour
{
    public GameObject spherePrefab;
    public SphereFire script;
    ARSessionOrigin m_SessionOrigin;
    private Transform oTransform;

    // Start is called before the first frame update
    void Start()
    {
        oTransform = transform;
        m_SessionOrigin = GetComponent<ARSessionOrigin>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            GameObject spawnedSphere = Instantiate(spherePrefab);
            Vector3 pos = new Vector3(oTransform.position.x, oTransform.position.y - 0.5f, oTransform.position.z + 1.0f);
            m_SessionOrigin.MakeContentAppearAt(spawnedSphere.transform, pos, Quaternion.identity);
            SphereFire fire = spawnedSphere.GetComponent<SphereFire>();
            fire.ThrowBall(0.0f, 0.0f, 1.0f);
        }
    }
}
