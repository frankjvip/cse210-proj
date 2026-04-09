public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
            return GetPoints() + _bonusPoints;
        }
        return GetPoints();
    }

    public override string GetStatus()
    {
        return _isComplete ? $"[X] Completed {_currentCount}/{_targetCount}" :
                             $"[ ] Completed {_currentCount}/{_targetCount}";
    }

    public override string SaveString()
    {
        return $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{_targetCount},{_bonusPoints},{_currentCount},{_isComplete}";
    }
}
