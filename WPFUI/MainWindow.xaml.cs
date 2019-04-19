using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using Engine.EventArgs;
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private GameSession _gameSession;
        
        public MainWindow()
        {
            InitializeComponent();
            _gameSession = new GameSession();
            DataContext = _gameSession;
        }

        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveNorth();
        }
        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }
        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();
        }
        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }
        /*private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
            {
                _gameSession.CurrentPlayer.XP = _gameSession.CurrentPlayer.XP + 10;
            }*/
        private void OnGameMessageRaised(object sender, GameMessageEventArgs e)
        {
            GameMessages.Document.Blocks.Add(new Paragraph(new Run(e.Message)));
            GameMessages.ScrollToEnd();
        }
    }
    
}