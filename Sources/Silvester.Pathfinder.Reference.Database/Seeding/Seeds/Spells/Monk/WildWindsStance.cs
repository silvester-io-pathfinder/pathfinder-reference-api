using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WildWindsStance : Template
    {
        public static readonly Guid ID = Guid.Parse("e089b11e-d249-4e4a-bf20-2e91bca8fa84");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wild Winds Stance",
                Duration = "Until you leave the stance.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8a07992-739d-48aa-b134-e21e582abf54"), Type = TextBlockType.Text, Text = "You take on the stance of the flowing winds, sending out waves of energy at a distance. You can make wind crash unarmed Strikes as ranged Strikes against targets within 30 feet. These deal 1d6 bludgeoning damage, use the brawling group, and have the agile, nonlethal, propulsive, and unarmed traits. Wind crash Strikes ignore concealment and all cover." };
            yield return new TextBlock { Id = Guid.Parse("13b5c8c5-e7f2-4fbb-a43f-b89f8217b244"), Type = TextBlockType.Text, Text = "While in wild winds stance, you gain a +2 circumstance bonus to AC against ranged attacks." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Stance.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12bc7653-ac15-4b1f-8d89-83de28ec452b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 402
            };
        }
    }
}
