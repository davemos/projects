using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myRetail.Models;

namespace FileProcessTest
{
    [TestClass]
    public class FileProcessTest
    {
        private string _GoodFileName;

        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            tc.WriteLine("do class initilization");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }

        [TestMethod]
        public void FileNameDoesExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;
            TestContext.WriteLine("Creating the file: ");
            fromCall = fp.FileExists(@"c:\windows\regedit.exe");
            Assert.IsTrue(fromCall);
           
        }

        [TestInitialize]
        public void TestInitialize()
        {
            if (TestContext.TestName == "FileNameDoesExist")
            {
                if (!string.IsNullOrEmpty(_GoodFileName))
                {
                    TestContext.WriteLine("Creating File: " + _GoodFileName);
                }
            }
        }
        [TestMethod]
        public void FileNameDoesNotExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;
            fromCall = fp.FileExists(@"c:\windows\badfilename.exe");
            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameIsEmptyOrNull_ThrowsException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");
        }
        [TestMethod]
        public void FileNameIsEmptyOrNull_ThrowsException_UseTryCatch()
        {
            FileProcess fp = new FileProcess();
            try
            {
                fp.FileExists("");
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("Call to FileExists did NOT throw a NullArgument Exception");
        }
    }
}
