// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System.ComponentModel;

namespace OpenLiveWriter.ApplicationFramework.Commands
{
	/// <summary>
	/// Summary description for CommandCopy.
	/// </summary>
	public class CommandCut : Command
	{

		public CommandCut(IContainer container)
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();

			//
			// 
			//
		}

		public CommandCut()
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
			// CommandCut
			// 
			this.ContextMenuPath = "Cu&t@101";
			this.Identifier = "MindShare.ApplicationCore.Commands.Cut";
			this.MainMenuPath = "&Edit@2/Cu&t@101";
			this.MenuText = "Cu&t";
			this.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.Text = "Cut";

		}
		#endregion
	}
}
