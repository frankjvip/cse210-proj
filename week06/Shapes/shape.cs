public class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    // Método virtual que será sobrescrito en las clases derivadas
    public virtual double GetArea()
    {
        return 0;
    }
}
