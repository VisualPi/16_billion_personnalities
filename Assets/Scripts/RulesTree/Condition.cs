using System.Collections;
using System.Collections.Generic;
using System;

public class Dummy
{ }

public class Condition<T> {

	public Func<T, bool> _func;

	public Condition(Func<T, bool> func)
	{
		_func = func;
	}

	public bool Test(T d)
	{
		return _func(d);
	}
}
