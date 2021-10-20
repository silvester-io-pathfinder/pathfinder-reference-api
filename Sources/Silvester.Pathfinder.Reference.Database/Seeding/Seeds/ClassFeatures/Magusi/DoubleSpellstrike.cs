using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class DoubleSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Double Spellstrike", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can extend the magic of spells you store with Spellstrike. After you make a Spellstrike with a spell cast from a spell slot, you retain an echo of the spell, stored in your body. The next time you Spellstrike, you can cast the same spell again without expending a spell slot." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you choose to cast a different spell with Spellstrike, or you go 1 minute without using the stored spell, the stored spell dissipates harmlessly." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //TODO: Add effects.
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 42
            };
        }
    }
}
