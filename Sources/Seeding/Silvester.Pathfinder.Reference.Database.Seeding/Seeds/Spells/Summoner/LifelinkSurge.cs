using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LifelinkSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("b18c5c71-3236-4451-a3b0-0f09ab21a407");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Lifelink Surge",
                Level = 2,
                Duration = "4 rounds.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
                ClassId = Classes.Instances.Summoner.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3d870337-9564-4c1c-b96c-1f5fdf9fc19f"), Type = TextBlockType.Text, Text = "You make a quick gesture, tracing the link between yourself and your eidolon and drawing on your connection to slowly strengthen your shared life force. Your eidolon gains fast healing 4 for 4 rounds." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("513b8573-1ab0-46cd-96f4-9a1c42ea1bff"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0bb8b001-6d06-40f8-91ea-0eb598691cf1"), Type = TextBlockType.Text, Text = "The fast healing increases by 2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
            yield return Traits.Instances.Summoner.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b86f5cba-55c9-4c47-a7fa-0eea67387dcf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 145
            };
        }
    }
}
