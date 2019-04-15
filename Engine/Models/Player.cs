using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {

        private string _name;
        private string _characterClass;
        private int _hP;
        private int _experiencePoints;
        private int _level;
        private int _gold;
        public string Name
        {
            get { return _name;}
            set
            { _name = value; OnPropertyChanged("Name"); }
        }
        public string CharacterClass
        {
            get { return _characterClass;}
            set
            { _characterClass = value; OnPropertyChanged("CharacterClass"); }
        }
        public int HP 
        {
            get { return _hP;}
            set
            { _hP = value; OnPropertyChanged("HP"); }
        }

        public int XP
        {
            get { return _experiencePoints;}
            set
            { _experiencePoints = value; OnPropertyChanged("XP"); }
        }

        public int Level
        {
            get { return _level;}
            set
            { _level = value; OnPropertyChanged("Level"); }
        }
        public int Gold
        {
            get { return _gold;}
            set
            { _gold = value; OnPropertyChanged("Gold"); }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}