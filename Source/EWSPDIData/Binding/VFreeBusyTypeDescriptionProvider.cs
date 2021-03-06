//===============================================================================================================
// System  : Personal Data Interchange Classes
// File    : VFreeBusyTypeDescriptionProvider.cs
// Author  : Eric Woodruff  (Eric@EWoodruff.us)
// Updated : 11/06/2014
// Note    : Copyright 2007-2014, Eric Woodruff, All rights reserved
// Compiler: Microsoft Visual C#
//
// This file contains a custom type description provider that associates the ChildPropertyTypeDescriptor with
// the VFreeBusy class.
//
// This code is published under the Microsoft Public License (Ms-PL).  A copy of the license should be
// distributed with the code and can be found at the project website: https://github.com/EWSoftware/PDI.
// This notice, the author's name, and all copyright notices must remain intact in all applications,
// documentation, and source files.
//
//    Date     Who  Comments
// ==============================================================================================================
// 04/09/2007  EFW  Created the code
//===============================================================================================================

using EWSoftware.PDI.Objects;

namespace EWSoftware.PDI.Binding
{
    /// <summary>
    /// This is a custom type description provider that associates the <see cref="ChildPropertyTypeDescriptor" />
    /// with the <see cref="VFreeBusy" /> class.
    /// </summary>
    public class VFreeBusyTypeDescriptionProvider : ChildPropertyTypeDescriptionProvider
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public VFreeBusyTypeDescriptionProvider() : base(typeof(VFreeBusy))
        {
        }
    }
}
