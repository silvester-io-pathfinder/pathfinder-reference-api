using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Laborer : Template
    {
        public static readonly Guid ID = Guid.Parse("fc6fa118-2f62-4600-87de-ff881236b29f");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Laborer",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0b058dfd-f5e0-45c1-aaf7-5dd51f8394d6"), Type = TextBlockType.Text, Text = "You've spent years performing arduous physical labor. It was a difficult life, but you somehow survived. You may have embraced adventuring as an easier method to make your way in the world, or you might adventure under someone else's command." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("338b67e7-46e4-4afe-b5cb-0e108ddd5116"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("8ee40a00-badb-4867-a8c7-d04da67f4844"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("edb7d748-962a-41ab-bd10-374d86819398"), Stats.Instances.Constitution.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("b9634421-a029-42bc-9ec0-1f3ab1bd40e3"));
            builder.GainSpecificSkillProficiency(Guid.Parse("cd99796f-e8ff-43af-9085-6edb2bb08845"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("42390f7c-3408-4485-b987-736d68faf0c8"), Proficiencies.Instances.Trained.ID, Lores.Instances.Labor.ID);
            builder.GainSpecificFeat(Guid.Parse("393b3040-7136-4b05-81ed-09212bdb45a5"), Feats.Instances.HeftyHauler.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6562c03-1505-4aab-9a62-ddc77450c696"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
