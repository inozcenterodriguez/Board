﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TheGame
{
    public class Game

    {
        int Num_players;//numero de jugadores
        int ActualTurn; // numero de jugador con el turno actual
        bool Pause; // pausa
         







        public Game()
        {
        

        }

        public void RestartGame()
        {

        }

        public void EndGame()
        {

        }

        public void ChangeTurn()
        {

        }




    }



    public class Player
    {
        int points;
        string PlayerState;
        int PlayerId;
        int playerPosition;

        



        public  Player(int id)
        {
            points = 0;
            PlayerState = "Start";
            PlayerId = id;
            playerPosition = 0;


        }

        public void  PlayerAdvance(int number)
        {
            playerPosition = playerPosition + number;


        }





    }

    public class PowerCard
    {


    }

    public class CasualityCard
    {

    }


    public class Place
    {

    }

}
