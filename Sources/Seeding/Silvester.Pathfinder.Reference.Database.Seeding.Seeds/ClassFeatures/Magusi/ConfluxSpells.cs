using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class ConfluxSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("c5cdb0f4-272b-48fc-8723-dd9620c53b06");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Conflux Spells", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("971e5426-8403-47b2-881b-25aec9cb837f"), Type = TextBlockType.Text, Text = "You learn a conflux spell from your hybrid study, and you can cast additional conflux spells by selecting certain feats. Conflux spells are magus-specific spells created for combat and are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the Refocus activity to both study your spellbook and perform a physical regimen." };
            yield return new TextBlock { Id = Guid.Parse("f579343f-fcd1-4153-84e1-ea2e8f7468a4"), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up. Focus spells don't require spell slots, nor can you cast them using spell slots. Taking feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 points. The full rules can be found here." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainFocusPoolPoint(Guid.Parse("d6ab7ab9-3499-4717-8a43-16c7ee84e3e4"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71c1f460-5446-4db1-9f21-160dd264d37d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
