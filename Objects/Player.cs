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
      string output = null;
      return output;
    }
  }

  // public class Game2
  // {
  //   private string _player2;
  //   private static List<Game2> _instances = new List<Game2> {};
  //
  //   public Game2(string input2)
  //   {
  //     _player2 = input2;
  //   }
  //   public void SetPlayer2(string newInput2)
  //   {
  //     _player2 = newInput2;
  //   }
  //   public string GetPlayer2()
  //   {
  //     return _player2;
  //   }
  // }
}
