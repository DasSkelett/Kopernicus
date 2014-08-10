/**
 * Kopernicus Planetary System Modifier
 * Copyright (C) 2014 Bryce C Schroeder (bryce.schroeder@gmail.com), Nathaniel R. Lewis (linux.robotdude@gmail.com)
 * 
 * http://www.ferazelhosting.net/~bryce/contact.html
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301  USA
 * 
 * This library is intended to be used as a plugin for Kerbal Space Program
 * which is copyright 2011-2014 Squad. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 * 
 * https://kerbalspaceprogram.com
 */

using System;

namespace Kopernicus
{
	namespace Configuration
	{
		/**
		 * Attribute used to tag a property or field which can be targeted by the parser
		 **/
		[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
		public class ParserTarget : Attribute
		{
			// Storage key in config node tree.  If null, key is determined with reflection
			public string fieldName = null;
			
			// Flag indiciating whether the presence of this value is required
			public bool optional = false;
			
			// Flag indiciating whether the contents of the config tree can be merged
			// via reflection with a potentially present field.  If the field is null,
			// this flag is disregarged
			public bool allowMerge = false;
			
			// Constructor sets name
			public ParserTarget(string fieldName = null)
			{
				this.fieldName = fieldName;
			}
		}
	}
}

