using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TakeItsCourse : Template
    {
        public static readonly Guid ID = Guid.Parse("1e5d845b-fab2-4def-954c-8865767ee28e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Take its Course",
                Level = 4,
                Range = "Touch.",
                Targets = "1 creature.",
                DomainId = Domains.Instances.Indulgence.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94446fe4-aa8a-4fef-b6c2-71fa1d158d00"), Type = TextBlockType.Text, Text = "When someone has overindulged, you can hasten them past the worst of their affliction or intensify their misery. This spell attempts to progress a disease affliction, a poison affliction, or persistent poison damage affecting the target. If the target is affected by more than one of these, you can choose from among those you are aware of; otherwise the GM chooses randomly. An unwilling target can attempt a Will save to negate take its course." };
            yield return new TextBlock { Id = Guid.Parse("ed9c674a-d7a5-47d5-b366-f81e0c648553"), Type = TextBlockType.Text, Text = "The effect of this spell depends on whether you're attempting to end an affliction or persistent poison damage, and whether you are attempting to help or hinder the target's recovery." };
            yield return new TextBlock { Id = Guid.Parse("cebac031-42ae-4230-aa42-193256954a64"), Type = TextBlockType.Enumeration, Text = "Affliction - The target immediately attempts its next saving throw against the affliction. You can grant the creature your choice of a +2 status bonus or a –2 status penalty to its saving throw against the affliction." };
            yield return new TextBlock { Id = Guid.Parse("ea1a8266-45c2-4ed4-924e-d1d775da4c31"), Type = TextBlockType.Enumeration, Text = "Persistent - Poison You can cause the target take the persistent poison damage immediately when you Cast this Spell (in addition to taking it at the end of its next turn). Whether or not you do so, the target attempts an additional flat check against the persistent poison damage. You can set the DC of that flat check to 5 or 20 instead of the normal DC." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2591b44b-6a67-4ff0-b93f-081cd4781e8d"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4dcb19d1-7eb1-4024-aead-b05a020cb512"), Type = TextBlockType.Text, Text = "You can attempt to progress any number of the target's eligible afflictions and persistent poison damage." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e7e66a07-2e4b-4e02-af3c-44fd8a5605b2"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b4beff2b-916b-438b-8ed8-0bb2e359600c"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("42195f58-b14d-43c1-9150-bc4089c76804"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8ca2446-315a-4d4b-88ab-ef3967ca5c06"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 397
            };
        }
    }
}
