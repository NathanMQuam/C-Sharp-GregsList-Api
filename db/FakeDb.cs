using System.Collections.Generic;
using gregslist_api.Models;

namespace gregslist_api.db
{
   public class FakeDB
   {

      //NOTE make sure you instantiate your list before you try to access it.
      public static List<CarListing> Cars { get; set; } = new List<CarListing>();
   }
}