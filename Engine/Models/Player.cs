using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {

        private string _name;
        private string _characterClass;
        private int _hP;
        private int _experiencePoints;
        private int _level;
        private int _gold;
        public string Name
        { get { return _name;} set { _name = value; OnPropertyChanged(nameof(Name)); } }
        public string CharacterClass
        { get { return _characterClass;} set { _characterClass = value; OnPropertyChanged(nameof(CharacterClass)); } }
        public int HP 
        { get { return _hP;} set { _hP = value; OnPropertyChanged(nameof(HP)); } }

        public int XP
        { get { return _experiencePoints;} set { _experiencePoints = value; OnPropertyChanged(nameof(XP)); } }

        public int Level
        { get { return _level;} set { _level = value; OnPropertyChanged(nameof(Level)); } }
        public int Gold
        { get { return _gold;} set { _gold = value; OnPropertyChanged(nameof(Gold)); } }
        
        public ObservableCollection<GameItem> Inventory { get; set; }

        public ObservableCollection<QuestStatus> Quests { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
            Quests = new ObservableCollection<QuestStatus>();
        }
        
    }
}