using UnityEngine;

public class Main : MonoBehaviour
{
	string[] arr = new string[] { "a", "b", "c", "d", "e" };

	void Start()
	{
		// =============== WHILE ================
		int index1 = 0;
		while(index1 < arr.Length) {
			//Debug.Log(arr[index1]);
			index1++;
		}

		// =============== DO-WHILE ================
		int index2 = 0;
		do {
			//Debug.Log(arr[index2]);
			index2++;
		} while(index2 < arr.Length);

		// =============== FOR ================
		for (int index3 = 2; index3 < arr.Length; index3++) {
			//Debug.Log(arr[index3]);
		}

		// =============== FOREACH ================
		foreach (string str in arr) {
			//Debug.Log(str);
		}
		//Debug.Log(FindString("c"));
		PrintMultiples(9);
	}

	int FindString(string str)
	{
		for (int i = 0; i < arr.Length; i++) {
			if (arr[i] == str) {
				return i;
			}
		}

		return -1;
	}

	/*
	 *	Dado um inteiro n, imprima seus primeiros 10 múltiplos.
	 *  Cada múltiplo n * i (onde 1 <= i <= 10) deve ser impresso
	 *  em uma nova linha na forma seguinte: "n * i = resultado"
	 */
	void PrintMultiples(int n)
	{
		for (int i = 1; i <= 10; i++) {
			Debug.Log(n + " * " + i + " = " + (n * i));
		}	
	}
}
