﻿using System;

namespace DSharpPlus.SlashCommands
{
	/// <summary>
	///     Marks this method as a context menu.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ContextMenuAttribute : Attribute
	{
		/// <summary>
		///     Gets the name of this context menu.
		/// </summary>
		public string Name { get; internal set; }

		/// <summary>
		///     Gets the type of this context menu.
		/// </summary>
		public ApplicationCommandType Type { get; internal set; }

		/// <summary>
		///     Gets whether this command is enabled by default.
		/// </summary>
		public bool DefaultPermission { get; internal set; }

		/// <summary>
		///     Gets whether this command should be localized using an ILocalizationProvider.
		/// </summary>
		public bool ApplyLocalization { get; internal set; }

		/// <summary>
		///     Marks this method as a context menu.
		/// </summary>
		/// <param name="type">The type of the context menu.</param>
		/// <param name="name">The name of the context menu.</param>
		/// <param name="defaultPermission">Sets whether the command should be enabled by default.</param>
		/// <param name="applyLocalization">Sets whether the command should be localized using an ILocalizationProvider.</param>
		public ContextMenuAttribute(ApplicationCommandType type, string name, bool defaultPermission = true, bool applyLocalization = false)
		{
			if (type == ApplicationCommandType.SlashCommand)
				throw new ArgumentException("Context menus cannot be of type SlashCommand.");

			Type = type;
			Name = name;
			DefaultPermission = defaultPermission;
			ApplyLocalization = applyLocalization;
		}
	}
}