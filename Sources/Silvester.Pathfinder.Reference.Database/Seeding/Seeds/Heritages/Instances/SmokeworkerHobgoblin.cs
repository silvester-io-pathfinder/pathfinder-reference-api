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
    public class SmokeworkerHobgoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Smokeworker Hobgoblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your family have been alchemists, engineers, and scientists for generations, on projects bringing smoke and fire to the field of battle. You gain fire resistance equal to half your level (minimum 1). You automatically succeed at the DC 5 flat check to target a concealed creature if that creature is concealed only by smoke." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.Manual(Guid.Parse(""), "You automatically succeed at the DC 5 flat check to target a concealed creature if that creature is concealed only by smoke.");
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
