using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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
            yield return new TextBlock { Id = Guid.Parse("d80acd8d-65c9-4f7a-9027-5764acf65b49"), Type = TextBlockType.Text, Text = "You close your hand and pull life energy from another creature into yourself. This deals 3d4 negative damage; the target must attempt a basic Fortitude save. You gain temporary Hit Points equal to the damage the target takes, after resolving its save and applying your blood magic if applicable. If the target's Hit Points were lower than the damage you dealt, you gain temporary Hit Points equal to their remaining Hit Points instead. The temporary Hit Points last for 1 minute." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("25b5de2a-2f82-4c1f-88a6-c7813f22037d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("c6821b7b-0951-4c7c-be8d-6b3e8c4b646c"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("be0e4ae5-1e66-47f1-9236-3d330b656608"), Traits.Instances.Negative.ID);
            builder.Add(Guid.Parse("8ea766c5-ab90-45dc-9f55-4ba3958b7d04"), Traits.Instances.Sorcerer.ID);
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
