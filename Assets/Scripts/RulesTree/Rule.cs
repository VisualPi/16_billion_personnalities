using System.Collections;
using System.Collections.Generic;

public class Rule {

	public Condition Condition;
	public Action Action;
	public Rule(Condition condition, Action action)
	{
		Condition = condition;
		Action = action;
	}
}
