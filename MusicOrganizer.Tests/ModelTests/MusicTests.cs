using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class DiscTests
  {
    // public void Dispose()
    // {
    //   Disc.ClearAll();
    // }
    [TestMethod]
    public void DiscConstructor_CreatesInstanceOfDisc_Disc()
    {
      Disc newDisc = new Disc("test", "test");
      Assert.AreEqual(typeof(Disc), newDisc.GetType());
    }
  }
}