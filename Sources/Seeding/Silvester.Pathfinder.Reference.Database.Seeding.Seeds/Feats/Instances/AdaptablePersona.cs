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
    public class AdaptablePersona : Template
    {
        public static readonly Guid ID = Guid.Parse("192a2c29-2220-45bc-8ea3-bd607479452a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adaptable Persona",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("18774453-47d1-48a3-b0b6-43d4ad288600"), Type = TextBlockType.Text, Text = $"When you manifest the essence form, gain your choice of a climb Speed or swim Speed equal to your land Speed. If you're 8th level or higher, you can choose a fly Speed instead." };
            yield return new TextBlock { Id = Guid.Parse("7ad96c44-758b-42a3-a80c-a7a5d0a90b94"), Type = TextBlockType.Text, Text = $"__Corruption Flaw__ You take a –10-foot penalty to all your Speeds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b32c496f-f75e-4f97-8a33-7bdffb734c62"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
