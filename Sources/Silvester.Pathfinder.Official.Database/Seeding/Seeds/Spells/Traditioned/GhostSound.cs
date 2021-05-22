using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class GhostSound : Template
    {
        public static readonly Guid ID = Guid.Parse("9a93f513-7f09-48b1-b645-a650564aba41");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ghost Sound",
                Level = 1,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("476eacdf-a8f5-4fd7-bbfd-e59f0cbafcfd"), Type = TextBlockType.Text, Text = "You create an auditory illusion of simple sounds that has a maximum volume equal to four normal humans shouting. The sounds emanate from a square you designate within range. You can’t create intelligible words or other intricate sounds (such as music)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("48ec7c86-b917-42fc-9e80-744168a0c5bb"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a9155358-7b0b-4ed6-8091-e29c1b058f8f"), Type = TextBlockType.Text, Text = "The range increases to 60 feet." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("2e2b0ed1-9385-47ff-aae5-d799294878fd"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("47c20f48-5343-4822-a115-86cdc4ffdc97"), Type = TextBlockType.Text, Text = "The range increases to 120 feet." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1dd904f-af1f-4cb9-99ac-22727274d4cf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 340
            };
        }
    }
}
