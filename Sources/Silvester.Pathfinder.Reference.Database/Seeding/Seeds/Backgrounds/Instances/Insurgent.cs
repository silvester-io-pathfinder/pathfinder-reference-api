using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Insurgent : Template
    {
        public static readonly Guid ID = Guid.Parse("72ab3fdf-b23f-4f62-a0bc-eb3f0c8aac32");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Insurgent",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fade1cd7-b78d-4ffe-96f7-09cd3a75e53f"), Type = TextBlockType.Text, Text = "You were more than a rebel; you were a revolutionary, fighting for the promise of a new or better country. You may or may not still believe in the cause, or perhaps victory or exile has led you on this new journey to trumpet your glory... or to escape the consequences of your defeat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Warfare.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.LengthyDiversion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3dd5661-967c-4ad1-ad66-3650fbb54fad"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
