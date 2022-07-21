using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string RecordTitle { get; set; }
    public int Id { get; }

    public Record(string recordTitle)
    {
      RecordTitle = recordTitle;
    }
  }
}