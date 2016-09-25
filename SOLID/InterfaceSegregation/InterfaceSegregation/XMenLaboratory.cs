using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregation.SuperAbilities;

namespace InterfaceSegregation
{
	internal class XMenLaboratory
	{
		public static Dictionary<Type, double> abilityPoints;

		public static Human CreateSuperHero(Type heroTypeToCreate)
		{
			Human hero = Activator.CreateInstance(heroTypeToCreate) as Human;
			return hero;
		}

		static XMenLaboratory()
		{
			abilityPoints = new Dictionary<Type, double>();
			abilityPoints.Add(typeof(IFlyable), 2.0f);
			abilityPoints.Add(typeof(IInvisible), 4.0f);
			abilityPoints.Add(typeof(IMindsReadable), 6.0f);
			abilityPoints.Add(typeof(IWallWalkable), 1.0f);
		}

		internal class FightSimulator
		{
			public static double ForceOfTeam(List<Human> team)
			{
				double force = 0;

				foreach (Human hero in team)
				{
					force += ForceOfHuman(hero);
				}

				return force;
			}

			public static double ForceOfHuman(Human hero)
			{
				double force = 0;

				Type[] humanInterfaces = hero.GetType().GetInterfaces();

				foreach (Type humanInterface in humanInterfaces)
				{
					if (typeof(ISuperAbility).IsAssignableFrom(humanInterface) && humanInterface != typeof(ISuperAbility))
					{
						force += XMenLaboratory.abilityPoints[humanInterface];
					}
					
				}

				return force;
			}

			public static Dictionary<List<Human>, double> TeamsVictoryProbability(List<Human> team1, List<Human> team2)
			{
				Dictionary<List<Human>, double> teamsVictoryProbability = new Dictionary<List<Human>, double>();

				double team1Force = ForceOfTeam(team1);
				double team2Force = ForceOfTeam(team2);

				double sum = team1Force + team2Force;

				double team1VictoryProbability = team1Force / sum;
				double team2VictoryProbability = team2Force / sum;

				teamsVictoryProbability.Add(team1, team1VictoryProbability);
				teamsVictoryProbability.Add(team2, team2VictoryProbability);

				return teamsVictoryProbability;
			}
		}
	}
}
