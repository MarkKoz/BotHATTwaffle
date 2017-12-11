﻿using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BotHATTwaffle.Modules
{
    public class ToolsService
    {

        public ToolsService()
        {

        }
    }

    public class ToolsModule : ModuleBase<SocketCommandContext>
    {

        public ToolsModule()
        {

        }
        #region vtfedit
        [Command("VTFedit")]
        [Summary("`>VTFedit` Gives you a link to VTFEdit download")]
        [Alias("vtf")]
        public async Task VTFeditAsync()
        {
            var authBuilder = new EmbedAuthorBuilder()
            {
                Name = "Download VTFEdit",
                IconUrl = "https://cdn.discordapp.com/icons/111951182947258368/0e82dec99052c22abfbe989ece074cf5.png",
            };

            var builder = new EmbedBuilder()
            {
                Author = authBuilder,
                Url = "https://www.tophattwaffle.com/downloads/vtfedit/",
                ThumbnailUrl = "https://content.tophattwaffle.com/BotHATTwaffle/vtfedit.png",
                Color = new Color(255, 206, 199),
                Description = "VTFEdit is a lightweight program that can be used to convert images into the Valve VTF image format." +
                " It is much easier to use than VTEX.exe and provides a nice GUI for everythign you'd ever need to get your images into the Source Engine"

            };
            await ReplyAsync("", false, builder.Build());
        }
        #endregion
        #region GCFScape
        [Command("GCFscape")]
        [Summary("`>GCFScape` Gives you a link to GCFScape download")]
        [Alias("gcf")]
        public async Task GCFScapeAsync()
        {
            var authBuilder = new EmbedAuthorBuilder()
            {
                Name = "Download GCFScape",
                IconUrl = "https://cdn.discordapp.com/icons/111951182947258368/0e82dec99052c22abfbe989ece074cf5.png",
            };

            var builder = new EmbedBuilder()
            {
                Author = authBuilder,
                Url = "https://www.tophattwaffle.com/downloads/gcfscape/",
                ThumbnailUrl = "https://content.tophattwaffle.com/BotHATTwaffle/gcfscape.png",
                Color = new Color(63,56,156),
                Description = "GCFScape is a utility that will let you explore, extract, and manage content in various packages used by Valve / Steam games." +
                " Such as VPK, GCF, PAK, BSP, and more."

            };
            await ReplyAsync("", false, builder.Build());
        }
        #endregion
        #region VMTEditor
        [Command("VMTEditor")]
        [Summary("`>VMTeditor` Gives you a link to VMT Editor download")]
        [Alias("vmt")]
        public async Task VMTEditorAsync()
        {
            var authBuilder = new EmbedAuthorBuilder()
            {
                Name = "Download VMT Editor",
                IconUrl = "https://cdn.discordapp.com/icons/111951182947258368/0e82dec99052c22abfbe989ece074cf5.png",
            };

            var builder = new EmbedBuilder()
            {
                Author = authBuilder,
                Url = "https://gira-x.github.io/VMT-Editor/",
                ThumbnailUrl = "https://content.tophattwaffle.com/BotHATTwaffle/vmteditor.png",
                Color = new Color(50,50,50),
                Description = "VMT Editor is, hands down, one of the best VMT creation tools that exists for Source engine. " +
                "It quickly became a standard tool for most designers that regularly create VMT files. " +
                "Created by Yanzl over at MapCore."

            };
            await ReplyAsync("", false, builder.Build());
        }
        #endregion
        #region VIDE
        [Command("VIDE")]
        [Summary("`>VIDE` Gives you a link to VIDE download")]
        public async Task VIDEAsync()
        {
            var authBuilder = new EmbedAuthorBuilder()
            {
                Name = "Download VIDE",
                IconUrl = "https://cdn.discordapp.com/icons/111951182947258368/0e82dec99052c22abfbe989ece074cf5.png",
            };

            var builder = new EmbedBuilder()
            {
                Author = authBuilder,
                Url = "https://www.tophattwaffle.com/downloads/vide/",
                ThumbnailUrl = "https://content.tophattwaffle.com/BotHATTwaffle/vide.png",
                Color = new Color(50, 50, 50),
                Description = "VIDE is a 3rd party tool that has many tools rolled into one awesome package. " +
                "Most people use it for packing assets into a level, but it can do so much more than that."

            };
            await ReplyAsync("", false, builder.Build());
        }
        #endregion
    }
}
