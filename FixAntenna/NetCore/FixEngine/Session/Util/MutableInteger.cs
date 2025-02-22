﻿// Copyright (c) 2021 EPAM Systems
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace Epam.FixAntenna.NetCore.FixEngine.Session.Util
{
	internal class MutableInteger
	{
		private int _number = 0;

		public virtual void SetNumber(int number)
		{
			this._number = number;
		}

		public virtual int GetNumber()
		{
			return _number;
		}

		public override bool Equals(object o)
		{
			if (this == o)
			{
				return true;
			}
			if (o == null || this.GetType() != o.GetType())
			{
				return false;
			}

			var that = (MutableInteger) o;

			if (_number != that._number)
			{
				return false;
			}

			return true;
		}

		public override int GetHashCode()
		{
			return _number;
		}

		public override string ToString()
		{
			return Convert.ToString(_number);
		}
	}

}