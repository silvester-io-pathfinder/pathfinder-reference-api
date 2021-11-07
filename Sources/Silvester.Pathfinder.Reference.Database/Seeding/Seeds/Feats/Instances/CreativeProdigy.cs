using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CreativeProdigy : Template
    {
        public static readonly Guid ID = Guid.Parse("8cb190be-191a-47d6-a13e-49cfbe2b9323");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Creative Prodigy",
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
            yield return new TextBlock { Id = Guid.Parse("d017c7c6-d874-44fb-a1f6-ab8945b5c150"), Type = TextBlockType.Text, Text = "You have a powerful creative drive, useful for prevarication and performance. You gain the trained proficiency rank in Deception and Performance. If you are already trained in either of these skills, you become trained in a skill of your choice in its place. You also become trained in Art Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5c92b28-98dc-4d8f-900a-f98bb752562e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
