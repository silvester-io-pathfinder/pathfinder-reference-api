using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecoverSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("089e17a3-4121-4913-942e-da6335734c1e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recover Spell",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c408f7db-24dc-4ab7-b9a1-abf0221fcc24"), Type = TextBlockType.Text, Text = "You recover the energy of a recently disrupted spell, allowing you to cast it again as long as you do so immediately before the energy dissipates. You regain the use of a spell that was disrupted since the beginning of your last turn, but you must immediately (activity: Cast the Spell | Cast a Spell) again with your next action or else you lose the spell; as normal for (trait: metamagic), this must be on the same turn that you use Recover Spell. You can change the area, targets, and other variables, including the number of actions used to (activity: Cast the Spell | Cast a Spell) if the spell allows, such as when casting (spell: heal) or (spell: magic missile)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("daac7df3-1b6f-43cd-9a30-2e37fa89a2bc"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6932119a-2c77-4ea1-bbf3-d543f030bc08"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
