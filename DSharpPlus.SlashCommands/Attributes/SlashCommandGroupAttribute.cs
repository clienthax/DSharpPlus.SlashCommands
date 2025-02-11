﻿using System;

namespace DSharpPlus.SlashCommands
{
	/// <summary>
	///     Marks this class a slash command group.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SlashCommandGroupAttribute : Attribute
	{
		/// <summary>
		///     Gets the name of this slash command group.
		/// </summary>
		public string Name { get; }

		/// <summary>
		///     Gets the description of this slash command group.
		/// </summary>
		public string Description { get; }

		/// <summary>
		///     Gets whether this command is enabled on default.
		/// </summary>
		public bool DefaultPermission { get; }

		/// <summary>
		///     Gets whether this command should be localized using an ILocalizationProvider.
		/// </summary>
		public bool ApplyLocalization { get; }

		/// <summary>
		///     Marks this class as a slash command group.
		/// </summary>
		/// <param name="name">Sets the name of this command group.</param>
		/// <param name="description">Sets the description of this command group.</param>
		/// <param name="defaultPermission">Sets whether this command group is enabled on default.</param>
		/// <param name="applyLocalization">Sets whether the command should be localized using an ILocalizationProvider.</param>
		public SlashCommandGroupAttribute(string name, string description, bool defaultPermission = true, bool applyLocalization = false)
		{
			Name = name.ToLower();
			Description = description;
			DefaultPermission = defaultPermission;
			ApplyLocalization = applyLocalization;
		}
	}
}