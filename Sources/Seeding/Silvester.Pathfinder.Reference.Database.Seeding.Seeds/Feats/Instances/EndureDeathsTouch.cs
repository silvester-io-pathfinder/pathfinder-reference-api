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
    public class EndureDeathsTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("1880a3a9-aa76-4548-b7e9-7973244aea40");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Endure Death's Touch",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An undead hits you with an unarmed attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("648aa352-62dd-4a17-b83c-33ff2d7222fe"), Type = TextBlockType.Text, Text = $"Your conviction redirects the undead's attack through your armor and then harmlessly away. You gain resistance 5 to physical damage and resistance 10 to negative damage against the triggering attack. You gain a +2 circumstance bonus on any saving throws against effects from the undead's natural attack; if you succeed at the saving throw, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("50499248-2d6d-45bf-902e-275b606e7516"), Feats.Instances.KnightVigilantDedication.ID);
            builder.AddOr(Guid.Parse("a2e6464c-35f3-4a4d-9a41-b89f502cfb3b"), or => 
            {
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("d5659d8f-e1a1-493f-b005-71763afacdd2"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("c60a6583-8215-451e-bf8b-337e6d5e0230"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.HeavyArmor.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9fc5169-a55e-4636-8e9e-5f67c8f99138"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
