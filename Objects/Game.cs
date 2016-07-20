using System;
using System.Collections.Generic;

namespace RockPaper.Objects
{

  public class Game
  {
    private string _player1;
    private string _player2;

    public Game(string input1, string input2)
    {
      _player1 = input1;
      _player2 = input2;
    }
    public void SetPlayer1(string newInput1)
    {
      _player1 = newInput1;
    }
    public void SetPlayer2(string newInput2)
    {
      _player2 = newInput2;
    }
    public string GetPlayer1()
    {
      return _player1;
    }
    public string GetPlayer2()
    {
      return _player2;
    }
  }

}
