using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReactiveInterference : Template
    {
        public static readonly Guid ID = Guid.Parse("b6a45159-5823-4a52-b7c5-82cf787babc9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reactive Interference",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An adjacent enemy begins to use a reaction.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be5b3492-ec97-4571-97e7-888c1d2eb0c4"), Type = TextBlockType.Text, Text = "Grabbing a sleeve, swiping with your weapon, or creating another obstruction, you reflexively foil an enemy’s response. If the triggering creature’s level is equal to or lower than yours, you disrupt the triggering reaction. If the triggering creature’s level is higher than yours, you must make an attack roll against its AC. On a success, you disrupt the reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e158e8a0-212b-4e4a-95b2-17f50f295b15"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
