using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FalseVision : Template
    {
        public static readonly Guid ID = Guid.Parse("10642f60-a69a-468c-9c5c-7e8669c7794c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "False Vision",
                Level = 5,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Area = "100-foot burst.",
                Duration = "Until the next time you make your daily preparations.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a6470b54-3138-4b7f-80f1-dbd5be077a09"), Type = TextBlockType.Text, Text = "You create a false image that fools any attempts to scry on an area. Any scrying spell sees, hears, smells, and otherwise detects whatever you wish within the area, rather than what is actually in the area. You can Sustain the Spell each round to change the illusion as you desire, including playing out a complex scene. If the scrying spell is of a higher level than false vision, the scryer can attempt a Perception check to disbelieve the illusion, though even if they’re successful, they can’t learn what’s truly going on in the area." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7806d11d-d3a5-473e-9a3a-a5191d6995d4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 337
            };
        }
    }
}
