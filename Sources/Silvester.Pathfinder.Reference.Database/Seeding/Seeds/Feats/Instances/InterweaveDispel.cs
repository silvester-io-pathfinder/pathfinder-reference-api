using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InterweaveDispel : Template
    {
        public static readonly Guid ID = Guid.Parse("475bd5c2-e537-4e34-8bb4-5aa1e9e78342");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Interweave Dispel",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("927d775a-5527-4845-a1fc-625989f92899"), Type = TextBlockType.Text, Text = "You weave dispelling energy into a spell, sending both effects at a foe. If your next action is to cast a single-target spell against a creature, and you either hit the foe with the spell attack roll or the foe fails its saving throw, you can cast (spell: dispel magic) on the foe as a free action, expending a spell slot as normal and targeting one spell effect affecting the foe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("e0ceb91c-0587-4775-b0ab-50094ac9f00d"), Spells.Instances.DispelMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69007dde-f1c7-419a-a704-2f73d2e84185"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
