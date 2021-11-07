using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Sociable : Template
    {
        public static readonly Guid ID = Guid.Parse("13ebe9a3-2299-45a4-b28c-075b3dea8bd2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sociable",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7d0083f-284a-4fbc-860b-bf452f3117d4"), Type = TextBlockType.Text, Text = "You’re extremely extroverted, and you often spend your time carousing or otherwise socializing. You are trained in Diplomacy (or another skill of your choice if you were already trained in Diplomacy), and you gain the (feat: Hobnobber) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3b85851-d230-4a79-9cba-93735b1548d6"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
