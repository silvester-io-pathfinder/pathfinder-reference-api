using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("67cda585-55b9-4ec8-bf44-7df2b6732c8d"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("58a1bf94-d074-460f-9937-d8cbba628c7d"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("07b34955-3da4-4a1a-8be1-1ac8f7d439b8"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("72f12e2e-9730-480f-a8f5-dd936f502111")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("9738914d-5ea1-4662-a124-9d0a5325e8a8"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Deception.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("78ea7dc3-71c9-4623-a6f2-af92345906b3"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Warfare.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("b554512d-40a5-4c2e-b13c-f3f7649cf05f"),
                FeatId = Feats.General.LenghtyDiversionFeat.ID
            };
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
