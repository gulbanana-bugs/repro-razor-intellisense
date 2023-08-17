namespace WebApp.Pages;

public partial class Index
{
    private void UseClassLib2()
    {
        ClassLib.IFoo foo = new ClassLib.Foo();
        foo.Bar();
    }
}
