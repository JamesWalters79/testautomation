using System;
using System.Collections.Generic;
using System.Text;

namespace testautomation.PageObjects
{
    class OurStoresPageObject
    {
        public bool isOurStoresPageShown()
        {
            //check url is our stores page url http://automationpractice.com/index.php?controller=stores
            return true;
        }

        public void ScrollMap(string direction, string steps)
        {
            //scroll the map in direction by steps
        }

        public byte[] GetMapImageBytesArray()
        {
            //retruns a bytes array of the bytes of the image
            byte[] image = { };
            return image;
        }
    }
}
