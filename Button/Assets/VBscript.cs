using UnityEngine;
using System.Collections;
using Vuforia;

public class VBscript : MonoBehaviour, IVirtualButtonEventHandler{

    //private GameObject Octave;

    private GameObject vbButtonObject;
    private GameObject D1Key;
    private GameObject E1Key;
    private GameObject F1Key;
    private GameObject G1Key;
    private GameObject A1Key;
    private GameObject B1Key;
    private GameObject C2Key;
    private GameObject D2Key;
    private GameObject E2Key;
    private GameObject F2Key;

    private GameObject CSharp;
    private GameObject DSharp;
    private GameObject FSharp;
    private GameObject GSharp;
    private GameObject ASharp;

    private GameObject CSharp2;
    private GameObject DSharp2;
    private GameObject FSharp2;

    private GameObject Octave;
	// Use this for initialization
	void Start () {
        //registers all children of Vbutton behaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
        Octave = GameObject.Find("CentralOctave");

        vbButtonObject = GameObject.Find("VirtualButtonC1");
        CSharp = GameObject.Find("CSharp");
        D1Key = GameObject.Find("VirtualButtonD1");
        DSharp = GameObject.Find("DSharp");
        E1Key = GameObject.Find("VirtualButtonE1");
      
        F1Key = GameObject.Find("VirtualButtonF1");
        FSharp = GameObject.Find("FSharp");
        G1Key = GameObject.Find("VirtualButtonG1");
        GSharp = GameObject.Find("GSharp");
        A1Key = GameObject.Find("VirtualButtonA1");
        ASharp = GameObject.Find("ASharp");
        B1Key = GameObject.Find("VirtualButtonB1");
        
        C2Key = GameObject.Find("VirtualButtonC2");
        CSharp2 = GameObject.Find("CSharp2");
        D2Key = GameObject.Find("VirtualButtonD2");
        DSharp2 = GameObject.Find("DSharp2");
        E2Key = GameObject.Find("VirtualButtonE2");

        F2Key = GameObject.Find("VirtualButtonF2");
        FSharp2 = GameObject.Find("FSharp2");

        
      
        
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
       
        switch (vb.VirtualButtonName)
        {
            case "VirtualButtonC1":
                vbButtonObject.GetComponent<AudioSource>().Play();
                Debug.Log("C1");
                break;
            case "VirtualButtonD1":
                D1Key.GetComponent<AudioSource>().Play();
                Debug.Log("D1");
                break;
            case "VirtualButtonE1":
                E1Key.GetComponent<AudioSource>().Play();
                Debug.Log("E1");
                break;
            case "VirtualButtonF1":
                F1Key.GetComponent<AudioSource>().Play();
                Debug.Log("F1");
                break;
            case "VirtualButtonG1":
                G1Key.GetComponent<AudioSource>().Play();
                Debug.Log("G1");
                break;
            case "VirtualButtonA1":
                A1Key.GetComponent<AudioSource>().Play();
                Debug.Log("A1");
                break;
            case "VirtualButtonB1":
                B1Key.GetComponent<AudioSource>().Play();
                Debug.Log("B1");
                break;
            case "VirtualButtonC2":
                C2Key.GetComponent<AudioSource>().Play();
                Debug.Log("C2");
                break;
            case "VirtualButtonD2":
                D2Key.GetComponent<AudioSource>().Play();
                Debug.Log("D2");
                break;
            case "VirtualButtonE2":
                E2Key.GetComponent<AudioSource>().Play();
                Debug.Log("E2");
                break;
            case "VirtualButtonF2":
                F2Key.GetComponent<AudioSource>().Play();
                Debug.Log("F2");
                break;
            case "CSharp":
                CSharp.GetComponent<AudioSource>().Play();
                Debug.Log("C#");
                break;
            case "DSharp":
                DSharp.GetComponent<AudioSource>().Play();
                Debug.Log("D#");
                break;
            case "FSharp":
                FSharp.GetComponent<AudioSource>().Play();
                Debug.Log("F#");
                break;
            case "GSharp":
                GSharp.GetComponent<AudioSource>().Play();
                Debug.Log("G#");
                break;
            case "ASharp":
                ASharp.GetComponent<AudioSource>().Play();
                Debug.Log("A#");
                break;
            case "CSharp2":
                CSharp2.GetComponent<AudioSource>().Play();
                Debug.Log("C#");
                break;
            case "DSharp2":
                DSharp2.GetComponent<AudioSource>().Play();
                Debug.Log("D#2");
                break;
            case "FSharp2":
                FSharp2.GetComponent<AudioSource>().Play();
                Debug.Log("F#2");
                break;
        }
        //vbButtonObject.GetComponent<AudioSource>().Play();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        //vbButtonObject.GetComponent<AudioSource>().Stop();
    }
	
}
