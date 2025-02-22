using System;

public class SimpleGoal : Goal{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int point, bool status) :base(name, description, point) {
        _shortName = name;
        _description = description;
        _points = point;
        _isComplete = status;
    }

        public override void RecordEvent()
        {   
            if (_isComplete)
            {
                Console.WriteLine("You have already completed the goal");
            }
            else
            {
                _isComplete = true;
                Console.WriteLine("Congratulations! You have completed the goal");
            }
        }

        public override bool IsComplete()
        {
            return _isComplete;  
        }

        public override string GetStringRepresentation()
        {
            return $"Simple Goal,{_shortName},{_description},{_isComplete},{_points}";
        }

}