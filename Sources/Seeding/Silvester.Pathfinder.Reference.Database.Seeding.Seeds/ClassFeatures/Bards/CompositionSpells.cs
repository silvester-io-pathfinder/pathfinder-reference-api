using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class CompositionSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("8eaab613-3182-41c0-8871-2fc73380c67c");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Composition Spells", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("89631051-2ed8-4d40-a376-88cf4b064df6"), Type = TextBlockType.Text, Text = "You can infuse your performances with magic to create unique effects called compositions. Compositions are a special type of spell that often require you to use the Performance skill when casting them. Composition spells are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the Refocus activity to perform, write a new composition, or otherwise engage your muse." };
            yield return new TextBlock { Id = Guid.Parse("d6aa1218-33e1-400d-9652-5ee75d4cdd38"), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up, much like cantrips. Focus spells don't require spell slots, and you can't cast them using spell slots. Taking feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points. The full rules for focus spells are found here." };
            yield return new TextBlock { Id = Guid.Parse("0d417173-30fe-462f-bddc-8f0cd6f3e395"), Type = TextBlockType.Text, Text = "You learn the counter performance composition spell, protecting against auditory and visual effects." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainFocusPoolPoint(Guid.Parse("9035c9ac-b59b-4bb7-bf1b-b3cc4b846d49"));
            builder.GainSpecificSpell(Guid.Parse("4a62aab1-48ab-486e-90c9-96868cd3e6ce"), Spells.Instances.CounterPerformance.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f4a444b-967e-4525-ac15-0586487e4b48"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 96
            };
        }
    }
}
