using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GhostlyTragedy : Template
    {
        public static readonly Guid ID = Guid.Parse("3073eb33-645c-4198-a229-80e74125530b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ghostly Tragedy",
                Level = 4,
                CastTime = "1 minute.",
                Area = "60-foot emanation.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a82577e0-d2e0-4a79-beaf-d886c8d9b208"), Type = TextBlockType.Text, Text = "This spell compels local spirits to reenact a violent event of the recent past that you're aware of and name as you Cast the Spell. You take the role of the primary victim. The reenactment plays out the final 9 minutes leading up to the death or injury of the victim and the minute after their death or injury. The spirits don't change form, so this doesn't help determine perpetrators by their look. Spiritual forms of missing creatures necessary for the event manifest as needed, and missing items appear as shadowy outlines." };
            yield return new TextBlock { Id = Guid.Parse("e4cc18a6-829c-4da7-8d39-ea365b56a5b0"), Type = TextBlockType.Text, Text = "Once the scene ends, you take 2d6 negative damage for each ghostly apparition that participated in the scene (typically equal to the number of creatures involved other than the victim). Any creature that observed the ghostly recreation, including you, can attempt checks to investigate the event to discover new clues and information." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("faf9b646-df67-4057-9751-522c4a531e82"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7831344a-354c-4a1a-b906-491259aad131"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c154068-8c5e-4536-886e-f35990b38698"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 220
            };
        }
    }
}
