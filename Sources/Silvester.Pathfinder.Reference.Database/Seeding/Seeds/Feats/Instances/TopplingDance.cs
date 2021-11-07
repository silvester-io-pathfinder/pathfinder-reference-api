using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TopplingDance : Template
    {
        public static readonly Guid ID = Guid.Parse("3c965c08-7c58-409e-832d-3239cb3c2be5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Toppling Dance",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("65c106a2-17b8-4eac-a7f3-f0a9e3e834e6"), Type = TextBlockType.Text, Text = "While sharing a creature’s space using (feat: Dance Underfoot), your weapons and unarmed attacks gain the (trait: trip) trait, but only against the creature whose space you share. You can be in the same space as a Large or larger prone creature, even if it’s not your ally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e75b72d8-a12c-424d-b808-8363a275e824"), Feats.Instances.DanceUnderfoot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d723075-cb74-4b20-b863-f540b59b7d89"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
