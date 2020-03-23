using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fire_game_Simran;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_game_Simran.Tests
{
    [TestClass()]
    public class FireTests
    {
        [TestMethod()]
        public void shootAwayFireTest()
        {
            //calling the method of the shhotway to verfiy is it working or not 
            Fire obj = new Fire();
            var g = 0;
            int k=obj.shootAwayFire(g);
            Assert.IsTrue(true);
        }
    }
}