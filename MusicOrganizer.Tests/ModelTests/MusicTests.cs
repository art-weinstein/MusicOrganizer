using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class DiscTests : IDisposable
  {
    public void Dispose()
    {
      Disc.ClearAll();
    }
    [TestMethod]
    public void DiscConstructor_CreatesInstanceOfDisc_Disc()
    {
      Disc newDisc = new Disc("test", "test");
      Assert.AreEqual(typeof(Disc), newDisc.GetType());
    }

    [TestMethod]
    public void GetDiscArtist_ReturnsDiscArtistName_String()
    {
      string discArtist = "Tool";
      Disc newDisc = new Disc(discArtist, "test");
      string result = newDisc.DiscArtist;
      Assert.AreEqual(discArtist, result);
    }

    [TestMethod]
    public void GetDiscGenre_ReturnsDiscGenreName_String()
    {
      string discGenre = "Rock";
      Disc newDisc = new Disc("test", discGenre);
      string result = newDisc.DiscGenre;
      Assert.AreEqual(discGenre, result);
    }

    [TestMethod]
    public void GetAll_ReturnAnEmptyList_DiscList()
    {
      List<Disc> newList = new List<Disc> {};
      List<Disc> result = Disc.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}