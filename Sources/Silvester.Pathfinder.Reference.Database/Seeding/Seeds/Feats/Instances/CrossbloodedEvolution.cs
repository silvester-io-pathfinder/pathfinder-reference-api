using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrossbloodedEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("d4abca8e-db53-4303-9c09-e607fb29e21a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crossblooded Evolution",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0de8dac-b0d1-4c2d-bf38-d817c6b35566"), Type = TextBlockType.Text, Text = "Odd interactions in your bloodline provide you with unexpected spells. You can have one spell in your spell repertoire from a tradition other than the one that matches your bloodline. You cast that spell as a spell from your bloodline’s tradition. You can swap which spell you add and from which tradition as you could any other sorcerer spell, but you can’t have more than one spell from another tradition in your spell repertoire at the same time using this feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c6964d0-1498-4be3-89e0-b960c18894be"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
