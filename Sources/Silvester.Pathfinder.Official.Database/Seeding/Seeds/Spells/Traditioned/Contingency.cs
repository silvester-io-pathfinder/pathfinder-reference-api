using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Contingency : Template
    {
        public static readonly Guid ID = Guid.Parse("94beacae-4765-499c-b93e-934fff8585a4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Contingency",
                Level = 7,
                CastTime = "10 minutes.",
                Duration = "24 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("78cf606d-3b0d-4fe9-91d2-e53b758b869b"), Type = Utilities.Text.TextBlockType.Text, Text = "You prepare a spell that will trigger later. While casting contingency, you also cast another spell of 4th level or lower with a casting time of no more than 3 actions. This companion spell must be one that can affect you. You must make any decisions for the spell when you cast contingency, such as choosing a damage type for resist energy. During the casting, choose a trigger under which the spell will be cast, using the same restrictions as for the trigger of a Ready action. Once contingency is cast, you can cause the companion spell to come into effect as a reaction with that trigger. It affects only you, even if it would affect more creatures. If you define complicated conditions, as determined by the GM, the trigger might fail. If you cast contingency again, the newer casting supersedes the older." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("d896e7f8-a52e-49d1-a1fe-98148ba1c246"), 
                Level = "8th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("1109b91c-bc25-4ac0-9496-6395e9f0d1ac"), Type = Utilities.Text.TextBlockType.Text, Text = "You can choose a spell of 5th level or lower." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("cda1fc96-7b2c-4df9-b65f-04b4a2e0f5c7"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("636220e6-b967-40ff-88b2-4d35a4cbbcd7"), Type = Utilities.Text.TextBlockType.Text, Text = "You can choose a spell of 6th level or lower." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("3f51f72d-37e7-4e37-8f3d-48686460b573"),
                Level = "10th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("46b1f716-4b6c-47c8-ad00-101822453564"), Type = Utilities.Text.TextBlockType.Text, Text = "You can choose a spell of 7th level or lower." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 326
            };
        }
    }
}
