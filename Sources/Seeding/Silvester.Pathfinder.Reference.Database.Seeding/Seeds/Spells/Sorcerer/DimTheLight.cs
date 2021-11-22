using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DimTheLight : Template
    {
        public static readonly Guid ID = Guid.Parse("c2d250d7-a185-4ff7-9ab8-aded8d0bdcf4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dim the Light",
                Level = 1,
                Trigger = "You cast a darkness or shadow spell.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b89c636-fa36-45a1-b4a6-d3d2dadcb0d5"), Type = TextBlockType.Text, Text = "You magnify the darkness from the triggering effect, causing the ambient light level to flicker briefly so you can slip from sight. You can immediately attempt a Stealth check to Hide, and you can become hidden to a creature even if you don't have cover and aren't otherwise concealed from that creature. You cease being hidden at the end of your turn unless you move into cover or become concealed before then." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Darkness.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6517d61f-4b8e-4e48-82a4-b29dfadb997a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 236
            };
        }
    }
}
