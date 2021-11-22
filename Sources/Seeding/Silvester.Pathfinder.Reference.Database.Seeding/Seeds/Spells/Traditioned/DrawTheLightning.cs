using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DrawTheLightning : Template
    {
        public static readonly Guid ID = Guid.Parse("55417c69-97dd-4a26-b09e-f11f7a6eda05");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Draw the Lightning",
                Level = 4,
                Range = "120 feet.",
                Duration = "1 minute.",
                Targets = "1 creature that is either taller than you or higher in the air than you.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e17b2389-dc1f-4f36-b38e-e0138883c1ba"), Type = TextBlockType.Text, Text = "Calling out to the skies, you summon a bolt of lightning to strike through a foe above you and down into your weapon or your body, charging it with electrical power. You must hold your weapon or an empty hand aloft as part of this spell�s somatic component. When you do, a bolt of lightning descends from a storm cloud in the air above your and through the target, dealing 3d12 electricity damage with a basic Reflex save. For the rest of the spell�s duration, your first Strike each round with the weapon you held aloft (or with your unarmed attacks if you held an empty hand aloft) deals an additional 1d12 electricity damage." };
            yield return new TextBlock { Id = Guid.Parse("dba6cc7d-9a71-43ff-953c-0cfdcc64460a"), Type = TextBlockType.Text, Text = "The spell creates its own storm cloud if necessary, so you can cast draw the lightning anywhere, even underground. If draw the lightning is cast outside under a cloudy or stormy sky, increase the bolt�s damage by 2d12." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7828a63b-9078-4d55-b364-bad358b2c619"),
                Level = "8th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("b267426e-7163-46b0-9d28-957701fe4967"), Type = TextBlockType.Text, Text = "The damage dealt to the initial target increases by 4d12, and the additional damage dealt on the first Strike each turn increases by 1d12." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7dc937b-826e-4998-84d5-871596d87760"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 101
            };
        }
    }
}
