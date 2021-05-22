using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ClingingShadowStance : Template
    {
        public static readonly Guid ID = Guid.Parse("4932ec96-cb32-4b48-ade2-68d3e9d6d030");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Clinging Shadow Stance",
                Level = 4,
                IsDismissable = true,
                Duration = "Until you leave the stance.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee2a2892-36ff-47b0-a1ce-d039764ebdab"), Type = TextBlockType.Text, Text = "You adopt the stance of clinging shadows. You can make shadow grasp Strikes. These deal 1d4 negative damage; are in the brawling group; and have the agile, grapple, reach, and unarmed traits." };
            yield return new TextBlock { Id = Guid.Parse("d875794d-fef2-441f-9ef9-3574efe26446"), Type = TextBlockType.Text, Text = "While in clinging shadows stance, you gain a +2 circumstance bonus to Athletics checks to Grapple, and to the DC for creatures to Escape from you." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Shadow.ID;
            yield return Traits.Instances.Stance.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89342934-6bec-4364-92c0-0bf491460917"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 229
            };
        }
    }
}
