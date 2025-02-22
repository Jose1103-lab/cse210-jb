using System;

public class EternalGoal : Goal{

    public EternalGoal(string name, string description, int point) :base(name, description, point) {
        _shortName = name;
        _description = description;
        _points = point;

    }

        public override void RecordEvent()
        {
            
        }

        public override bool IsComplete()
        {
            return false; //placeholder 
        }

        public override string GetStringRepresentation()
        {
            return $"[ ] {_shortName}, {_description}";
        }



}