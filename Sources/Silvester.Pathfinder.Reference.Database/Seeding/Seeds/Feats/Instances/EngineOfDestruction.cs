using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EngineOfDestruction : Template
    {
        public static readonly Guid ID = Guid.Parse("e958bf04-43ca-4c2a-9d14-457a7ead15e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Engine of Destruction",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d69d325-2dae-4f74-9b10-dec5dab39900"), Type = TextBlockType.Text, Text = "Your construct unleashes a broad swath of devastation by separating its limbs, deploying hidden armaments, or using a similar technique to wreak havoc. You Command your innovation. Instead of its normal actions, it (action: Strides | Stride) once, then makes a (action: Strike) against each foe within 30 feet of it with a +2 circumstance bonus to its attack rolls. The multiple attack penalty doesn’t increase until after the construct makes all the attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("83b21a5c-3d87-4e5c-89bc-306dc75eae9d"), Innovations.Instances.Construct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02ee0666-3762-46ee-a764-5bb5323aa51c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
