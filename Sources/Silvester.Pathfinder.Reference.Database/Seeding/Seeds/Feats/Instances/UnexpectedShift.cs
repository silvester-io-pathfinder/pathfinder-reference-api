using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnexpectedShift : Template
    {
        public static readonly Guid ID = Guid.Parse("cc33f8bf-8aca-4c78-88d7-40cb3f1f1f54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unexpected Shift",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would take damage from an attack, spell, or other effect.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb19c142-0168-40cf-82f2-952c3c6a0baf"), Type = TextBlockType.Text, Text = "Your supernatural connection sometimes causes you to phase from reality when under threat, disappearing for split seconds before reappearing - often surprising you as much as your enemies. Roll a DC 16 flat check. On a success, you gain resistance to all damage equal to your level against the triggering effect, you gain a +2 circumstance bonus to saving throws against that effect until the start of your turn, and you gain the dazzled condition for 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9890bc9b-53d1-4796-8f75-fbbd0a016808"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
