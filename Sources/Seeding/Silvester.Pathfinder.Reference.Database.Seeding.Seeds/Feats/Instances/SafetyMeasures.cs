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
    public class SafetyMeasures : Template
    {
        public static readonly Guid ID = Guid.Parse("5fd95aeb-4af5-4c7f-80eb-33330562fa54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Safety Measures",
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
            yield return new TextBlock { Id = Guid.Parse("16c025e1-fe1c-4433-b626-a629d68b57b2"), Type = TextBlockType.Text, Text = $"You're often careful to be sure you're not hoisted on your own petard, or anyone else's, for that matter. When you have cover from a bomb, you gain resistance to damage caused by that bomb equal to half your level, plus a value equal to the circumstance bonus to AC granted by the cover. You gain these benefits against your own bombs regardless of whether you have cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fa8e81db-81a9-453e-9532-ae5525f593f1"), Feats.Instances.DemolitionistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cfa5e31-48df-446a-81aa-bc29f367dc3d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
