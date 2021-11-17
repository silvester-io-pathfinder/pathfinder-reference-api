using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormOfTheFiendClaw : Template
    {
        public static readonly Guid ID = Guid.Parse("7d8dc2a3-9dab-4ca6-9663-e5f1bb8be648");

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
            yield return new TextBlock { Id = Guid.Parse("1f5b3b8f-9279-4c1c-ab46-11aa8fbe3820"), Type = TextBlockType.Text, Text = "Part of your body has an obvious, fiendish appearance. Your hands end in razor-sharp claws." };
            yield return new TextBlock { Id = Guid.Parse("c7332cc9-aaa8-40fe-961e-c4ef08cfb33c"), Type = TextBlockType.Enumeration, Text = " Claw: 1d4 slashing ((trait: agile), (trait: finesse), (trait: unarmed), (trait: versatile piercing | versatile p))" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b7cb53e-922c-4ad8-9a50-fb00997a06a5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
