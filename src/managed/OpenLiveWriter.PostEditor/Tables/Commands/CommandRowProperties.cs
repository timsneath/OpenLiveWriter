// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System.ComponentModel;
using OpenLiveWriter.ApplicationFramework ;

namespace OpenLiveWriter.PostEditor.Tables.Commands
{
	/// <summary>
	/// Summary description for CommandCopy.
	/// </summary>
	public class CommandRowProperties : Command
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public CommandRowProperties(IContainer container)
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();

			//
			// 
			//
		}

		public CommandRowProperties()
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();

			//
			// 
			//
		}



		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// CommandFont
			// 
			this.Identifier = "OpenLiveWriter.PostEditor.Tables.Commands.RowProperties";
			this.MainMenuPath = "T&able@6/&Row Properties...@120";
			this.MenuText = "&Row Properties...";
			this.Text = "Row Properties";
		}
		#endregion
	}
}
