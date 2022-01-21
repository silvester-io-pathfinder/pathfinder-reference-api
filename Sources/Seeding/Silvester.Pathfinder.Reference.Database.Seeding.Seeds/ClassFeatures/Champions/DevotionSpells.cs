using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class DevotionSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("64427cff-ac6f-4c70-916b-e701769878f7");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Devotion Spells", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f01c3e9e-0c9b-46bf-8b24-2a751fedaaa3"), Type = TextBlockType.Text, Text = "Your deity�s power grants you special divine spells called devotion spells, which are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you regain 1 Focus Point by spending 10 minutes using the Refocus activity to pray to your deity or do service toward their causes." };
            yield return new TextBlock { Id = Guid.Parse("1f9e1d6b-0422-4a86-81d1-b07d16956020"), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up. Certain feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points. The full rules are on page 300. You gain a devotion spell depending on your cause, and you are trained in divine spell attack rolls and spell DCs. Your spellcasting ability is Charisma." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("a0e11f09-39c4-434e-8593-865a3ab21b58"), MagicTraditions.Instances.Divine.ID);
            builder.GainFocusPoolPoint(Guid.Parse("b00a256a-0efd-4529-a370-d4f5561babcd"));
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("0ee20b42-6589-44dd-a368-d367beea1de8"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("35f92b49-986b-4107-b62d-079246798b8f"), Proficiencies.Instances.Trained.ID);
            builder.GainSpellcastingAbility(Guid.Parse("cc699764-c51a-4824-bc88-3d5d562fc4a9"), Stats.Instances.Charisma.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7585ca1f-0e02-4572-a500-41705d5cc7a3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
