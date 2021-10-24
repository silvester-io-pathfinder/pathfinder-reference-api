using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InstinctAbilities.Instances
{
    public class BestialRage : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override InstinctAbility GetInstinctAbility()
        {
            return new InstinctAbility
            {
                Id = ID, 
                Name = "Bestial Rage",
                Description = "When you Rage, you gain your chosen animal's unarmed attack (or attacks). The specific attack gained, the damage it deals, and its traits are listed in the table Animal Instincts. These attacks are in the brawling group. Your Rage action gains the morph, primal, and transmutation traits.",
            };
        }

        protected override Table? GetTable()
        {
            return new TableBuilder()
                .AddColumn("", "Animal")
                .AddColumn("", "Attack")
                .AddColumn("", "Damage")
                .AddColumn("", "Traits")
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Ape")
                        .AddCell("", "Fist")
                        .AddCell("", "1d10 B")
                        .AddCell("", "Grapple, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Bear")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Bear")
                        .AddCell("", "Claw")
                        .AddCell("", "1d6 S")
                        .AddCell("", "Agile, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Bull")
                        .AddCell("", "Horn")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Shove, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Cat")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Cat")
                        .AddCell("", "Claw")
                        .AddCell("", "1d6 S")
                        .AddCell("", "Agile, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Deer")
                        .AddCell("", "Antler")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Grapple, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Frog")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 B")
                        .AddCell("", "Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Frog")
                        .AddCell("", "Tongue")
                        .AddCell("", "1d10 B")
                        .AddCell("", "Agile, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Shark")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Grapple, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Snake")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Grapple, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Wolf")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Trip, Unarmed");
                })
                .Build("");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
