using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregation.SuperAbilities;
using InterfaceSegregation.SuperHeroes;

namespace InterfaceSegregation
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<Human> marvelTeam = new List<Human>();
			List<Human> dcTeam;

			Human stanislav = XMenLaboratory.CreateSuperHero(typeof(Mysterio));
			Human vladislav = XMenLaboratory.CreateSuperHero(typeof(Mysterio));
			Human sergey = XMenLaboratory.CreateSuperHero(typeof(Incorporeal));

			marvelTeam = new List<Human>()
			{
				stanislav,
				vladislav,
				sergey
			};

			Human johny = XMenLaboratory.CreateSuperHero(typeof(SnakeEye));
			Human rouney = XMenLaboratory.CreateSuperHero(typeof(SnakeEye));
			Human fergie = XMenLaboratory.CreateSuperHero(typeof(Incorporeal));
			Human doney = XMenLaboratory.CreateSuperHero(typeof(Mysterio));

			dcTeam = new List<Human>()
			{
				johny,
				rouney,
				fergie,
				doney
			};

			Dictionary<List<Human>, double> teamsVictoryProbability = XMenLaboratory.FightSimulator.TeamsVictoryProbability(marvelTeam, dcTeam);
			Console.WriteLine(nameof(marvelTeam) + " going to win with probability in sucess " + teamsVictoryProbability[marvelTeam]);
			Console.WriteLine(nameof(dcTeam) + " going to win with probability in sucess " + teamsVictoryProbability[dcTeam]);

			Console.ReadKey(true);
		}
	}
}
