using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class DBTests
    {
        [TestMethod]
        public void StoredProcedureReturnCorrectResult()
        {
            // Arrange
            var expectedRes = "1 2 F 4 L F 7 8 F L 11 F 13 14 F L 16 17 F 19 L F 22 23 F L 26 F 28 29 F L 31 32 F 34 L F 37 38 F L 41 F 43 44 F L 46 47 F 49 L F 52 53 F L 56 F 58 59 F L 61 62 F 64 L F 67 68 F L 71 F 73 74 F L 76 77 F 79 L F 82 83 F L 86 F 88 89 F L 91 92 F 94 L F 97 98 F L ";

            // Act
            var res = SqlDbService.ExecuteAction("F", "L");

            // Assert
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void StoredProcedureReturnWrongResultForEmptyNames()
        {
            // Arrange
            var expectedRes = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99 100";

            // Act
            var res = SqlDbService.ExecuteAction("", "");

            // Assert
            Assert.AreNotEqual(expectedRes, res);
        }
    }
}
