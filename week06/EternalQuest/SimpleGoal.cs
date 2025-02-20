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

        }

        public override bool IsComplete()
        {
            return true; //placeholder 
        }

        public override string GetStringRepresentation()
        {
           return $"[ ] {_shortName}, {_description}";
        }




}