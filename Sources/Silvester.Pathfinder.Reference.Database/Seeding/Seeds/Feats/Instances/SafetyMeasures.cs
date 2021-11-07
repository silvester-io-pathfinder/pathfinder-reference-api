using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SafetyMeasures : Template
    {
        public static readonly Guid ID = Guid.Parse("15da6d58-26d8-4cfe-b4aa-48ec06e31d33");

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
            yield return new TextBlock { Id = Guid.Parse("69345f5c-6803-4a83-873a-750c80aa5236"), Type = TextBlockType.Text, Text = "You’re often careful to be sure you’re not hoisted on your own petard, or anyone else’s, for that matter. When you have cover from a bomb, you gain resistance to damage caused by that bomb equal to half your level, plus a value equal to the circumstance bonus to AC granted by the cover. You gain these benefits against your own bombs regardless of whether you have cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cca10cfb-c4e1-4adf-8da0-dc37252680d8"), Feats.Instances.DemolitionistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b4ac633-c812-4d3f-b63d-b124d7839182"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
