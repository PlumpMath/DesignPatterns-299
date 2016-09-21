using System;

namespace Prototype
{
	public class Robot : ICloneable
	{
		public Body body;
		public Engine engine;
		public Helmet helmet;

		public Object Clone()
		{
			Robot clone = new Robot(body.Clone() as Body, engine.Clone() as Engine, helmet.Clone() as Helmet);
			return clone;
		}

		public Robot(Body body, Engine engine, Helmet helmet)
		{
			this.body = body;
			this.engine = engine;
			this.helmet = helmet;
		}

		public override string ToString()
		{
			String output =
				"Robot info: body wearability: {0}; engine wearability: {1}; helmet wearability: {2}; helmet visibility: {3} ";
			return String.Format(output, body.Wearability, engine.Wearability, helmet.Wearability, helmet.Visibility);
		}
	}
}