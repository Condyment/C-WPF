using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Program_1
{
    class Person:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string firstName;
        private string lastName;
        private string fullName;

        public string FirstName
        {

            get {
               
                return firstName; }

            set {if (firstName != value)
                {
                    
                    firstName = value;
                    onepropretychanged("FirstName");
                  //  onepropretychanged("LastName");
                    onepropretychanged("FullName");
                }


            }
        }
        public string LastName
        {
            get {  return lastName; }
            set
            {
                if ( lastName != value)
                {
                    
                    lastName = value;
                    onepropretychanged("LastName");
                   // onepropretychanged("FirstName");
                    onepropretychanged("FullName");

                }


            }
        }
        public string FullName
        {
            get {
                MessageBox.Show("RP2");
                return fullName=firstName+" "+lastName; }
            set
            {
                if (fullName != value)
                {
                   
                    fullName = value;
                    onepropretychanged("FullName");
                   
                }


            }


        }
        private void onepropretychanged(string proprety)
        {
            if (PropertyChanged != null)
            {if (proprety.Equals("FullName"))
                    {
                    MessageBox.Show("RP1");
                }
                
                PropertyChanged(this,new PropertyChangedEventArgs(proprety));

            }


        }



       
    }
}
