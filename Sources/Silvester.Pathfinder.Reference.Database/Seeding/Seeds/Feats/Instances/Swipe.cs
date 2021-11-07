using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Swipe : Template
    {
        public static readonly Guid ID = Guid.Parse("cf0ab1c2-db20-4ad0-b89a-651bdcc0cb4f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swipe",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6015c8c-9a3c-45e3-9c69-cc71a5b90a97"), Type = TextBlockType.Text, Text = "You make a wide, arcing swing. Make a single melee (Action: Strike) and compare the attack roll result to the ACs of up to two foes, each of whom must be within your melee reach and adjacent to the other." };
            yield return new TextBlock { Id = Guid.Parse("a32f9bc1-725f-4d26-bb67-6d1a8aac3208"), Type = TextBlockType.Text, Text = "Roll damage only once and apply it to each creature you hit. A Swipe counts as two attacks for your multiple attack penalty." };
            yield return new TextBlock { Id = Guid.Parse("00819f11-4b6b-4a45-9fd7-3c859d227d2d"), Type = TextBlockType.Text, Text = "If you’re using a weapon with the (trait: sweep) trait, its modifier applies to all your Swipe attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e5fd190-efa6-40d2-b336-d658969b4292"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
