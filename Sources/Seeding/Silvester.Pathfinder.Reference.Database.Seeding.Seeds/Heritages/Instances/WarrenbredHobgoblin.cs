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
        public static readonly Guid ID = Guid.Parse("15f7489b-78a4-4ab5-88a0-be594c31ab25");

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
            yield return new TextBlock { Id = Guid.Parse("faa4aaf7-ccde-48b9-886f-f8aa0f5da5f7"), Type = TextBlockType.Text, Text = "Your ancestors lived underground. Your ears are larger than those of other hobgoblins and sensitive to echoes. When you are underground, you can use the Seek action to sense undetected creatures within a 30-foot burst instead of a 15-foot burst. In addition, if you roll a success on an Acrobatics check to Squeeze, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("da0c77b8-da95-4a05-9b40-79bd37096d18"), "When you are underground, you can use the Seek action to sense undetected creatures within a 30-foot burst instead of a 15-foot burst.");
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse("894f8298-438b-4e38-841e-366f1ad51724"), Skills.Instances.Acrobatics.ID, SkillActions.Instances.Squeeze.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62f7ad2a-653c-41d3-92c7-72c920c8f28f"),
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
