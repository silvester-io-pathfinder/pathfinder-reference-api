using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurpriseSnare : Template
    {
        public static readonly Guid ID = Guid.Parse("307a1a14-f29d-4b0b-a5bf-23fae1117c8e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surprise Snare",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8d445c8-ee45-4a8d-81a7-740139f7642c"), Type = TextBlockType.Text, Text = "You install one of your snares prepared for quick deployment in a space that’s occupied by an opponent. It must be a snare that normally takes 1 minute or less to (action: Craft). The snare automatically triggers, but it takes a -2 circumstance penalty to any applicable save DC, as well as any attack rolls or other checks the snare attempts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cd38b278-9eca-4df5-9d25-b3ff9061e312"), Feats.Instances.SnarecrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3950ed23-180d-4ffa-b6ec-d22456487968"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
