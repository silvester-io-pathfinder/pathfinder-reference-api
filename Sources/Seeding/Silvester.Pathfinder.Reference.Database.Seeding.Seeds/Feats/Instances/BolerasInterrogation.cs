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
    public class BolerasInterrogation : Template
    {
        public static readonly Guid ID = Guid.Parse("45b27d2c-7ccb-482b-aa69-af75893aa0b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bolera's Interrogation",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "three times per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("168f2094-264c-40ff-a2ff-4e2997c367b7"), Type = TextBlockType.Text, Text = $"You focus your attention on a single creature within 30 feet. That creature must attempt a Will save against your Perception DC. On a failure, the creature finds itself unable to speak any deliberate and intentional lies and takes a -2 penalty to Deception checks. On a critical failure, the penalty to Deception checks is -4. This effect lasts for 10 minutes as long as you are within 30 feet of the target and the target is aware that you are using the ability against it. If you begin a new interrogation, this effect ends for any previous target. After your interrogation ends, the target is immune to this ability for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("63c5d238-6884-4bf3-9834-0ae5857c14e8"), Feats.Instances.EdgewatchDetectiveDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ff71969-9d08-48b2-b4c1-04f035706726"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
