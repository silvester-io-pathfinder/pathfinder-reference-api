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
    public class DragonsRageWings : Template
    {
        public static readonly Guid ID = Guid.Parse("b04ebc3d-db19-42d8-b516-a34cbdc66d02");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon's Rage Wings",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0b5ed52-28ee-426e-a4bb-8b2e8907a3c7"), Type = TextBlockType.Text, Text = $"You sprout dragon wings from your back of the same color as your chosen dragon. While you are raging, you gain a fly Speed equal to your land Speed. If you are flying when your rage ends, you start to fall but the transformation only completes at the last moment, so you take no damage from the fall and land standing up." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("f2815e94-f638-4ac3-8e8f-9897e06b473c"), Instincts.Instances.DragonInstinct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("93be03ee-c50f-4512-aad3-cf73b0e7efaf"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("9d47a012-ef1e-4587-ac5b-c618bf5e83a9"), Traits.Instances.Instinct.ID);
            builder.Add(Guid.Parse("b008cfb2-c9f1-4db0-95e2-a4e089aeab5d"), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse("15476cfa-a962-4ed8-8d0b-9c24cd594f8b"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("0a8f913f-33e2-4b69-8058-4f26a8cb922e"), Traits.Instances.Rage.ID);
            builder.Add(Guid.Parse("2be0633d-3ae8-4551-92ec-cafd52578d9d"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bcec757-9921-48bc-9e6f-81720da851f1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
