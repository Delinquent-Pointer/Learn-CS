namespace LearnCS.test;

public class Tests {
  [SetUp]
  public void Setup() {
  }

  [Test]
  public void Create_List() {

    LinkedList list = new LinkedList();

    list.push(1);
    list.push("hello");
    list.push('W');
    list.push(3.456m);

    list.print();
  }
}