using Tyuiu.GridinAE.Sprint1.TaskReview.V10.Lib;
namespace Tyuiu.GridinAE.Sprint1.TaskReview.V10.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalc()
    {
        DataService dataService = new();
        Assert.AreEqual(-13.142, dataService.Calc(1));
    }
}