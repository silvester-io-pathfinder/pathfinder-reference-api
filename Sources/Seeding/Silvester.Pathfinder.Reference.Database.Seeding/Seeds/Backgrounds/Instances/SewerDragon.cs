using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class SewerDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("da6a2569-3843-4164-b7b0-817282cf0b15");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Sewer Dragon",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9dec7a2d-b445-4e22-a960-9b46f3ff52ed"), Type = TextBlockType.Text, Text = "You are one of the Sewer Dragons, born in Absalom's sewers, strengthened by a life defending your territory." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        {
            builder.HaveSpecificAncestry(Guid.Parse("cbef83d6-867c-4742-9c87-6218176818d2"), Ancestries.Instances.Kobold.ID);
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("48a98169-c5b0-4846-8a00-1fa8719b7a96"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("50c26e93-5543-433c-a523-06c259337a9d"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("d89369e7-172e-4df2-b6fc-542f36060547"), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("60379b56-4391-404b-b94b-5b9a59ae49cf"));
            builder.GainSpecificSkillProficiency(Guid.Parse("b017b4fc-0b48-48bb-8079-400b330622a5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("8b523adb-0f5d-4299-b772-048f2fdec970"), Proficiencies.Instances.Trained.ID, Lores.Instances.Kobold.ID);
            builder.GainSpecificFeat(Guid.Parse("3f71f067-7e44-450a-90cf-23e4104fcb16"), Feats.Instances.SnareCrafting.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e43062ff-ee79-4183-9ec3-7ba7175781ee"),
                SourceId = Sources.Instances.PathfinderSocietyQuest10.ID,
                Page = 16
            };
        }
    }
}
