using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcon : MonoBehaviour {

    public AudioClip[] aClips;

    public AudioSource myAudioSource;

    string btnName;



 // Use this for initialization

 void Start () {

        myAudioSource = GetComponent<AudioSource>();

  

 }

 

 // Update is called once per frame

 void Update () {

  if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)

        {

            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))

            {

                btnName = Hit.transform.name;

                switch (btnName)

                {

                    case "HH":

                        myAudioSource.clip = aClips[8];

                        myAudioSource.Play();

                        break;

                    case "BD":

                        myAudioSource.clip = aClips[5];

                        myAudioSource.Play();

                        break;

                    case "HITOM":

                        myAudioSource.clip = aClips[4];

                        myAudioSource.Play();

                        break;

                    case "MIDTOM":

                        myAudioSource.clip = aClips[7];

                        myAudioSource.Play();

                        break;

                    case "SNARE":

                        myAudioSource.clip = aClips[3];

                        myAudioSource.Play();

                        break;

                    

                    default:

                        break;



                }

            }

        }

        

 }

}