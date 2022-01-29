using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrcWarmask : Template
    {
        public static readonly Guid ID = Guid.Parse("8cce0c3b-c429-4fa9-a8f8-ec8737d2cb9d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Orc Warmask",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d308736b-070f-4cf5-aada-f3f60f186d2d"), Type = TextBlockType.Text, Text = $"You paint your face to create a warmask, an invested magic item of negligible Bulk with an item level equal to your level and a usage of worn (mask). It has the {ToMarkdownLink<Models.Entities.Trait>("divination", Traits.Instances.Divination.ID)} trait and a magical tradition trait depending on its type. Donning or removing your warmask requires 1 minute of work, though you don't need to Invest the mask each time. The warmask is unique to you and might signify your hold, your accomplishments, or your faith. While creating your mask, you must choose the source of your warmask's power from the options below. This source determines the mask's associated skill as well as magical tradition. Once you select this source, it can't be changed. You become trained in the associated skill, and you gain the {ToMarkdownLink<Models.Entities.Feat>("Dubious Knowledge", Feats.Instances.DubiousKnowledge.ID)} skill feat as a bonus feat. You can spend 1 hour performing a ceremony that costs 50 gp to attune yourself more deeply with your warmask. If you do, you gain a +1 item bonus to the associated skill whenever you wear the warmask." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Orc.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55b6be58-85c5-4acd-ba14-0ee70dae9818"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
