using System.Collections;
using System.Collections.Generic;
using System;

public class Action {

	public Action<Dummy> _action;

	public Action(Action<Dummy> action)
	{
		_action = action;
	}

	public void Execute(Dummy d)
	{
		_action(d);
	}
}
