﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using VSTE = Microsoft.VisualStudio.Text.Editor;
using VSTF = Microsoft.VisualStudio.Text.Formatting;

namespace dnSpy.Contracts.Hex.Formatting {
	/// <summary>
	/// Line transform source
	/// </summary>
	public abstract class HexLineTransformSource {
		/// <summary>
		/// Constructor
		/// </summary>
		protected HexLineTransformSource() { }

		/// <summary>
		/// Calculates the line transform for a given line of formatted text
		/// </summary>
		/// <param name="line">Line</param>
		/// <param name="yPosition">Y position</param>
		/// <param name="placement">Placement</param>
		/// <returns></returns>
		public abstract VSTF.LineTransform GetLineTransform(HexViewLine line, double yPosition, VSTE.ViewRelativePosition placement);
	}
}
