using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class TailedGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("4a851a94-b9dd-4afe-b74e-4c3ef1407d9f");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Tailed Goblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f1888ace-8be8-4328-8206-ccd4ba39ff18"), Type = TextBlockType.Text, Text = "You have a powerful tail, likely because you descend from a community of monkey goblins. You gain a +2 circumstance bonus to Athletics checks to Climb, you gain Combat Climber as a bonus feat, and you reduce the number of free hands required to Climb or Trip by one." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("cb603a82-1030-491b-b570-15acab2a63a3"), Feats.Instances.CombatClimber.ID);
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("87e53227-e93c-4f12-9884-e1e5592237b8"), Skills.Instances.Athletics.ID, SkillActions.Instances.Climb.ID, bonus: 2);
            builder.Manual(Guid.Parse("aab1a498-240b-4346-9ae0-c62c6943972a"), "You reduce the number of free hands required to Climb or Trip by one.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b973e03-4f3f-4f13-838f-8aac7a293b68"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 37
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Goblin.ID;
        }
    }
}
