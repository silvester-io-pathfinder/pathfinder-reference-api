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
    public class WarrenbredHobgoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Warrenbred Hobgoblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your ancestors lived underground. Your ears are larger than those of other hobgoblins and sensitive to echoes. When you are underground, you can use the Seek action to sense undetected creatures within a 30-foot burst instead of a 15-foot burst. In addition, if you roll a success on an Acrobatics check to Squeeze, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "When you are underground, you can use the Seek action to sense undetected creatures within a 30-foot burst instead of a 15-foot burst.");
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse(""), Skills.Instances.Acrobatics.ID, SkillActions.Instances.Squeeze.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 49
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Hobgoblin.ID;
        }
    }
}
