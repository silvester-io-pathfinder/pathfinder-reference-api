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
    public class FighterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("0bc3b6f8-dce4-4f81-b022-e041d843b8c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fighter Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the fighter archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f31b0c04-4059-4877-be0d-59939400a90c"), Type = TextBlockType.Text, Text = $"You become trained in simple weapons and martial weapons. You become trained in your choice of Acrobatics or Athletics; if you are already trained in both of these skills, you instead become trained in a skill of your choice. You become trained in fighter class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("4a1b1918-14e0-42fa-bfc6-a28f2e49cd74"), requiredStatValue: 14, Stats.Instances.Strength.ID);
            builder.HaveSpecificStat(Guid.Parse("6d9e09e7-2144-43de-b15a-867ea1271bec"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c11a254e-b9aa-4df9-b2c9-1a157286d92a"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("47fbbcef-4c96-4a9c-af91-2b783dceb73d"), Traits.Instances.Dedication.ID);
            builder.Add(Guid.Parse("5695bc2e-6a70-483c-ab95-32eeefa0ea89"), Traits.Instances.Multiclass.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77e2d4dc-fc3d-4a76-b99e-dd1c57501eb4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
