using System;
using System.Collections.Generic;

namespace IK.DesignPatterns.IKPracticeProblems.TicTacToe
{

    public enum PlayerType
    {
        X,
        O
    }


    public class Player
    {
        public int UserId { get; set; }
        public PlayerType Type { get; set; }

        public Player(PlayerType type)
        {
            Random random = new Random();
            UserId = random.Next();
            Type = type;
        }
      
    }

    abstract class Game
    {
        public abstract void GetState();
    }

    class NewGame : Game
    {
        public override void GetState()
        {
            Console.WriteLine("New Game");
        }
    }

    class InProgress : Game
    {
        public override void GetState()
        {
            Console.WriteLine("In Progress");
        }
    }

    class GameOver : Game
    {
        public override void GetState()
        {
            Console.WriteLine("Game Over");
        }
    }


    public class Board
    {
      
        Game gameObserver;

        public List<Player> Players { get; set; }


        public int GameId { get; set; }
        private int[,] positions { get; set; }

        public Board(int dimension)
        {
            if (positions == null) {
                positions = new int[dimension, dimension];
            }

            if (Players == null)
                Players = new List<Player>();

            gameObserver = new NewGame();

            gameObserver.GetState();
        }

        public void AddPlayer(PlayerType type)
        {
            Players.Add(new Player(type));
            Console.WriteLine("Player " + type.ToString() + " added.");
        }

       

        public int[,] Move(int userId,int row, int col)
        {
            positions[row,col] = userId;
            gameObserver = new InProgress();

            gameObserver.GetState();

            Console.WriteLine("UserId: " + userId + " moved to row " + row + " col: " + col);

            return positions;
        }
    }


    public static class TicTacToe
    {
        public static void TestTicTacToe()
        {
            //Create new game
            var game = new Board(3);


            //Add player X
            game.AddPlayer(PlayerType.X);

            //add player O
            game.AddPlayer(PlayerType.O);


            //move X
            game.Move(game.Players[0].UserId, 1, 2);

            //move Y
            game.Move(game.Players[1].UserId, 0, 1);


        }
    }
}
