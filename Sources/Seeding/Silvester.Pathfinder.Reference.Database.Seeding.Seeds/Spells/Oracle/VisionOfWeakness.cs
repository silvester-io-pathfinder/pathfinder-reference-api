using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VisionOfWeakness : Template
    {
        public static readonly Guid ID = Guid.Parse("8fcfc44b-127f-4ff8-958f-915cc73c973f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Vision of Weakness",
                Level = 2,
                Targets = "1 creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92ca33d6-8310-4706-af7c-da1815a0fc08"), Type = TextBlockType.Text, Text = "You focus your gaze on a creature and gain a flash of divine insight into its nature. If the creature has any weaknesses, you learn them, as well as which of its three saving throw modifiers is lowest. You also learn an inherent understanding of its movements and gain a +2 status bonus to your next attack roll (or skill check made as part of an attack action) against that foe before the end of your turn. The target is then temporarily immune to vision of weakness for 1 day." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a0546d0b-df19-4789-9444-98968c2154ef"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7b0d5668-1ad5-4925-af74-dc35610435ef"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("64f59682-1e4c-4220-987c-07cf09f01038"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("b184e591-651f-472e-8d22-4f09d1fa3d4d"), Traits.Instances.Oracle.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ddb05f80-de86-4b21-b33d-8646d6656649"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 234
            };
        }
    }
}
