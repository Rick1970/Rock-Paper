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

      Get["/play1"] = _ =>{
        return View["play1.cshtml"];
      };

      Post["/player_1_input"] = _ => {
        Player player1 = new Player(Request.Form["input1"]);
        player1.Save();
        return View["play2.cshtml"];
      };
      Post["/player_2_input"] = _ =>{
        Player player2 = new Player(Request.Form["input2"]);
        player2.Save();
        return View["ready.cshtml"];
      };
      Get["/who_wins"] = _ =>{
        List<Player>allPlays = new Player.GetAll();
        return View["/result.cshtml", allPlays];
      };

      }
    }
  }
