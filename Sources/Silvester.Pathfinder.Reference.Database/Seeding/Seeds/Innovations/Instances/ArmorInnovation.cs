using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Innovations.Instances
{
    public class ArmorInnovation : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Innovation GetInnovation()
        {
            return new Innovation
            {
                Id = ID,
                Name = "Armor Innovation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your innovation is a cutting-edge suit of medium armor with a variety of attached gizmos and devices. Choose one of the sets of statistics on Table 2–2: Innovation Armor Statistics for your innovation armor (or choose another set of innovation armor statistics to which you have access)." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your innovation armor can have fundamental and property runes added to it in the same way as ordinary armor. Because of the unique features of your innovation, everyone except you is untrained in it, even if they would normally be trained (or better) in medium armor." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Choose one initial armor modification to apply to your innovation, either from the following or from other initial armor modifications to which you have access." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.GainSpecificArmor(Guid.Parse(""), Armors.Instances.PowerSuit.ID);
                or.GainSpecificArmor(Guid.Parse(""), Armors.Instances.SubterfugeSuit.ID);
            });

            builder.GainAnyInnovationModification(Guid.Parse(""), InnovationModificationTypes.Instances.Initial.ID);
        }

        protected override Table GetTable()
        {
            return new TableBuilder()
                .AddColumn("", "Medium Armor")
                .AddColumn("", "AC Bonus")
                .AddColumn("", "Dex Cap")
                .AddColumn("", "Check Penalty")
                .AddColumn("", "Speed Penalty")
                .AddColumn("", "Strength")
                .AddColumn("", "Bulk")
                .AddColumn("", "Group")
                .AddColumn("", "Armor Traits")
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Power Suit")
                        .AddCell("", "+4")
                        .AddCell("", "+1")
                        .AddCell("", "-2")
                        .AddCell("", "-5 feet")
                        .AddCell("", "16")
                        .AddCell("", "2")
                        .AddCell("", "composite")
                        .AddCell("", "-");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Subterfuge Suit")
                        .AddCell("", "+1")
                        .AddCell("", "+4")
                        .AddCell("", "-1")
                        .AddCell("", "-")
                        .AddCell("", "10")
                        .AddCell("", "1")
                        .AddCell("", "composite")
                        .AddCell("", "-");
                })
                .Build("");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 16
            };
        }
    }
}
