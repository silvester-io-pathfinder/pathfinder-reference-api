using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("64e8365d-8b76-40e2-980c-57793e251441"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("881bcc6f-8a5c-441f-8892-2fe0a661d6c7"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("76ac5a0d-3147-458b-9249-18f2d9acae85"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("d0056601-2d73-4137-9183-b8fae544cd45"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("2d2d74fa-778a-4d77-86a9-87143595b32b"), Traits.Instances.Stance.ID);
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
