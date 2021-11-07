using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RazorClaws : Template
    {
        public static readonly Guid ID = Guid.Parse("a6617190-5a6a-4463-9f8e-b768af438361");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Razor Claws",
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
            yield return new TextBlock { Id = Guid.Parse("0887c739-9088-4cd1-83a1-054e95687b91"), Type = TextBlockType.Text, Text = "Your have honed your claws to be deadly. Your claw attack deals 1d6 slashing damage instead of 1d4 and gains the versatile (piercing) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("998985ef-886b-48bb-9797-dbb13edc1254"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
