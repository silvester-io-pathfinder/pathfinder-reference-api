using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmergencyTarge : Template
    {
        public static readonly Guid ID = Guid.Parse("2d55f883-1337-4875-99d0-c7382a263c09");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emergency Targe",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy hits you with a melee Strike or a melee spell attack roll, or you fail a save against an enemy's spell.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("734ee8e2-43f2-40b3-94c6-ed23cc906064"), Type = TextBlockType.Text, Text = "You immediately (action: Raise a Shield) or cast (spell: shield). The circumstance bonus applies to your defenses when determining the outcome of the triggering attack or spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHybridStudy(Guid.Parse("150d1882-bb15-4109-97c4-8591306ebc3d"), HybridStudies.Instances.SparklingTarge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb1b8be5-ee7c-4894-b2c9-ba2fb78b7951"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
