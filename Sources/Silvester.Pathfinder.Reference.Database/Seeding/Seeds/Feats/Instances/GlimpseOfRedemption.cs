using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GlimpseOfRedemption : Template
    {
        public static readonly Guid ID = Guid.Parse("9180602d-3a41-4cae-ba71-65cad268e16d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glimpse of Redemption",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy damages your ally, and both are within 15 feet of you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34de0e0e-11c8-4ba8-a88a-786d931d3b1e"), Type = TextBlockType.Text, Text = "Your foe hesitates under the weight of sin as visions of redemption play in their mind’s eye. The foe must choose one of the following options:" };
            yield return new TextBlock { Id = Guid.Parse("1fb2ed52-4b4a-4dee-bbbc-b3bdbc6b52dc"), Type = TextBlockType.Enumeration, Text = " : The ally is unharmed by the triggering damage." };
            yield return new TextBlock { Id = Guid.Parse("5888a504-3294-44af-86c6-c8d2896f3cf5"), Type = TextBlockType.Enumeration, Text = " : The ally gains resistance to all damage against the triggering damage equal to 2 + your level. After the damaging effect is applied, the enemy becomes enfeebled 2 until the end of its next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d37bdad8-506e-4a62-b918-b11b1b49bd14"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
