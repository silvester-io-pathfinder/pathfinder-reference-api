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
    public class GenieBlessed : Template
    {
        public static readonly Guid ID = Guid.Parse("2db31e00-46e2-40ce-90c9-d4dfcea59cd9");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Genie-Blessed",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("74dedb9a-fb19-4a39-874d-46e40db59e96"), Type = TextBlockType.Text, Text = "You've sought out a powerful genie and requested their blessing, hoping to increase your fortune. Your wish was vague, but fortune and the genie favored you with a more powerful effect than an ordinary wish, granting you bits of wish-twisted luck throughout the rest of your life. Meanwhile, other genies of the same kind recognize you as one blessed by one of their most powerful nobles, and might treat you with greater respect or envy." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Charisma.ID);
            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Genie.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.WishForLuck.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d16ce6bd-3767-4a84-ae05-53ae805d5c28"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 30
            };
        }
    }
}
