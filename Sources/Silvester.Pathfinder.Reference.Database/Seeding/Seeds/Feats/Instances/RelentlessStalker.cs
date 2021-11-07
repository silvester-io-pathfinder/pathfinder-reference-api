using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RelentlessStalker : Template
    {
        public static readonly Guid ID = Guid.Parse("c30babe2-dbab-487b-baf1-0a07305fc534");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Relentless Stalker",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An adjacent creature you are hunting attempts to move away from you using an action that has the move trait.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60f43d4e-dd26-4724-8475-60cdda26a62d"), Type = TextBlockType.Text, Text = "Your hunted prey cannot escape your relentless pursuit. (action: Stride) up to your Speed in tandem with the triggering creature, remaining adjacent to the foe throughout its movement until it stops moving or you run out of movement. You can ignore difficult terrain during this movement unless the difficult terrain is caused by a (trait: magical) effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab590990-4f9d-439f-a83a-7dc72469fa20"),
                SourceId = Sources.Instances.FallOfPlaguestone.ID,
                Page = -1
            };
        }
    }
}
