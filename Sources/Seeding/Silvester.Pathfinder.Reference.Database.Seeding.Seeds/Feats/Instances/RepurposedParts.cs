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
    public class RepurposedParts : Template
    {
        public static readonly Guid ID = Guid.Parse("98e8eac0-0e41-47b0-815c-5a8aa63efbd0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Repurposed Parts",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ddfa0095-dbc8-47d1-a729-a344f8f44031"), Type = TextBlockType.Text, Text = $"You are familiar with the fittings and cogwheels of your snares and can repurpose parts from prepared quick-deploy snares to assemble a new creation on the fly. Using two of the snares you prepared for quick deployment during daily preparations, you can quickly deploy a different snare that you know how to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)}, even if you didn't prepare that snare during your daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9021c30a-e85f-4d2c-b44c-dffcf738344b"), Feats.Instances.TrapsmithDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("b1618649-c9f5-4e89-9933-29bfc6b6c310"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20df463f-3a5c-4f53-968f-3a00097da113"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
