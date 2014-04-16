using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Generator
    {
        public static void GenerateTeams(ref List<Player> vlPlayers)
        {
            
            vlPlayers.Sort();

            for (int i = 0; i < vlPlayers.Count; i++)
            {
                Player playerA = vlPlayers[i] as Player;
                Player playerB = null;

                if (i + 1 < vlPlayers.Count)
                {
                    playerB = vlPlayers[i + 1];
                }

                if (TeamTotal(vlPlayers, Team.A) <= TeamTotal(vlPlayers, Team.B))
                {
                    playerA.SelectedTeam = Team.A;

                    if (playerB != null)
                    {
                        playerB.SelectedTeam = Team.B;
                    }
                }
                else
                {
                    playerA.SelectedTeam = Team.B;

                    if (playerB != null)
                    {
                        playerB.SelectedTeam = Team.A;
                    }
                }

                i++;
            }
        }



        public static double TeamTotal(List<Player> vlPlayers, Team team)
        {
            double total = 0;

            foreach (Player player in vlPlayers)
            {
                if (player.SelectedTeam == team)
                {
                    total += player.Overall;
                }
            }

            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }

        public static double TeamTotalShooting(List<Player> vlPlayers, Team team)
        {
            double total = 0;

            foreach (Player player in vlPlayers)
            {
                if (player.SelectedTeam == team)
                {
                    total += player.ShootingAbility;
                }
            }

            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }

        public static double TeamTotalPassing(List<Player> vlPlayers, Team team)
        {
            double total = 0;

            foreach (Player player in vlPlayers)
            {
                if (player.SelectedTeam == team)
                {
                    total += player.PassingAbility;
                }
            }

            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }

        public static double TeamTotalTackling(List<Player> vlPlayers, Team team)
        {
            double total = 0;

            foreach (Player player in vlPlayers)
            {
                if (player.SelectedTeam == team)
                {
                    total += player.TacklingAbility;
                }
            }

            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }

        public static double TeamTotalDefending(List<Player> vlPlayers, Team team)
        {
            double total = 0;

            foreach (Player player in vlPlayers)
            {
                if (player.SelectedTeam == team)
                {
                    total += player.DefendingAbility;
                }
            }

            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }

        public static double TeamTotalEnergy(List<Player> vlPlayers, Team team)
        {
            double total = 0;

            foreach (Player player in vlPlayers)
            {
                if (player.SelectedTeam == team)
                {
                    total += player.Energy;
                }
            }

            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }

        public static double TeamTotalGoalkeeping(List<Player> vlPlayers, Team team)
        {
            double total = 0;

            foreach (Player player in vlPlayers)
            {
                if (player.SelectedTeam == team)
                {
                    total += player.Goalkeeping;
                }
            }

            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }

        public static double TeamTotalBallControl(List<Player> vlPlayers, Team team)
        {
            double total = 0;

            foreach (Player player in vlPlayers)
            {
                if (player.SelectedTeam == team)
                {
                    total += player.BallControl;
                }
            }

            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }


    }
}
