using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dry_Station : Station {

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    void Dry(ref Ingredient ingredient) {

		// Elemental Interactions
		ingredient.green += ingredient.blue;
		ingredient.blue = 0;
		if (ingredient.orange > 0) {
			base.Explode ();
		}

		// Physical Interactions
		if (ingredient.form == "leaf") {
			ingredient.form = "dried";
		}

		if (ingredient.form == "pasty") {
			ingredient.form = "powdery";
		}

		if (ingredient.form == "watery") {
			ingredient.form = "powdery";
		}

		if (ingredient.form == "squishy") {
			ingredient.form = "brittle";
		}

		if (ingredient.form == "murky") {
			ingredient.form = "burnt";
		}
	}
}
