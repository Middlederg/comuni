﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Comuni.Core
{

    public class BuildingCard
    {
        public static Color BackgroundGenericColor = Color.Beige;
        public static Color ResourceGenericColor = Color.Gray;

        public static BuildingCard Create(int level, string name) => new BuildingCard(level, name);

        private readonly string name;
        private readonly List<BuildingType> buildingTypesAllowed;

        public int Level { get; }
        public InvasionDeck Deck { get; internal set; }
        public int TotalMaxPlayers { get; internal set; }

        private BuildingCard(int nivel, string nombre)
        {
            Level = nivel;
            name = nombre;
            TotalMaxPlayers = 0;
            buildingTypesAllowed = new List<BuildingType>();
        }

        internal void AddType(BuildingType tipo) => buildingTypesAllowed.Add(tipo);

        public bool IsFromType(BuildingType tipo) => buildingTypesAllowed.Any(x => tipo == x);

        public bool IsGeneric => buildingTypesAllowed.Count() > 1;

        public Color GetBackColor
        {
            get
            {
                if (IsGeneric)
                {
                    return BackgroundGenericColor;
                }
                return buildingTypesAllowed.First().Color;
            }
        }
        public Color GetBorderColor
        {
            get
            {
                if (IsGeneric)
                {
                    return ResourceGenericColor;
                }
                return buildingTypesAllowed.First().GetBorder;
            }
        }

        public override string ToString() => name;
    }


}
