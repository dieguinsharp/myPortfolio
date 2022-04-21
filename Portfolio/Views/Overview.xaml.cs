using Ooui;
using Portfolio.Core;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portfolio.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Overview:ContentPage {
        public Overview () {
            InitializeComponent();
            /*listTest.ItemsSource = new List<Person>() {
                new Person(),
                new Person(),
                new Person(),
                new Person(),
                new Person()
            };*/

            myImg.Source = ImageSource.FromFile("Images/myImg.png");
        }
    }

    public class CustomButton : Ooui.Button {
        public CustomButton () {
            this.MouseLeave += OnMouseLeave;
            this.MouseOver += OnMouseOver;
        }

        public void OnMouseLeave (object sender, EventArgs args) {

        }

        public void OnMouseOver (object sender, EventArgs args) {

        }
    }

    public class Person {
        public string Name { get; set; } = "Dg";
    }
}