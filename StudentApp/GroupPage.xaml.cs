using StudentApp;

namespace StudentApp;

public partial class GroupPage : ContentPage
{
	public GroupPage()
	{
		InitializeComponent();
	}

    private void SaveGroup(object sender, EventArgs e)
    {
        var group = (Group)BindingContext;
        if (!String.IsNullOrEmpty(group.Title))
        {
            App.Database.SaveItemGroup(group);
        }
        this.Navigation.PopAsync();
    }

    private void DeleteGroup(object sender, EventArgs e)
    {
        var group = (Group)BindingContext;
        App.Database.DeleteItemStudent(group.IdGroup);
        this.Navigation.PopAsync();
    }

    private void Cancel(object sender, EventArgs e)
    {
        this.Navigation.PopAsync();
    }
}