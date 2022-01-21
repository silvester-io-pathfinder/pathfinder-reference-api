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
    public class Cultist : Template
    {
        public static readonly Guid ID = Guid.Parse("92747282-f80a-4fa9-b355-179dec25588d");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Cultist",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("44786491-c52b-4b82-8ed1-19ca5cb681c6"), Type = TextBlockType.Text, Text = "You were (or still are) a member of a cult whose rites may involve sacred dances to ensure a strong harvest or dire rituals that call upon dark powers. You might have taken up adventuring to further your cult's aims, to initiate yourself into the world's grander mysteries, or to flee unsavory practices or strictures." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("18ae87f1-06b9-4d25-8673-b80bfe95984d"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("05289f3c-59f7-42f5-adda-e64ad44bd6db"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("57ddf5b5-0738-406c-b565-5846a9dc1485"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("4c437cc6-dd8e-4a73-8c24-e89ad9dd1eb4"));
            builder.GainSpecificSkillProficiency(Guid.Parse("d3fc9402-cf0e-42e7-8a26-3f6b476f9463"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("73dbdbf6-68c5-40bc-a214-2deecf0cadb5"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Deities.ID, "The chosen Lore skill must be related to your deity or cult.");
            builder.GainSpecificFeat(Guid.Parse("433bdf25-7c3d-4fb2-afb2-e4617db19b73"), Feats.Instances.SchooledInSecrets.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12d53be2-1632-4dd7-b4ae-a1d0610e5ebf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
