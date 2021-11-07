using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealersHalo : Template
    {
        public static readonly Guid ID = Guid.Parse("288eaa11-1133-4ec9-a61f-51821894dfc0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Healer's Halo",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You or allies within 30 feet recover Hit Points while your halo is active.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da587b3a-5929-49d4-b536-ad42430bd537"), Type = TextBlockType.Text, Text = "Your halo can enhance positive energy. Creatures who have recovered Hit Points from a (trait: positive) (trait: healing) effect recover an additional 1d6 Hit Points. Creatures who benefit from this power become temporarily immune to its effect for the next 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d9a5f5d1-e1dd-49e2-b1b0-d1cb72afd39c"), Feats.Instances.Halo.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e9483c3-babe-42c1-a47a-5d27120e348d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
