using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class TapeTests : IDisposable
  {
    public void Dispose()
    {
      Tape.ClearAll();
    }
    [TestMethod]
    public void TapeConstructor_CreatesInstanceOfTape_Tape()
    {
      Tape newTape = new Tape("test", "test");
      Assert.AreEqual(typeof(Tape), newTape.GetType());
    }

    [TestMethod]
    public void GetTapeArtist_ReturnsTapeArtistName_String()
    {
      string tapeArtist = "Tool";
      Tape newTape = new Tape(tapeArtist, "test");
      string result = newTape.TapeArtist;
      Assert.AreEqual(tapeArtist, result);
    }

    [TestMethod]
    public void GetTapeGenre_ReturnsTapeGenreName_String()
    {
      string tapeGenre = "Rock";
      Tape newTape = new Tape("test", tapeGenre);
      string result = newTape.TapeGenre;
      Assert.AreEqual(tapeGenre, result);
    }

    [TestMethod]
    public void GetAll_ReturnAnEmptyList_TapeList()
    {
      List<Tape> newList = new List<Tape> {};
      List<Tape> result = Tape.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}