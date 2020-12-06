using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using testautomation.PageObjects;

namespace testautomation.Drivers
{
    public class OurStoresPageDriver
    {
        public bool isOurStoresPageShown()
        {
            var ourStoresPageObject = new OurStoresPageObject();
            return ourStoresPageObject.isOurStoresPageShown();
        }

        public void ScrollMap(string direction, string steps)
        {
            //scroll the map in direction by steps
        }

        public bool CompareImages(string filePath)
        {
            var ourStoresPageObject = new OurStoresPageObject();

            byte[] actual = ourStoresPageObject.GetMapImageBytesArray();
            byte[] expected = System.IO.File.ReadAllBytes(filePath);

            return actual.SequenceEqual(expected);
        }
    }
}
