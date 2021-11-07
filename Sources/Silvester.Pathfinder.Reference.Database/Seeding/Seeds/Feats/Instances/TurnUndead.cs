using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TurnUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("c67a508c-690b-4d0e-b5c8-ab10b204b569");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Turn Undead",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("009db9f3-d356-4844-ba58-8dc7304faea6"), Type = TextBlockType.Text, Text = "Undead harmed by your positive energy might flee, compelled by an innate aversion to the force opposite undeath. When you use a (spell: heal) spell to damage undead, each undead of your level or lower that critically fails its save gains the fleeing condition for 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d55e0c17-b925-4d47-b680-8375bd621e63"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
