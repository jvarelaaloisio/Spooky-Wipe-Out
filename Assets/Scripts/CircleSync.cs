using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSync : MonoBehaviour
{
    public static int PosID = Shader.PropertyToID("_Player_Position");
    public static int SizeID = Shader.PropertyToID("_Size");

    public Material Wall_Material;
    public Camera Camera;
    public LayerMask Mask;

    private void Update()
    {
        var dir = Camera.transform.position - transform.position;
        var ray = new Ray(transform.position, dir.normalized);

        if (Physics.Raycast(ray, 6000, Mask))
            Wall_Material.SetFloat(SizeID, 1.2f);
        
        else
            Wall_Material.SetFloat(SizeID, 0);

        var view = Camera.WorldToViewportPoint(transform.position);
        Wall_Material.SetVector(PosID, view);

    }
}
