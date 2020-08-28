using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Put this script on an object to have it shake frantically and randomly, like a cold dog that's come in from the rain.
public class CharacterShake : MonoBehaviour
{
    private GameObject shakingObject;
    private Transform shakingObjectTransform;
    private Vector3 randomMovement;
    private Vector3 initialPos;
    public float shakeIntensity;

    private void Start()
    {
        shakingObject = gameObject;
        shakingObjectTransform = shakingObject.transform;
        initialPos = shakingObject.transform.position;
    }

    private void Update()
    {
        //I've never had to use UnityEngine before Random.Range but for some reason I got an error. Whatever, I guess?
        randomMovement = new Vector3(UnityEngine.Random.Range(-shakeIntensity,shakeIntensity),UnityEngine.Random.Range(-shakeIntensity,shakeIntensity), 0f);
        shakingObjectTransform.position = initialPos + randomMovement;
    }
}
