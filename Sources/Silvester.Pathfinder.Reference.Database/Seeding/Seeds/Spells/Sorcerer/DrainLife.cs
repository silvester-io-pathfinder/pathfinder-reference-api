using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class DrainLife : Template
    {
        public static readonly Guid ID = Guid.Parse("e2bbeff8-a090-4f1b-918a-84aa2041a44b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Drain Life",
                Level = 3,
                Range = "30 feet.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d80acd8d-65c9-4f7a-9027-5764acf65b49"), Type = TextBlockType.Text, Text = "You close your hand and pull life energy from another creature into yourself. This deals 3d4 negative damage; the target must attempt a basic Fortitude save. You gain temporary Hit Points equal to the damage the target takes, after resolving its save and applying your blood magic if applicable. If the target’s Hit Points were lower than the damage you dealt, you gain temporary Hit Points equal to their remaining Hit Points instead. The temporary Hit Points last for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("550c6a17-0a93-47f1-a80e-67e9b300647c"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("fa970035-15a2-4fdc-aaf7-5b6fe317df5c"), Type = TextBlockType.Text, Text = "The damage increases by 1d4." }
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
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3676cbfb-6a6f-44ea-aa9c-52d407bdfa06"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 403
            };
        }
    }
}
