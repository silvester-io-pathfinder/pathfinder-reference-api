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
    public class GiantsStature : Template
    {
        public static readonly Guid ID = Guid.Parse("6fe29c74-d328-40ac-9c63-e732dce4332c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Giant's Stature",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7b21fd1a-03eb-4316-a779-3e47b9630433"), Type = TextBlockType.Text, Text = $"You grow to incredible size. You become Large, increasing your reach by 5 feet and gaining the clumsy 1 condition until you stop raging. Your equipment grows with you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("62312b27-a6ba-460d-97c3-16841dba060d"), Instincts.Instances.GiantInstinct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("340ea48e-4674-4a05-b150-b31ba6710792"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("cf8b3b33-a68c-4ec1-9996-992f60e32a52"), Traits.Instances.Instinct.ID);
            builder.Add(Guid.Parse("4c9038a6-754d-44de-9fef-c1f1538cda3a"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("fbdab85b-d037-46d0-82ec-977f110acdf2"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("8894ccdd-c954-4424-b8b3-d1c959520faa"), Traits.Instances.Rage.ID);
            builder.Add(Guid.Parse("fb175c7c-e8eb-4929-a010-84d4d6bacdec"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bee9e741-813f-47d2-bb6b-ab72253e5011"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
