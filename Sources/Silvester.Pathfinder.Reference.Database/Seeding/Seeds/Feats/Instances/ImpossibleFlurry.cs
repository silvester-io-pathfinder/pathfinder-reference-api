using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpossibleFlurry : Template
    {
        public static readonly Guid ID = Guid.Parse("309d6eac-b034-4e57-8f90-865dca946415");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impossible Flurry",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a6b9e8b8-3bb7-4187-aef6-709e65a53cd7"), Type = TextBlockType.Text, Text = "You forgo precision to attack at an impossible speed. Make three melee (action: Strikes | Strike) with each of the required weapons. All of these (action: Strikes | Strike) take the maximum multiple attack penalty, as if you had already made two or more attacks this turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c7dff3a-cd3d-4a83-98e4-3ff498fa05dd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
