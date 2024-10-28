using System;
using System.Collections.Generic;

public class GoalManager
{
    private int _score;
    private List<Goal> Goals = new List<Goal>();



    public GoalManager ()
    {
        _score = 0;
    }
    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int score)
    {
        _score = score;
    }   
    public void Start ()
    {
        bool active = true;
           
        while (active)
        {
            Console.Clear();
            Console.WriteLine("MENU OPTIONS");
            Console.WriteLine("1. Create New Goal");        
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userChoice1 = Console.ReadLine();

            switch (userChoice1)
            {
                case "1":
                    CreateGoal ();
                    break;
                
                case "2":
                    ListGoalDetails ();
                    break;
                
                case "3":
                    SaveGoals();
                    break;
                
                case "4":
                    LoadGoals();
                    break;
                
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    active = false;
                    break;
            }


        }
    }
    public void DisplayPlayerInfo()
    {
        Console.Writeline($"Your Score is: {_score}");
    }
    public void ListGoalNames ()
    {
        foreach (string x in Goals)
        {
            Console.WriteLine(x._nameGoal);
        }
    }
    public void ListGoalDetails ()
    {
        foreach (string x in Goals)
        {
            Console.WriteLine(x.GetDetailsString());
        }
    }

    public void CreateGoal ()
    {
        
        bool active = true;
        List<Goal> Goals = new List<Goal>();
        while (active)
        {
            Console.WriteLine("\n The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("Wich type of goal would you like to create?");
            string userChoice2 = Console.ReadLine();


            switch (userChoice2)

            {
                case "1":
                SimpleGoal goal1 = new SimpleGoal();
                Console.WriteLine("What is the name of your goal?: ");
                goal1.SetName = Console.ReadLine();
                Console.WriteLine("Type a description of it: ");
                goal1.SetDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?:  ");
                int points1 = int.Parse(Console.ReadLine());
                goal1.SetPoints = points1;

                Goals.Add(goal1);
                
                break;
                        
                case "2":
                EternalGoal Egoal1 = new EternalGoal();
                Console.WriteLine("What is the name of your goal?: ");
                Egoal1.SetName = Console.ReadLine();
                Console.WriteLine("Type a description of it: ");
                Egoal1.SetDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?:  ");
                int Epoints = int.Parse(Console.ReadLine());
                Egoal1.SetPoints = Epoints;
                Goals.Add(Egoal1);
                
                break;

                case "3":
                ChecklistGoal Cgoal1 = new ChecklistGoal();
                Console.WriteLine("What is the name of your goal?: ");
                Cgoal1.SetName = Console.ReadLine();
                Console.WriteLine("Type a description of it: ");
                Cgoal1.SetDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?:  ");
                int Cpoints = int.Parse(Console.ReadLine());
                Cgoal1.SetPoints = Cpoints;
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?:   ");
                int Cbonus = int.Parse(Console.ReadLine());
                Cgoal1.SetBonus = Cbonus;
                Console.WriteLine("What is the bonus for accomplishing it that many times?:  ");
                int Ctarget = int.Parse(Console.ReadLine());
                Cgoal1.SetTarget = Ctarget;
                Goals.Add(Cgoal1);
                
                break;
            }
        }

    }
    public void RecordEvent ()
    {
        Console.WriteLine("Which goal did you accomplis?: ");
        string answer = (Console.ReadLine());

        Goal goal = null;
        foreach (string x in Goals)
        {
            if (x._nameGoal == answer)
            {
                goal = x;
                break;
            }
        }
        if (goal != null)
        {
            int points = goal.RecordEvent();
            _score += points;
            Console.WriteLine($"{answer} Points {points}, Total {_score}");

        }

    }

    public void SaveGoals (string file)
    {
        Console.WriteLine("Type the name for your file: ");
        string outputFile = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string x in Goals)
            {
                outputFile.WriteLine(x.GetStringRepresentation());
            }
            outputFile.WriteLine($"Score = {_score}");
        }
    }
    public void LoadGoals()
    {
        
        Console.WriteLine("Type the name of your file: ");
        string filename = (Console.ReadLine());
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string  goal = parts[0];
            string  name = parts[1];
            string descripTion = parts[2];
            int points = int.Parse(parts[3]);
            
        }
    }

}