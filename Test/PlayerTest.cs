using Xunit;
using System.Collections.Generic;
using System;

namespace RockPaper.Objects
{
  public class PlayerTest : IDisposable
  {
    public void Dispose()
    {
      Player.DeleteAll();
    }

    [Fact]
    public void Test_PlayerGetPlay_true()
    {
      //Arrange
      Player player1 = new Player("Rock");

      //Act
      string currentPlay = player1.GetPlay();

      //Assert
      Assert.Equal("Rock", currentPlay);
    }

    [Fact]
    public void Test_PlayerSetPlay_true()
    {
      //Arrange
      Player player1 = new Player("Rock");
      player1.SetPlay("Paper");

      //Act
      string currentPlay = player1.GetPlay();

      //Assert
      Assert.Equal("Paper", currentPlay);
    }

    [Fact]
    public void Test_PlayerSave_true()
    {
      //Arrange
      Player player1 = new Player("Rock");
      player1.Save();

      //Act
      List<Player> allPlayers = Player.GetAll();

      //Assert
      Assert.Equal(player1, allPlayers[0]);
    }

    [Fact]
    public void Test_TwoPlayersSave_true()
    {
      //Arrange
      Player player1 = new Player("Rock");
      player1.Save();
      Player player2 = new Player("Paper");
      player2.Save();


      //Act
      List<Player> allPlayers = Player.GetAll();

      //Assert
      // Console.WriteLine(new List<Player>() {player1, player2});
      Console.WriteLine(allPlayers.Count);
      Assert.Equal(player1, allPlayers[0]);
      Assert.Equal(player2, allPlayers[1]);
    }

    [Fact]
    public void Test_PlayAGame_true()
    {
      //Arrange
      Player player1 = new Player("Rock");
      player1.Save();
      Player player2 = new Player("Paper");
      player2.Save();

      //Act
      //write a method to determine the winner
      string result = Player.Shoot(player1, player2);
      //Assert
      Assert.Equal("DRAW", result);
    }





  }
}
