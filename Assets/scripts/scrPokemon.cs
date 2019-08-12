using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPokemon : MonoBehaviour
{
    public GameObject pokemon1;
    public GameObject pokemon2;
    ClassPoke1 poke1;
    ClassPoke2 poke2;

    // Start is called before the first frame update
    void Start()
    {
        poke1 = pokemon1.GetComponent<ClassPoke1>();
        poke2 = pokemon2.GetComponent<ClassPoke2>();

        int turno = Random.Range(1, 3);
        if (turno == poke1.turno)
        {
            calculo(poke1.lvl, poke2.hp, poke1.atk, poke1.power, poke2.def, turno);
        }
        if (turno == poke2.turno)
        {
            calculo(poke2.lvl, poke1.hp, poke2.atk, poke2.power, poke1.def, turno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void calculo(int lvl, int hp, int atk, int power, int def, int poketurno)
    {
        float dano = (((((2 * lvl) / 5) + 2) * power * (atk / def)) / 50) + 2;
        if (poke1.turno == poketurno)
        {
            Debug.Log("Poke2 está com: " + (hp - dano));
        }
        if (poke2.turno == poketurno)
        {
            Debug.Log("Poke1 está com: " + (hp - dano));
        }
    }

}
