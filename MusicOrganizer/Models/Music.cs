using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Disc
  {
    public string DiscArtist { get; set; }
    public string DiscGenre { get; set; }
    public int Id { get; }
    private static List<Disc> _instances = new List<Disc> {};

    public Disc(string discArtist, string discGenre)
    {
      DiscArtist = discArtist;
      DiscGenre = discGenre;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Disc> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Disc Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}

// properties for our class

// public class CD

//     CdArtist
//     CdGenre

// public class Tape
//     TapeArtist
//     TapeGenre
    