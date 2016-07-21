using System;
using System.Collections.Generic;

namespace RockPaper.Objects
{

  public class Player
  {
    private string _play;
    private static List<Player> _instances = new List<Player> {};

    public Player(string input1)
    {
      _play = input1;
    }

    public void SetPlay(string newInput1)
    {
      _play = newInput1;
    }
    public string GetPlay()
    {
      return _play;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static List<Player> GetAll()
    {
      return _instances;
    }
    public static void DeleteAll()
    {
      _instances.Clear();
    }

    public static string Shoot(Player player1, Player player2)
    {
      string output1 = "DRAW";
      string output2 = "PLAYER 1 WINS";
      string output3 = "PLAYER 2 WINS";



      if (player1.GetPlay() == player2.GetPlay())
      {
          return output1;
      }
      else if (((player1.GetPlay() == "Scissors") && (player2.GetPlay() == "Paper")) || ((player1.GetPlay() == "Rock") && (player2.GetPlay() == "Scissors")) || ((player1.GetPlay() == "Paper") && (player2.GetPlay() == "Rock")))
      {
        return output2;
      }
      else
      {
        return output3;
      }
    }
  }
}  
