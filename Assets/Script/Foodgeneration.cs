using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Foodgeneration : MonoBehaviour
{
	// Start is called before the first frame update
	public TextMeshProUGUI dishnumber1;
	public TextMeshProUGUI dishnumber2;
	public TextMeshProUGUI dishnumber3;
	public TextMeshProUGUI dishnumber4;

	int dish1;
	int dish2;
	int dish3;
	int dish4;

	string [] foodlist = new string [6];
	string [] foodlist2 = new string [4];
	void Start()
    {
		foodlist [0] = "Steak";
		foodlist [1] = "Egg";
		foodlist [2] = "Salad";
		foodlist [3] = "Steak and egg";
		foodlist [4] = "Steak and salad";
		foodlist [5] = "Steak and egg and salad";


		foodlist2 [0] = "Steak";
		foodlist2 [1] = "Egg";
		foodlist2 [2] = "Lettuce";
		foodlist2 [3] = "";
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void buttonpre() {

		dish1 = Random.Range(1,6);
		dishnumber1.text = foodlist [dish1] + "";

		if (dish1 == 0) {
			dishnumber2.text = foodlist2 [0] + "";
			dishnumber3.text = foodlist2 [3] + "";
			dishnumber4.text = foodlist2 [3] + "";
		}
		if (dish1 == 1) {
			dishnumber2.text = foodlist2 [1] + "";
			dishnumber3.text = foodlist2 [3] + "";
			dishnumber4.text = foodlist2 [3] + "";
		}
		if (dish1 == 2) {
			dishnumber2.text = foodlist2 [2] + "";
			dishnumber3.text = foodlist2 [3] + "";
			dishnumber4.text = foodlist2 [3] + "";
		}
		if (dish1 == 3) {
			dishnumber2.text = foodlist2 [0] + "";
			dishnumber3.text = foodlist2 [1] + "";
			dishnumber4.text = foodlist2 [3] + "";
		}
		if (dish1 == 4) {
			dishnumber2.text = foodlist2 [0] + "";
			dishnumber3.text = foodlist2 [2] + "";
			dishnumber4.text = foodlist2 [3] + "";
		}
		if (dish1 == 5) {
			//steak and egg and salad
			dishnumber2.text = foodlist2 [0] + "";
			dishnumber3.text = foodlist2 [1] + "";
			dishnumber4.text = foodlist2 [2] + "";
		}
	}


	public void dish1reroll() {
		dish1 = Random.Range(1,6);
		dishnumber1.text = foodlist [dish1] + "";


		if (dish1 == 0) {
			dishnumber2.text = foodlist2 [0] + "";
			dishnumber3.text = foodlist2 [3] + "";
			dishnumber4.text = foodlist2 [3] + "";
		}
		if (dish1 == 1) {
			dishnumber2.text = foodlist2 [1] + "";
			dishnumber3.text = foodlist2 [3] + "";
			dishnumber4.text = foodlist2 [3] + "";
		}
		if (dish1 == 2) {
			dishnumber2.text = foodlist2 [2] + "";
			dishnumber3.text = foodlist2 [3] + "";
			dishnumber4.text = foodlist2 [3] + "";
		}
		if (dish1 == 3) {
			dishnumber2.text = foodlist2 [0] + "";
			dishnumber3.text = foodlist2 [1] + "";
			dishnumber4.text = foodlist2 [3] + "";
		}
		if (dish1 == 4) {
			dishnumber2.text = foodlist2 [0] + "";
			dishnumber3.text = foodlist2 [2] + "";
			dishnumber4.text = foodlist2 [3] + "";
		}
		if (dish1 == 5) {
			//steak and egg and salad
			dishnumber2.text = foodlist2 [0] + "";
			dishnumber3.text = foodlist2 [1] + "";
			dishnumber4.text = foodlist2 [2] + "";
		}
	}

}
