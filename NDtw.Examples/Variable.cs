using NDtw.Preprocessing;

namespace NDtw.Examples;

public class Variable
{
    public string Name { get; set; }
    public IPreprocessor Preprocessor { get; set; }
    public double Weight { get; set; }
}
