namespace StudentApp;
using SQLite;
using StudentsApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        studentsList.ItemsSource = App.Database.GetItemsStudent();
        groupsList.ItemsSource = App.Database.GetItemsGroup();
        base.OnAppearing();
    }
    // обработка нажатия элемента в списке
    private async void OnItemSelectedStudent(object sender, SelectedItemChangedEventArgs e)
    {
        Student selectedStudent = (Student)e.SelectedItem;
        StudentPage studentPage = new StudentPage();
        studentPage.BindingContext = selectedStudent;
        await Navigation.PushAsync(studentPage);
    }
    // обработка нажатия кнопки добавления
    private void CreateStudent(object sender, EventArgs e)
    {
        Student student = new Student();
        StudentPage studentPage = new StudentPage();
        studentPage.BindingContext = student;
        Navigation.PushAsync(studentPage);
    }

    private void CreateGroup(object sender, EventArgs e)
    {
        Group group = new Group();
        GroupPage groupPage = new GroupPage();
        groupPage.BindingContext = group;
        Navigation.PushAsync(groupPage);
    }

    private async void OnItemSelectedGroup(object sender, SelectedItemChangedEventArgs e)
    {
        Group selectedGroup = (Group)e.SelectedItem;
        GroupPage groupPage = new GroupPage();
        groupPage.BindingContext = selectedGroup;
        await Navigation.PushAsync(groupPage);
    }
}

