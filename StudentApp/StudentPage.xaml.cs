using StudentApp;

namespace StudentsApp;

public partial class StudentPage : ContentPage
{
    public StudentPage()
    {
        InitializeComponent();

        List<string> groupTitles = new List<string>();
        foreach (var group in App.Database.GetItemsGroup()) groupTitles.Add(group.Title);
        groupPicker.ItemsSource = groupTitles;
    }

    private void SaveStudent(object sender, EventArgs e)
    {
        var student = (Student)BindingContext;

        student.IdGroup = groupPicker.SelectedIndex + 1;

        if (!String.IsNullOrEmpty(student.IdGroup.ToString()) && !String.IsNullOrEmpty(student.FIO))
        {
            App.Database.SaveItemStudent(student);
        }
        this.Navigation.PopAsync();
    }
    private void DeleteStudent(object sender, EventArgs e)
    {
        var student = (Student)BindingContext;
        App.Database.DeleteItemStudent(student.Id);
        this.Navigation.PopAsync();
    }
    private void Cancel(object sender, EventArgs e)
    {
        this.Navigation.PopAsync();
    }
}