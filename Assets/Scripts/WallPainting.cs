using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPainting : MonoBehaviour
{
    public GameObject brush;
    public float brushsize = 0.1f;

    private bool isPaint = false;

    [SerializeField] private LayerMask layer;

    void Update()
    {

        if (Input.GetMouseButton(0) && isPaint)
        {
            //Cast a ray to the plane
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(Ray, out hit, Mathf.Infinity, layer))
            {
                //Instanciate a brush
                var paint = Instantiate(brush , hit.point + Vector3.up * 0.7f, Quaternion.identity, transform);
                paint.transform.localScale = Vector3.one * brushsize;
            }

        }

    }

    public void DisablePaint()
    {
        isPaint = true;
    }

}
