using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using IntComponent.Interfaces;
using Xamarin.Forms;
using IntComponent.Droid.CustomRenderer;
using Com.Reflectionsinfos.Nativelibrary;
//using Com.Reflectionsinfos.Xamarinnativetest;

[assembly: Dependency(typeof(TextCounter_Android))]
namespace IntComponent.Droid.CustomRenderer
{
    public class TextCounter_Android : ITextCounter
    {
        public void ShowMessage(string text)
        {
            try
            {
                LibraryClass cls = new LibraryClass();
                //cls.ShowMessage(text);
                //cls.OpenView(AndroidGlobal.glCtx, text);
                //cls.OpenView(text);
                //ShowView view = new ShowView();
                //view.Show
                var x = AndroidGlobal.glCtx;
                var t = cls.ReturnMessage(text);
                //cls.OpenGallery(x);
                //cls.OpenView(x, "Testing");

                //cls.OpenView(x);

            }
            catch(Exception ex)
            { }
        }
    }
}