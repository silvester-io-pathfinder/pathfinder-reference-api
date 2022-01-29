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
    public class GreaterSpiritualEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("62280951-6a37-406b-ad2d-d9e975d44a51");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Spiritual Evolution",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba4b87f3-22d3-47da-940a-f0173acec9d4"), Type = TextBlockType.Text, Text = $"Your magical blood is rich with spiritual essence, and this infusion within you allows your spells to be fully effective against incorporeal creatures, spirits, and creatures on the Ethereal Plane. Your spells have the effects of a ghost touch property rune. They can target or affect a creature projecting its consciousness (such as via {ToMarkdownLink<Models.Entities.Spell>("project image", Spells.Instances.ProjectImage.ID)}) or possessing another creature, even if its body is elsewhere, though you must know about the possession or projection and choose to do so. Your spells can affect creatures on the Ethereal Plane, though this doesn't grant you any particular ability to locate them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d3e71146-8ba0-4de0-aac2-5d60570df207"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("d21974e2-91d0-4101-ab5f-dc7d0c234e09"), Feats.Instances.DivineEvolution.ID);
                or.HaveSpecificFeat(Guid.Parse("feb0827b-e53e-43cb-8c10-0c857b03310a"), Feats.Instances.OccultEvolution.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("abaf6781-b1d0-458a-abd3-50ac47288fef"), Traits.Instances.Sorcerer.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76ceab84-bfdd-400e-b1ab-7acd4f9c6ac5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
