using UnityEngine;
using System.Collections;

public class birds : MonoBehaviour 
{
	private bool[] normalBirdsIsHave = new bool[50];
	private bool[] rareBirdsIsHave = new bool[50];
	private bool[] uniqueBirdsIsHave = new bool[50];

	private int[] normalBirdsCount = new int[50];
	private int[] rareBirdsCount = new int[50];
	private int[] uniqueBirdsCount = new int[50];

	private readonly int MAXIMUM = 99; //1 bird only 99
	private readonly int BIRDS = 50;

	void Start () 
	{
		for(int i = 0; i < BIRDS; i++)
		{
			normalBirdsIsHave[i] = false;
			rareBirdsIsHave[i] = false;
			uniqueBirdsIsHave[i] = false;

			normalBirdsCount[i] = 0;
			rareBirdsCount[i] = 0;
			uniqueBirdsCount[i] = 0;
		}

	}

	void Update () {
	}
}
