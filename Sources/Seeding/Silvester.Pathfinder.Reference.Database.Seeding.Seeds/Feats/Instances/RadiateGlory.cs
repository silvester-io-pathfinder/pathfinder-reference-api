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
    public class RadiateGlory : Template
    {
        public static readonly Guid ID = Guid.Parse("5e59924a-4a98-44cf-8b8d-70c36b071490");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Radiate Glory",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9843385e-e003-41c5-a45a-f3b196c693b3"), Type = TextBlockType.Text, Text = $"Your inherent glory radiates into the world with all the divine power of the celestial planes for 1 minute. Any creature that can see you while you Radiate Glory must attempt a Will saving throw against your class DC or spell DC, whichever is higher. The creature then becomes temporarily immune to this effect for 24 hours." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("dc0963e7-d03b-4ab2-8db7-adade37956ea"), Traits.Instances.Aasimar.ID);
            builder.Add(Guid.Parse("e1be783d-e892-497b-b803-8f96293c9e55"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("8ae9fb32-db1c-4a53-98af-2eded8b14238"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("2acc4ee2-8654-4aca-a534-2c01b37af9fa"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("ee3171cc-d881-40bc-a159-664fb938e78e"), Traits.Instances.Visual.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("f0ceabbf-2da1-4dff-a49e-d432b66d5be1"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "You are concealed to the creature for 1 round by the shining light, but can't use this concealment to (action: Hide), as normal for when your location is obvious.",
                Failure = "As success, except you are concealed to the creature while your glory radiates.",
                CriticalFailure = "You are hidden to the creature while your glory radiates, lost amid the radiant corona of your presence. Your general position is still obvious, so you can't use this to (action: Sneak).", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89d7bbb9-f80a-46cc-a9d5-8db1f455ca99"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
