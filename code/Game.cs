namespace Sandbox;

public class MyGame : GameManager
{
#if DEBUG
	[Event.Tick]
	private void Test()
	{
		Log.Info( "Hello from debug!" );
	}
#endif
}
