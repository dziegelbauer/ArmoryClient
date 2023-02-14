namespace ArmoryClient.UI.ViewModel;

public class LookupItemViewModel
{
    public LookupItemViewModel(int id, string displayMember)
    {
        Id = id;
        DisplayMember = displayMember;
    }

    public int Id { get; set; }
    public string DisplayMember { get; set; }
}