using UnityEngine;
using System.Collections;

public class MyScriptableObjectClass : ScriptableObject
{
	public string objectName = "New MyScriptableobject";
    public bool colorIsRamdom = false;
    public Color thisColor = Color.white;
    public Vector3[] spawnPoints;
}