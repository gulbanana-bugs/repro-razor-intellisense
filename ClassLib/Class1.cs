using InterfaceGenerator;
namespace ClassLib;

[GenerateAutoInterface]
public class Foo : IFoo
{
    public void Bar() { }
}
