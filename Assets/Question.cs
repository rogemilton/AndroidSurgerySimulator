//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//class used to create object with list of points and text related to those points

public class Question
{
	public List<Vector3> points;
	public String text;

	public Question ()
	{
		points = new List<Vector3>();
		text = "Empty";
	}

	public Question(List<Vector3> newpoints, string displayText)
	{
		points = newpoints;
		text = displayText;
	}

}


