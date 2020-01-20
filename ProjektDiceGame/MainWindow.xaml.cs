﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary;

namespace ProjektDiceGame
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int enemyD1, enemyD2, myD1, myD2, betMoney, money;

        public MainWindow()
        {
            InitializeComponent();

<<<<<<< HEAD
            Money.Content = "100";
            BetMoney.Text = "";

            SetupEnemies();
        }

        private void SetupEnemies()
        {
            enemyD1 = DiceManagement.ThrowDie();
            enemyD2 = DiceManagement.ThrowDie();

            EnemyDie1.Source = new BitmapImage(new Uri("images/D" + enemyD1 + ".png", UriKind.Relative));
            EnemyDie2.Source = new BitmapImage(new Uri("images/D" + enemyD2 + ".png", UriKind.Relative));
        }

        private void SetupMine()
        {
            myD1 = DiceManagement.ThrowDie();
            myD2 = DiceManagement.ThrowDie();

            MyDie1.Source = new BitmapImage(new Uri("images/D" + myD1 + ".png", UriKind.Relative));
            MyDie2.Source = new BitmapImage(new Uri("images/D" + myD2 + ".png", UriKind.Relative));
        }

        private void ResetGame()
        {
            MyDie1.Source = new BitmapImage(new Uri("images/D0.png", UriKind.Relative));
            MyDie2.Source = new BitmapImage(new Uri("images/D0.png", UriKind.Relative));

            BetMoney.Text = "";

            SetupEnemies();
=======
            Money.Text = "50";
            BetMoney.Text = "";
>>>>>>> 374500772276111782d8745afd290b28ea15b875
        }

        private void Higher_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            Int32.TryParse(BetMoney.Text, out betMoney);
            Int32.TryParse(Money.Content.ToString(), out money);

            if (MoneyHandling.CheckBetMoney(betMoney, money) == 1)
            {
                SetupMine();
                if (DiceManagement.CheckDiceHigher(enemyD1, enemyD2, myD1, myD2) == -1)
                {
                    MessageBox.Show("You lost!");
                    Money.Content = MoneyHandling.MakeMoney(betMoney, money, -1).ToString();
                }
                else if (DiceManagement.CheckDiceHigher(enemyD1, enemyD2, myD1, myD2) == 1)
                {
                    MessageBox.Show("You won!");
                    Money.Content = MoneyHandling.MakeMoney(betMoney, money, 1).ToString();
                }
                else if (DiceManagement.CheckDiceHigher(enemyD1, enemyD2, myD1, myD2) == 0)
                {
                    MessageBox.Show("You tied!");
                }

                ResetGame();
            }
            else if (MoneyHandling.CheckBetMoney(betMoney, money) == 0)
                MessageBox.Show("Set amount of money you want to bet!");
            else if (MoneyHandling.CheckBetMoney(betMoney, money) == -1)
            {
                MessageBox.Show("You can't bet more money than you have!");
                BetMoney.Text = money.ToString();
            }
=======
            MessageBox.Show(sender.ToString());
>>>>>>> 374500772276111782d8745afd290b28ea15b875
        }

        private void Lower_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            Int32.TryParse(BetMoney.Text, out betMoney);
            Int32.TryParse(Money.Content.ToString(), out money);

            if (MoneyHandling.CheckBetMoney(betMoney, money) == 1)
            {
                SetupMine();
                if (DiceManagement.CheckDiceLower(enemyD1, enemyD2, myD1, myD2) == -1)
                {
                    MessageBox.Show("You lost!");
                    Money.Content = MoneyHandling.MakeMoney(betMoney, money, -1).ToString();
                }
                else if (DiceManagement.CheckDiceLower(enemyD1, enemyD2, myD1, myD2) == 1)
                {
                    MessageBox.Show("You won!");
                    Money.Content = MoneyHandling.MakeMoney(betMoney, money, 1).ToString();
                }
                else if (DiceManagement.CheckDiceLower(enemyD1, enemyD2, myD1, myD2) == 0)
                {
                    MessageBox.Show("You tied!");
                }

                ResetGame();
            }
            else if (MoneyHandling.CheckBetMoney(betMoney, money) == 0)
                MessageBox.Show("Set amount of money you want to bet!");
            else if (MoneyHandling.CheckBetMoney(betMoney, money) == -1)
            {
                MessageBox.Show("You can't bet more money than you have!");
                BetMoney.Text = money.ToString();
            }
=======
            MessageBox.Show(sender.ToString());
>>>>>>> 374500772276111782d8745afd290b28ea15b875
        }

        private static bool IsTextNumeric(string text)
        {
            Regex _regex = new Regex("[^0-9]");
            return _regex.IsMatch(text);
        }

        private void NumericOnly(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsTextNumeric(e.Text);
        }

        private void BetMoneyPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (IsTextNumeric(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}
