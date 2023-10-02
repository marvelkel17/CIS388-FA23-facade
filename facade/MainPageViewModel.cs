using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace facade
{
	public partial class MainPageViewModel: ObservableObject 
	{
		[ObservableProperty]
		private string secretColor;

		[ObservableProperty]
		private string currentGuess;

		[ObservableProperty]
		private int guessNumber;


        public ObservableCollection<ColorGuess> Guesses { get; set; }

        //public string SecretColor { get; set; }

        public MainPageViewModel()
		{
			secretColor = "FACADE";
			currentGuess = "";

            Guesses = new ObservableCollection<ColorGuess>();

			guessNumber = 6;

			

		}


		[RelayCommand]
		void AddLetter(string letter)
		{
			if( CurrentGuess.Length < 6)
			{
				CurrentGuess += letter.ToLower();
            }
		}


		[RelayCommand]
		void Delete()
		{
			if (CurrentGuess.Length > 0)
			{
                CurrentGuess = CurrentGuess.Remove(CurrentGuess.Length - 1);
            }
            
        }

		[RelayCommand]
		async Task ResetMain()
		{
            await Shell.Current.GoToAsync($"..");
        }

		[RelayCommand]
		async Task GuessAsync()
		{
			if (CurrentGuess.Length == 6)
			{
				if (CurrentGuess == SecretColor)
				{
                    await Shell.Current.GoToAsync($"{nameof(YouWonPage)}");
                    Guesses.Clear();
					CurrentGuess = "";
                    GuessNumber = 6;

                }
				else if (CurrentGuess != SecretColor)
				{
					if (Guesses.Count != 5)
					{
                        Guesses.Add(new ColorGuess($"#{CurrentGuess.ToLower()}"));
                        CurrentGuess = "";
						GuessNumber = 6 - Guesses.Count;
                    }
					else
					{
                        await Shell.Current.GoToAsync($"{nameof(GameOverPage)}");
                        Guesses.Clear();
                        CurrentGuess = "";
						GuessNumber = 6;
                        
                    }
				}
                
                
            }

		}


	}
}

