using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordTests //: IDisposable
  {

    // public void Dispose()
    // {
    //   Item.ClearAll();
    // }

    [TestMethod]
    public void RecordConstructor_CreatesInstanceOfRecord_Record()
    {
      Record newRecord = new Record("test");
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }

    [TestMethod]
    public void Record_GetRecordTitle_String()
    {
      string recordTitle = "The Wall";
      Record newRecord = new Record(recordTitle);
      string result = newRecord.RecordTitle;
      Assert.AreEqual(result, newRecord.RecordTitle);
    }
     [TestMethod]
    public void Record_SetUpdatedRecordTitle_String()
    {
      string recordTitle = "The Wall";
      Record newRecord = new Record(recordTitle);
      string newTitle = "Dark Side of the Moon";
      newRecord.RecordTitle = newTitle;
      string result = newRecord.RecordTitle;
      Assert.AreEqual(newTitle, result);
    }
  }
}