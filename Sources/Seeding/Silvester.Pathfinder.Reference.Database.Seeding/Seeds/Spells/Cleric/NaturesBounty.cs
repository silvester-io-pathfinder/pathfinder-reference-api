using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class NaturesBounty : Template
    {
        public static readonly Guid ID = Guid.Parse("19431276-6477-437a-a6a6-04b51b29cd18");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nature's Bounty",
                Level = 4,
                Requirements = "You have a free hand.",
                DomainId = Domains.Instances.Nature.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8df347e0-eb22-412a-9368-d0afa84c86c6"), Type = TextBlockType.Text, Text = "A palm-sized raw fruit or vegetable appears in your open hand. You choose the specific type of food. A creature can consume the food with an Interact action to regain 3d10+12 Hit Points and be nourished as if it had eaten a meal. If uneaten, the food rots and crumbles to dust after 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("da88f2aa-3034-4885-9513-8e2c755df800"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d0a98baa-4f21-48d2-acdb-b0eba2038d56"), Type = TextBlockType.Text, Text = "The Hit Points restored increase by 6." }
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
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Plant.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2bbc245a-2141-49f6-9a31-00f45c0af524"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 394
            };
        }
    }
}
