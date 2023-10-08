using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using TestTemplate.models;

namespace TestTemplate
{
   public partial class MainWindow : Window
   {
      List<Contact> contacts { get; set; }

      public MainWindow()
      {
         InitializeComponent();
         LoadContacts();
      }

      private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
      {
         DragMove();
      }

      private void LoadContacts()
      {
         contacts = new List<Contact> {
            new Contact()
            {
               ContactName = "Contact 1",
               ContactType = "Text",
               Phone = "+00000001",
               Email = "test1@contact.com"
            },
            new Contact()
            {
               ContactName = "Contact 2",
               ContactType = "Text",
               Phone = "+00000002",
               Email = "test2@contact.com"
            },
            new Contact()
            {
               ContactName = "Contact 3",
               ContactType = "Text",
               Phone = "+00000003",
               Email = "test3@contact.com"
            }
         };
         this.contactsList.ItemsSource = contacts;
      }
   }
}
