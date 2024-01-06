﻿using System.ComponentModel;

namespace PO_project.Enums
{
	public enum Matura
	{
        [Description("Matematyka podstawowa")]
		MatematykaP = 0,

		[Description("Matematyka rozszerzona")]
		MatematykaR = 1,

		[Description("Język polski podstawowy")]
		JezykPolskiP = 2,
		JezykPolskiR = 3,
		BiologiaP = 4,
		BiologiaR = 5,
		ChemiaP = 6,
		ChemiaR = 7,
		HistoriaP = 8,
		HistoriaR = 9,
		WiedzaOSpoleczenstwieP = 10,
		WiedzaOSpoleczenstwieR = 11,
		FizykaP = 12,
		FizykaR = 13,
		InformatykaP = 14,
		InformatykaR = 15,
		GeografiaP = 16,
		GeografiaR = 17,
		JezykObcyP = 18,
		JezykObcyR = 19
	}

}
