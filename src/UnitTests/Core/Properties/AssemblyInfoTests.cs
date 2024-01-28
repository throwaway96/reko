#region License
/* 
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2, or (at your option)
 * any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; see the file COPYING.  If not, write to
 * the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
 */
#endregion

using NUnit.Framework;

namespace Reko.UnitTests.Core
{
	[TestFixture]
	public class AssemblyInfoTests
	{
		[Test]
        [Category(Categories.UnitTests)]
		public void VersionStringToInt_a()
		{
            var ret = AssemblyMetadata.VersionStringToInt("1.2.3.4");
            Assert.AreEqual(ret, 0x01020304);
		}

		[Test]
        [Category(Categories.UnitTests)]
		public void VersionStringToInt_overflow()
		{
            var ret = AssemblyMetadata.VersionStringToInt("256.333.65555.259");
            Assert.AreEqual(ret, 0x004d1303);
		}
	}
}
