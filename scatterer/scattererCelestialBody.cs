using System;
using UnityEngine;

namespace scatterer
{
	public class scattererCelestialBody
	{
		[Persistent] public string celestialBodyName;
		[Persistent] public string transformName;
		[Persistent] public float loadDistance;
		[Persistent] public float unloadDistance;
		[Persistent] public bool hasOcean;

		public CelestialBody celestialBody;
		public Transform transform;
		public bool hasTransform = false;
		public bool active;
		public Manager m_manager;
		public Material originalPlanetMaterialBackup;
		
		
		public scattererCelestialBody (string inCelestialBodyName, string inTransformName, float inloadDistance,
		                               float inUnloadDistance, bool inHasOcean)
		{
			celestialBodyName = inCelestialBodyName;
			transformName=inTransformName;
			loadDistance = inloadDistance;
			unloadDistance=inUnloadDistance;
			hasOcean = inHasOcean;
		}

		public scattererCelestialBody (CelestialBody inCelestialBody, Transform inTransform)
		{
			transform = inTransform;
			celestialBody = inCelestialBody;
		}
		
		public scattererCelestialBody ()
		{
			
		}
	}
}

