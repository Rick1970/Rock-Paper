using Nancy;
using System;
using System.Collections.Generic;
using RockPaper.Objects;


namespace RockPaper
{
  public class Game : NancyModule
  {
    public Game()

    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };

      Get["/player1"] = _ =>{
        return View["player1.cshtml"];
      };

      Post["/player_1_input"] = _ => {
        Player player1 = new Player(Request.Form["input1"]);
        player1.Save();
        return View["player2.cshtml"];
      };
      }
    }
  }
