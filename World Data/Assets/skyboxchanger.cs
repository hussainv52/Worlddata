using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxchanger : MonoBehaviour
{
    
	public Material Skyworld;
	public Material SkyUSA;
	public Material SkyAus;
	public Material SkyChi;
	public Material SkyInd;
	public Material SkyJap;
	public Material SkyMalay;
	public Material SkyRus;
//	public Material worldbutton;
//	public Material USAbutton;
//	public Material Ausbutton;
//	public Material Chibutton;
//	public Material Indbutton;
//	public Material Japbutton;
//	public Material Malaybutton;
//	public Material Rusbutton;
	
	// Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = Skyworld;
    }

    // Update is called once per frame
    public void Changebox()
    {
		/*	 if(GUILayout.Button ("Reset"))
			 {
				RenderSettings.skybox = Skyworld;
			 }
			 if(GUILayout.Button ("USA"))
			 {
				RenderSettings.skybox = SkyUSA;
			 }
			 if(GUILayout.Button ("Australia"))
			 {
				RenderSettings.skybox = SkyAus;
			 }
			 if(GUILayout.Button ("China"))
			 {
				RenderSettings.skybox = SkyChi;
			 }
			 if(GUILayout.Button ("Indonesia"))
			 {
				RenderSettings.skybox = SkyInd;
			 }
			 if(GUILayout.Button ("Malaysia"))
			 {
				RenderSettings.skybox = SkyMalay;
			 }
			 if(GUILayout.Button ("Russia"))
			 {
				RenderSettings.skybox = SkyRus;
			 }
			 if(GUILayout.Button ("Japan"))
			 {
				RenderSettings.skybox = SkyJap;
			 }
			*/
		}
		
	public void resetworld()
    {
			 {
				RenderSettings.skybox = Skyworld;
			 }
	}	

	public void USAworld()
    {
			 {
				RenderSettings.skybox = SkyUSA;
			 }
	}	
		
	public void Chinaworld()
    {
			 {
				RenderSettings.skybox = SkyChi;
			 }
	}	
	public void Japanworld()
    {
			 {
				RenderSettings.skybox = SkyJap;
			 }
	}	
	public void Indonesiaworld()
    {
			 {
				RenderSettings.skybox = SkyInd;
			 }
	}	
	public void Malaysiaworld()
    {
			 {
				RenderSettings.skybox = SkyMalay;
			 }
	}	
	public void Ausworld()
    {
			 {
				RenderSettings.skybox = SkyAus;
			 }
	}	
	public void Russiaworld()
    {
			 {
				RenderSettings.skybox = SkyRus;
			 }
	}	
 
}