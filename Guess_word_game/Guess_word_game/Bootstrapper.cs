﻿using Microsoft.Practices.Unity;
using Prism.Unity;
using Guess_word_game.Views;
using System.Windows;
using Guess_word_game.Abstractions;
using Guess_word_game.Providers;
using Guess_word_game.Services;

namespace Guess_word_game
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            Container.RegisterType<IQuestionsProvider, QuestionProvider>();
            Container.RegisterType<IGameService, GameService>();

            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}