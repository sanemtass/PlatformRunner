using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<Transform> players;
    public Text numberText;

    private GameObject player;
    private int characterNumber;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
      
    }

    private void Update()
    {
        players.Sort(SortByScore);
       
        characterNumber = players.Count - players.IndexOf(player.transform);
        print(characterNumber);

        numberText.text = characterNumber.ToString();
    }

    static int SortByScore(Transform p1, Transform p2)
    {
        //compares the z-position values ​​of all characters
        return p1.position.z.CompareTo(p2.position.z);
    }
}
