using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormOfTheFiendTail : Template
    {
        public static readonly Guid ID = Guid.Parse("b79d3895-059e-4b06-be14-82010fd1bf7c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form of the Fiend - Tail",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ce849630-03e4-4596-9856-b0b422ce8151"), Type = TextBlockType.Text, Text = "Part of your body has an obvious, fiendish appearance. A whipping tail extends from your spine." };
            yield return new TextBlock { Id = Guid.Parse("52b7e3e8-4f56-4d4f-92fb-7e4c0c360672"), Type = TextBlockType.Enumeration, Text = " Tail: 1d4 bludgeoning ((trait: agile), (trait: finesse), (trait: unarmed))" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e630144-fb00-436c-b729-2ae2782a7bec"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
