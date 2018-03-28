using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn_Station : Station {

	// Use this for initialization
	protected override void Start () {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    public override void Job(ref Ingredient ingredient) {
        base.Job(ref ingredient);
		// Elemental Interactions
		ingredient.yellow += ingredient.green;
		ingredient.green = 0;
		if (ingredient.red > 0) {
			base.Explode ();
		}

		// Physical Interactions
		if (ingredient.form == "leafy") {
			ingredient.form = "burnt";
		}

		if (ingredient.form == "dried") {
			ingredient.form = "burnt";
		}

		if (ingredient.form == "pasty") {
			ingredient.form = "burnt";
		}

		if (ingredient.form == "watery") {
			ingredient.form = "boiled";
		}

		if (ingredient.form == "powdery") {
			ingredient.form = "burnt";
		}

		if (ingredient.form == "frozen") {
			ingredient.form = "watery";
		}

		if (ingredient.form == "fractured") {
			ingredient.form = "burnt";
		}

		if (ingredient.form == "squishy") {
			ingredient.form = "burnt";
		}

		if (ingredient.form == "brittle") {
			ingredient.form = "burnt";
		}
	}
}
