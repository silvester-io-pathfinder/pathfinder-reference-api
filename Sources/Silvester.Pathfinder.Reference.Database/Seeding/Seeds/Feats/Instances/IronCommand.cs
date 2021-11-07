using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IronCommand : Template
    {
        public static readonly Guid ID = Guid.Parse("2a810a73-7ca4-4e65-bbdd-df8dd4a52238");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iron Command",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy within 15 feet damages you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00592da8-9d60-41c8-9bca-310f0f3e9369"), Type = TextBlockType.Text, Text = "You put an impertinent foe who dared harm you in their proper place. You command your enemy to kneel before you in obedience. If they dare to refuse, they must pay the price in pain and anguish. The foe must choose one of the following options." };
            yield return new TextBlock { Id = Guid.Parse("58d73559-d2e0-4cc3-ba7f-8d468b30d027"), Type = TextBlockType.Enumeration, Text = " : The enemy kneels, dropping prone as a free action." };
            yield return new TextBlock { Id = Guid.Parse("4a778ca4-7813-4bf8-8787-5d80d00f8309"), Type = TextBlockType.Enumeration, Text = " : The enemy refuses, and you deal 1d6 mental damage to it. This damage increases to 2d6 at 5th level, 3d6 at 9th level, 4d6 at 12th level, 5d6 at 16th level, and 6d6 at 19th level." };
            yield return new TextBlock { Id = Guid.Parse("9015405f-be1e-4650-9786-28584d04c530"), Type = TextBlockType.Text, Text = "In addition, your (action: Strikes | Strike) against the triggering creature deal 1 extra damage until the end of your next turn. You choose whether the damage type is evil or negative each time you use this reaction. This extra damage increases to 2 at 9th level and 3 at 16th level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("546f9662-d10f-4381-90d9-ce6aa68730d5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
