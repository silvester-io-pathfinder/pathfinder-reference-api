using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AbolethTransmutation : Template
    {
        public static readonly Guid ID = Guid.Parse("d4959878-b3cd-4d54-9ad2-5de882966dc1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aboleth Transmutation",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("05599f5e-f4b3-4bcc-8eb4-124fd4ebc8cc"), Type = TextBlockType.Text, Text = "You have tapped into the ancient magic used by alghollthu masters (also known as aboleths) to mold the flesh of your ancestors. You can use this magic to transfigure other beings. You gain 3rd-level (spell: feet to fins) and 2nd-level (spell: water breathing) as arcane innate spells. You can cast each of these arcane innate spells once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b65ac0a9-beb4-4f36-8a24-2fabbd7078d5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
