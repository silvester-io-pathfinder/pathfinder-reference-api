using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShatterDefenses : Template
    {
        public static readonly Guid ID = Guid.Parse("b636622c-d863-4238-8cb7-1b5dbd3e127f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shatter Defenses",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08454f55-d625-4bd4-b074-5b4549f0f7ef"), Type = TextBlockType.Text, Text = "Your offense exploits your enemy’s fear. Make a melee (Action: Strike) against a frightened creature. If you hit and deal damage, the target becomes flat-footed until its frightened condition ends." };
            yield return new TextBlock { Id = Guid.Parse("82d483c1-a039-40d9-9be0-2f84bc465670"), Type = TextBlockType.Text, Text = "If the target was already flat-footed to you when you damaged it with this (Action: Strike), it can’t reduce its frightened value below 1 until the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9970d7cc-5e10-45dc-8e72-206462756639"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
