using UnityEngine;

public class Battle : MonoBehaviour {

	void Start () 
    {
        Pokemon p1 = new Pokemon();
        p1.level = 75;
        p1.attack = 123;

        Pokemon p2 = new Pokemon();
        p2.level = 63;
        p2.defense = 163;

        Move move = new Move();
        move.power = 65;

        p1.moves = new Move[4];
        p1.moves[0] = move;

        var Damage = DamageCalc(p1, p2, move);
        var modifier = new Modifier();

        Damage *= modifier.GetRandom();

        Debug.Log("Damage: " + Damage);
	}

    float DamageCalc(Pokemon p1, Pokemon p2, Move move)
    {
        return (((((2 * p1.level) / 5) + 2) * move.power * (p1.attack / p2.defense)) / 50) + 2;
    }
}
