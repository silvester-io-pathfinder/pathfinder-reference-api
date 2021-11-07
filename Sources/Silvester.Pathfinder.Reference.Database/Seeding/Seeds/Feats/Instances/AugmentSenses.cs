using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AugmentSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("b18a051a-6a1c-4773-89d9-b78d9f9ad1e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Augment Senses",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("65a2ca64-acf9-41bc-add4-a7f7855e5bf1"), Type = TextBlockType.Text, Text = "You open vestigial eyes, unfurl tympanic flaps of skin, or otherwise enhance your senses. Until the start of your next turn, you gain the following benefits: you can’t be flanked; when you (action: Seek) for creatures, you can scan a 60-foot cone or a 30-foot burst instead of the normal area; and when you (action: Seek) for hidden objects, you can search a 15-foot square instead of the normal area." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c673153f-b470-47cc-b17f-58e3d89bed93"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
