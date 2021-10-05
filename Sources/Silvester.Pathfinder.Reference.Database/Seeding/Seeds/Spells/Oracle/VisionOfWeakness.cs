using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Oracle.ID;
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
