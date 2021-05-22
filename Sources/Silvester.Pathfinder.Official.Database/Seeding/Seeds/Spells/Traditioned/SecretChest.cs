using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SecretChest : Template
    {
        public static readonly Guid ID = Guid.Parse("c1ec98bb-0aa6-4599-86e8-e9a4f4673183");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Secret Chest",
                Level = 5,
                CastTime = "1 minute.",
                Range = "Touch.",
                IsDismissable = true,
                Duration = "Until the next time you make your daily preparations.",
                Targets = "1 container and its contents, totaling 10 Bulk or less.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4b519c18-068d-49cb-8b91-49b0dbdffd8d"), Type = TextBlockType.Text, Text = "You banish a container and its contents to the Ethereal Plane,where you can retrieve it from later. The container’s physical properties—the material from which it is made, any locks, or other features—are irrelevant to the casting of this spell, but the container can’t contain any creatures. When you Cast this Spell, the container and all its contents are transported to a random location deep in the Ethereal Plane. Time passes normally for the container and its contents, and the environmental effects of the Ethereal Plane apply to it. Though very unlikely, it’s possible for a creature on the Ethereal Plane to stumble upon the chest." };
            yield return new TextBlock { Id = Guid.Parse("25d78c45-51bc-4aa0-af87-b6d54be1d955"), Type = TextBlockType.Text, Text = "You can Dismiss the spell to return the chest to your current location. If the spell ends by any other means, the container is lost on the Ethereal Plane and you can no longer recall it with this spell, though you could search for it in other ways." };
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
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41305688-652e-4c15-b01a-d58c2566c469"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 225
            };
        }
    }
}
