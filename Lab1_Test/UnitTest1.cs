namespace Lab1_Test;
using Lab1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void AtLeastOneTest()
    {
        Item item = new Item(0, 0, 0);
        for (int i = 1; i < 51; i += 5)
        {
            KnapsackProblem knp = new KnapsackProblem(5, 1);

            knp.items[0] = item;
            List<int> testList = knp.Solve(5).GetItems();

            Assert.IsTrue(testList.Count() >= 1);
        }
    }

    [TestMethod]
    public void NoFittingItem()
    {
        Item item = new Item(0, 100, 0);
        KnapsackProblem knp = new KnapsackProblem(1, 1);
        knp.items[0] = item;

        Assert.IsTrue(knp.Solve(5).GetItems().Count == 0);
    }

    [TestMethod]
    public void OrderInfluenceTest()
    {
        KnapsackProblem knp = new KnapsackProblem(10, 1);
        List<int> testList1 = knp.Solve(5).GetItems();

        knp.items = knp.items.OrderBy(x => Random.Shared.Next()).ToList();
        List<int> testList2 = knp.Solve(5).GetItems();

        CollectionAssert.AreEqual(testList1, testList2);
    }

    [TestMethod]
    public void ValidExampleTest()
    {
        KnapsackProblem knp = new KnapsackProblem(10, 1);
        List<int> validRes = new() { 4, 5 };

        CollectionAssert.AreEqual(knp.Solve(5).GetItems(), validRes);
    }

    [TestMethod]
    public void IsItemsListSortedBeforeSolve()
    {
        KnapsackProblem knp = new KnapsackProblem(10, 1);
        knp.Solve(5);

        for(int i = 1; i < knp.items.Count(); i++)
        {
            Assert.IsTrue(
                knp.items[i - 1].GetRatio() >= knp.items[i].GetRatio()
                );
        }
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void KnapsackArgumentNotZeroTest()
    {
        KnapsackProblem knp = new KnapsackProblem(0,1);
    }

    [TestMethod]
    public void KnapsackProblem_Constructor_ValidArg_Init()
    {
        KnapsackProblem knapsackProblem = new KnapsackProblem(5,10);

        Assert.AreEqual(5, knapsackProblem.n);
        Assert.AreEqual(10, knapsackProblem.seed);
        Assert.AreEqual(5, knapsackProblem.items.Count());
        Assert.IsNotNull(knapsackProblem.items);
    }

    [TestMethod]
    public void KnapsackProblem_Solve_ValidArgs()
    {
        KnapsackProblem knapsackProblem = new KnapsackProblem(50,10);
        int capacity = 20;

        Result result = knapsackProblem.Solve(capacity);

        Assert.IsNotNull(result);
        Assert.IsTrue(result.GetItems().Count() >= 0 &&
            result.GetItems().Count() <= knapsackProblem.n);
        Assert.IsTrue(result.GetTotalVal() >= 0);
        Assert.IsTrue(result.GetTotalWeight() <= capacity);
    }

}
