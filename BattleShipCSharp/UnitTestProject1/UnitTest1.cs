using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwinGameSDK;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckingChoosingShipsInSettingGame1()
        {
            Point2D pt = default(Point2D);
            pt.X = 10;
            pt.Y = 670;
            //arrange
            ShipName shipNameTest = DeploymentController.GetShipMouseIsOverTest(pt);
            //act
            ShipName actual = ShipName.Destroyer;
            //assert
            Assert.AreEqual(actual, shipNameTest);
        }
        
    }
}
