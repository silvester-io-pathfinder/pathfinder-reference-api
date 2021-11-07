using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThroughSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("44fdeb22-7637-40c2-9709-f914d83d7fda");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Through Spell",
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
            yield return new TextBlock { Id = Guid.Parse("d9314bbd-f10d-44fa-a504-6bed468e1be2"), Type = TextBlockType.Text, Text = "Spells you cast can transform briefly into vital essence, traveling harmlessly through living and undead creatures between you and your target, blocked only by solid objects. If the next action you use is to (activity: Cast a Spell) that requires a spell attack roll, your targets don’t benefit from cover provided by living or undead creatures." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56ec6825-cbfa-4490-9708-4935d21d103e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
