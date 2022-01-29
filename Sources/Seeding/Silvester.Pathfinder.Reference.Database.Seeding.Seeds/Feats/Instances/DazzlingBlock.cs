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
    public class DazzlingBlock : Template
    {
        public static readonly Guid ID = Guid.Parse("4314267f-e05c-422e-91a4-14164bb8ed29");

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
            yield return new TextBlock { Id = Guid.Parse("8b590b2d-5493-40a4-9c40-39f2cc832c16"), Type = TextBlockType.Text, Text = $"When you use {ToMarkdownLink<Models.Entities.Feat>("Shield Block", Feats.Instances.ShieldBlock.ID)}, you can create a flash of brilliant, multicolored light in a 15-foot cone. Each creature in the area must attempt a Fortitude save, with the following effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("16f399da-936f-48a8-968f-9e71b96a06bd"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("05282d60-41c0-47bc-a612-fa52c6bc9306"), HybridStudies.Instances.SparklingTarge.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7ea83301-061c-4da8-8377-0106d8b45d8d"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("f72f6df0-1215-4732-8f74-db8f3bc3a92e"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("87073533-1221-41f8-91bd-0d6680e0afa1"), Traits.Instances.Magus.ID);
            builder.Add(Guid.Parse("1c3551ee-dc35-4272-b13e-ac52d53b8c2f"), Traits.Instances.Visual.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("8f2ceec5-0072-4a61-b05c-b1ed8fa16b7f"),
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
                Id = Guid.Parse("cc2b18a8-5c98-4cc4-bbfd-326e5398ecb0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
