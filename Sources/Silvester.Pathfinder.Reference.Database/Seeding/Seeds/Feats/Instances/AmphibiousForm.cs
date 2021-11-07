using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AmphibiousForm : Template
    {
        public static readonly Guid ID = Guid.Parse("ad15f7fc-4574-4fad-bbeb-68a0758e4277");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Amphibious Form",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c70d03ee-a13a-4c99-a98e-0bcc74c6a1c9"), Type = TextBlockType.Text, Text = "Your eidolon adapts to life on land and underwater. It gains the (trait: amphibious) trait, allowing it to breathe in water and air and to avoid the normal –2 penalty for making bludgeoning and slashing unarmed Strikes underwater. It gains a swim Speed equal to its land Speed or 25 feet, whichever is less; or if it is normally aquatic, it gains a land Speed equal to its swim Speed or 25 feet, whichever is less." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e956954-c148-4f4a-9716-d4a5de88a303"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
