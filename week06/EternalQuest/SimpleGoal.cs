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
                Console.WriteLine($"You have already completed the goal: {_shortName}");
            }
            else
            {
                _isComplete = true;
            }
        }

        public override bool IsComplete()
        {
            return _isComplete;  
        }

        public override string GetStringRepresentation()
        {
            if (_isComplete)
            {
                return $"[✓] {_shortName}, {_description}";
            }
            else
            {
                return $"[ ] {_shortName}, {_description}";
            }
        }

}