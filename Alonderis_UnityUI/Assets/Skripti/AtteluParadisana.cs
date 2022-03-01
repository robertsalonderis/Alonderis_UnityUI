using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject WolverineMaska;
	public GameObject BatmanMaska;
	public GameObject GreenMaska;
	public GameObject RedMaska;
	public GameObject AmericaTops;
	public GameObject SupermanTops;
	public GameObject SpidermanTops;
	public GameObject SpidermanBikses;
	public GameObject GrayBikses;
	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;
	public GameObject slaideris;

	public void maskuAttelosana(bool vertiba) {
		WolverineMaska.SetActive(vertiba);
		BatmanMaska.SetActive(vertiba);
		GreenMaska.SetActive(vertiba);
		RedMaska.SetActive(vertiba);
	}

	public void topuAttelosana(bool vertiba) {
		AmericaTops.SetActive(vertiba);
		SupermanTops.SetActive(vertiba);
		SpidermanTops.SetActive(vertiba);
	}
	public void biksuAttelosana(bool vertiba) {
		SpidermanBikses.SetActive(vertiba);
		GrayBikses.SetActive(vertiba);
	}
	public void izkritosais(int skaitlis){
		if (skaitlis == 0) {
			//Debug.Log("Boy");
			mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs [0];
		} if (skaitlis == 1) {
			//Debug.Log("Girl");
			mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs [1];
		}
	}
	public void mainitLielumu(){
		float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector3(1F*pasreizejaVertiba, 1F*pasreizejaVertiba, 1);
	}
}
