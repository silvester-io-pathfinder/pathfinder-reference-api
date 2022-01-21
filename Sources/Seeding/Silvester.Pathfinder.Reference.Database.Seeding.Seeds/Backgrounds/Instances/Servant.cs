using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Servant : Template
    {
        public static readonly Guid ID = Guid.Parse("bd4c13a6-175d-4eeb-9bf7-c688deda6f50");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Servant",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b383ea03-141a-4c90-ad77-f1f40b48ea8b"), Type = TextBlockType.Text, Text = "You held a role of servitude, waiting on nobles and engendering their trust as one of the confidantes of the household. You might have walked away on good terms, or perhaps you know dangerous secrets about your former masters. Regardless, you're adventuring for a change and finding that in this new role, the skills you've learned now serve you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("de62c499-a4ec-401b-9de6-a5a492e22f40"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("6dde4e68-d9e7-4e7b-a864-c3a54ef5760e"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("2d35b49b-c5bd-4648-9e51-27c64f869ce2"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("858723b3-0e33-417a-aebd-b5afef0d5021"));

            builder.GainSpecificSkillProficiency(Guid.Parse("133afc1c-972a-45c5-b7f3-4b2a735f3c14"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("ee959a69-aee9-4104-bbfe-fdf4c691eaa2"), Proficiencies.Instances.Trained.ID, Lores.Instances.Labor.ID);
            builder.GainSpecificFeat(Guid.Parse("d54b9ea1-4987-49ef-9ae5-9c224ec9464a"), Feats.Instances.ReadLips.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42724bd7-a131-49d2-b0d0-0e9aa67ec0d9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
