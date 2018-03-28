using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze_Station : Station {

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update () {
        base.Update();
	}

    public override void Job(ref Ingredient ingredient) {
        base.Job(ref ingredient);
        // Elemental Interactions
        ingredient.blue += ingredient.purple;
		ingredient.purple = 0;
		if (ingredient.yellow > 0) {
			base.Explode ();
		}

		// Physical Interactions
		if (ingredient.form == "watery") {
			ingredient.form = "frozen";
		}
	}
}
