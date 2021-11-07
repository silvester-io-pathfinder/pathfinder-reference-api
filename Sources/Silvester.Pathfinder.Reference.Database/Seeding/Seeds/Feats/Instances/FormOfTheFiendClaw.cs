using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormOfTheFiendClaw : Template
    {
        public static readonly Guid ID = Guid.Parse("ed141068-9296-4cc3-8dfd-18083051de01");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form of the Fiend - Claw",
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
            yield return new TextBlock { Id = Guid.Parse("2f0b063c-ba82-4504-8eb0-d45682cfa018"), Type = TextBlockType.Text, Text = "Part of your body has an obvious, fiendish appearance. Your hands end in razor-sharp claws." };
            yield return new TextBlock { Id = Guid.Parse("7fb8ac63-7d17-4af9-8968-fac2b5b21438"), Type = TextBlockType.Enumeration, Text = " Claw: 1d4 slashing ((trait: agile), (trait: finesse), (trait: unarmed), (trait: versatile piercing | versatile p))" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7724ae4-2b5c-4c28-8221-18eca47c0cdf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
