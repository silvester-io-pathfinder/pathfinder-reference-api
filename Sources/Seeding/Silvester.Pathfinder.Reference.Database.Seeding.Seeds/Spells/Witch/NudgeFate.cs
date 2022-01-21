using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class NudgeFate : Template
    {
        public static readonly Guid ID = Guid.Parse("207bad5c-0b66-46d8-a598-e96728a9704c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nudge Fate",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9a353eb-67d3-4942-afe9-8c01ac761512"), Type = TextBlockType.Text, Text = "You read slightly into the future and give fate a tiny push to achieve the result you desire. Once during the duration, when the target fails an attack roll, skill check, or saving throw and a +1 status bonus would turn a critical failure into a failure, or failure into a success, you grant the target a +1 status bonus to the check retroactively, changing the outcome appropriately. The spell then ends, and the target is temporarily immune for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("3452e813-0bef-4552-b5dc-87d4cc7bf795"), Type = TextBlockType.Text, Text = "If you cast nudge fate while a previous casting of this hex is still in effect, the previous effect ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("889b6a21-580d-4c4d-88ff-e944620c58bf"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ffe675b0-601f-4c4f-b087-3343f3ae3998"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("0489f4b9-e449-45ec-8dc6-a6580a586180"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("9775a429-91f8-4c3a-9ddf-ad44c1741df8"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("de7717db-dc5a-4389-8b5e-44ce76373c71"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf362fe9-64a6-4dd7-85f4-ff5c6630492d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
