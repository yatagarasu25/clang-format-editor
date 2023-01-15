using System.Linq;

namespace ClangFormatEditor.MVVM.Models
{
  public class FormatOptionSelectModelValue
  {
    public int Version = -1;
    public string Name;
    public string Value;
    public string Description;
  }

  public class FormatOptionSelectModel : FormatOptionModel
  {
    #region Members

    private string description = string.Empty;
    private string input = string.Empty;

    #endregion

    #region Constructor

    public FormatOptionSelectModel()
    {
      HasInputTextBox = true;
    }

    #endregion

    #region Properties

    public override string Description {
      get { return string.Join("\r\n", description, "Possible values:"
        , string.Join("\r\n", Values.Select(v => $"{v.Name} (in configuration: {v.Value}) {v.Description}"))); }
      set { description = value; }
    }

    public FormatOptionSelectModelValue[] Values { get; set; }

    public string Input
    {
      get
      {
        return input;
      }
      set
      {
        input = value;
        if (IsEnabled == false)
          IsEnabled = true;

        OnPropertyChanged("Input");
      }
    }

    #endregion
  }
}
