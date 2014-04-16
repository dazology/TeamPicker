using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public enum Team
    {
        None,
        A,
        B
    }

    public class Player : IComparable<Player>
    {
        private string _sName = string.Empty;
        private int _iShootingAbility = 0;
        private int _iPassingAbility = 0;
        private int _iDefendingAbility = 0;
        private int _iBallControl = 0;
        private int _iGoalkeeping = 0; 
        private int _iTacklingAbility = 0;
        private int _iEnergy = 0;
        private bool bPlaying = false;



        private Team _enSelectedTeam = Team.None;

        #region Properties

        public string Name
        {
            get { return _sName; }
            set { _sName = value; }
        }
        public int ShootingAbility
        {
            get { return _iShootingAbility; }
            set { _iShootingAbility = value; }
        }
        public int PassingAbility
        {
            get { return _iPassingAbility; }
            set { _iPassingAbility = value; }
        }
        public int DefendingAbility
        {
            get { return _iDefendingAbility; }
            set { _iDefendingAbility = value; }
        }
        public int TacklingAbility
        {
            get { return _iTacklingAbility; }
            set { _iTacklingAbility = value; }
        }
        public int Energy
        {
            get { return _iEnergy; }
            set { _iEnergy = value; }
        }
        public int BallControl
        {
            get { return _iBallControl; }
            set { _iBallControl = value; }
        }
        
        public int Goalkeeping
        {
            get { return _iGoalkeeping; }
            set { _iGoalkeeping = value; }
        }
        public Team SelectedTeam
        {
            get { return _enSelectedTeam; }
            set { _enSelectedTeam = value; }
        }
        public bool HasTeamSelected
        {
            get { return _enSelectedTeam != Team.None; }
        }

        public double Overall
        {
            get
            {
                return Math.Round((((double)(_iShootingAbility + _iPassingAbility + _iDefendingAbility + _iTacklingAbility + _iBallControl + _iGoalkeeping + _iEnergy)) / 7), 2, MidpointRounding.AwayFromZero);
            }
        }

        public bool Playing
        {
            get { return bPlaying; }
            set { bPlaying = value; }
        }

        #endregion

        public Player()
        {

        }

        public Player(string name, int shooting, int passing, int defending, int tackling, int ballControl, int goalkeeping, int energy )
        {
            this.Name = name;
            this.ShootingAbility = shooting;
            this.PassingAbility = passing;
            this.DefendingAbility = defending;
            this.TacklingAbility = tackling;
            this.BallControl = ballControl;  
            this.Goalkeeping = goalkeeping;
            this.Energy = energy;
        }

        public int CompareTo(Player obj)
        {
            return obj.Overall.CompareTo(this.Overall);
        }

        //public static IComparer sortNameAscending()
        //{
        //    return (IComparer)new sortNameAscending();
        //}


        //public int CompareTo(Player obj)
        //{
        //    return obj.Name.CompareTo(this.Name);
        //}
    }
}
