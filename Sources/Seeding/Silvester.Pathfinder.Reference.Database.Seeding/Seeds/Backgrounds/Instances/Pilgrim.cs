using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Pilgrim : Template
    {
        public static readonly Guid ID = Guid.Parse("ad0767b8-8588-4e00-ba5e-8335b48fea81");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Pilgrim",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("608b5903-feea-41f3-bd1c-6c0625715745"), Type = TextBlockType.Text, Text = "In your youth, you made several pilgrimages to important shrines and holy sites. You might have been a mendicant friar, a seller of holy relics (real or fraudulent), or just a simple farmer following the dictates of your faith. Whatever the aims of your wanderings now, your faith still protects you on the road." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("00b11924-c3d2-4844-8faf-5fdc200d9b36"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("369ef627-152e-47c0-8a0f-bf02fa36b2fb"), Stats.Instances.Wisdom.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("bf1a2dca-32d3-4da6-afa3-7f5a42b815fa"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("ac4805fc-b096-44ae-a3f7-d565182572b2"));
            builder.GainSpecificSkillProficiency(Guid.Parse("c0cd39bf-dfe4-4e0f-9d7f-edbe8431baee"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("36f6b11a-0f40-4302-903f-9cec9945fc05"), Proficiencies.Instances.Trained.ID, Lores.Instances.Plant.ID);
            builder.GainSpecificFeat(Guid.Parse("db727f44-8bdd-4c0c-829d-f5f60a419827"), Feats.Instances.NaturalMedicine.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb3dc989-c572-4d96-917f-d8c8ec51d8a1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
