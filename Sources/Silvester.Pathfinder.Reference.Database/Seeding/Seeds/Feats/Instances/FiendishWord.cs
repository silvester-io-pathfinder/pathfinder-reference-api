using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FiendishWord : Template
    {
        public static readonly Guid ID = Guid.Parse("4597464e-67d9-43ac-94b5-94454aff3b8d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiendish Word",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ee1407d-1081-4a83-add2-893702243e7a"), Type = TextBlockType.Text, Text = "You can call forth a blasphemous word from the fiendish realms to punish your foes. Once per day, you can cast (spell: divine decree) as a 7th-level divine innate spell. You must choose evil for the spell, and you can (activity: Cast the Spell | Cast a Spell) regardless of whether you have a deity or what their alignment is." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5289c360-e1dc-46e4-93ff-32b073bf5edf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
