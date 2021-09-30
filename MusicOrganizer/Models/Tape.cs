using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Tape
  {
    public string TapeArtist { get; set; }
    public string TapeGenre { get; set; }
    public int Id { get; }
    private static List<Tape> _instances = new List<Tape> {};

    public Tape(string tapeArtist, string tapeGenre)
    {
      TapeArtist = tapeArtist;
      TapeGenre = tapeGenre;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Tape> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}