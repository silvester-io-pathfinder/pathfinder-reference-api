using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmergencyTarge : Template
    {
        public static readonly Guid ID = Guid.Parse("75a4f4c9-9ed2-4324-b2af-58582c90c71e");

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
            yield return new TextBlock { Id = Guid.Parse("25c6a494-ce00-40b5-949d-294023eb03b5"), Type = TextBlockType.Text, Text = "You immediately (action: Raise a Shield) or cast (spell: shield). The circumstance bonus applies to your defenses when determining the outcome of the triggering attack or spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHybridStudy(Guid.Parse("dbf10831-8dcc-4d75-b4f0-067cc0346055"), HybridStudies.Instances.SparklingTarge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("463763a2-bc5c-4383-a964-6d0249258923"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
