using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DazzlingBlock : Template
    {
        public static readonly Guid ID = Guid.Parse("98cec0e1-04be-4fd4-b943-36d45ab1c3a1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dazzling Block",
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
            yield return new TextBlock { Id = Guid.Parse("9adfd5ff-f0d4-40f8-9638-9c4fdce3351c"), Type = TextBlockType.Text, Text = "When you use (feat: Shield Block), you can create a flash of brilliant, multicolored light in a 15-foot cone. Each creature in the area must attempt a Fortitude save, with the following effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("51002d4e-2233-4203-a87c-93bbea1c6812"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("b119833c-ec0e-461a-a6b5-f780065b331a"), HybridStudies.Instances.SparklingTarge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("bd9f2364-7d4d-4b6f-be4c-4a510206fd11"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is dazzled for 1 round.",
                Failure = "The creature is blinded for 1 round and dazzled for 1 minute. The creature can spend an (action: Interact) action rubbing its eyes to end this blinded condition.",
                CriticalFailure = "The creature is blinded for 1 round and dazzled for 1 hour.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a10e88d1-53b7-425b-bbfc-b3c69fd57e75"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
