using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EldritchNails : Template
    {
        public static readonly Guid ID = Guid.Parse("e43eb2bf-1e51-4d10-a46d-55b17a659d37");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eldritch Nails",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bf8b1821-2156-492b-bc16-809ef849b088"), Type = TextBlockType.Text, Text = $"Your nails are supernaturally long and sharp. You gain a nails unarmed attack that deals 1d6 slashing damage. Your nails are in the brawling group and have the {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} and {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} traits. You can etch your nails with runes with the same cost and restrictions as for etching runes onto {ToMarkdownLink<Models.Items.Instances.WornItem>("handwraps of mighty blows", Items.WornItems.Instances.HandwrapsOfMightyBlows.ID)}; runes etched onto your nails apply to nails unarmed attacks with both hands but not to other unarmed attacks." };
            yield return new TextBlock { Id = Guid.Parse("1a2022c5-5c1a-4a7b-8e0d-6f7b7c2581a4"), Type = TextBlockType.Text, Text = $"You can deliver hexes through your nails. When you successfully cast a non-cantrip hex that requires 2 actions or more to cast and that doesn't require a spell attack roll, if your target is within your reach, as part of the spellcasting activity you can make a nails {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the foe before applying any effects of the hex. If this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} misses, the hex has no effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a85e29f4-509b-4258-b0fe-5effee8331a2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
