﻿// Copyright © 2015-2017 Daniel Porrey. All Rights Reserved.
//
// This file is part of the IoT Devices and Sensors project.
// 
// IoT Devices and Sensors is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// IoT Devices and Sensors is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with IoT Devices and Sensors. If not, 
// see http://www.gnu.org/licenses/.
//
namespace Porrey.Uwp.IoT.Devices.KeyPad
{
	public class Membrane1x4 : KeyPad
	{
		public Membrane1x4(params IGpioPinMapping[] mappings)
			: base(5, mappings)
		{
		}

		protected override ICharacterGridMapping[] OnGetCharacterMappings()
		{
			return new CharacterGridMapping[]
			{
				new CharacterGridMapping() { Row = 1, Column = 1, Value = '1' },
				new CharacterGridMapping() { Row = 1, Column = 2, Value = '2' },
				new CharacterGridMapping() { Row = 1, Column = 3, Value = '3' },
				new CharacterGridMapping() { Row = 1, Column = 4, Value = '4' },
			};
		}
	}
}
