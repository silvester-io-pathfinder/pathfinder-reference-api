using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WizardElementalistWater : Template
    {
        public static readonly Guid ID = Guid.Parse("f8ccc043-b886-46ea-be42-3fb62619f3b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wizard Elementalist - Water",
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
            yield return new TextBlock { Id = Guid.Parse("7c268446-3d34-4cf7-aeb4-af3dda6aaf92"), Type = TextBlockType.Text, Text = "Instead of specializing in a school of magic, you specialize in one of the four elements: water. Any benefits your arcane school would grant you that are associated with a selected spell school, you instead apply to your selected element." };
            yield return new TextBlock { Id = Guid.Parse("fc39085a-34e6-4991-9b55-f448a0da648c"), Type = TextBlockType.Text, Text = "In place of your arcane school spell, you learn the initial water elemental focus spell ((spell: rising surf)). If you later select the (feat: Advanced School Spell) wizard feat, instead of gaining the listed school spell, you gain the advanced water elemental focus spell ((spell: pulverizing cascade))." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d72bb4aa-cc79-4ec2-94bc-2f2e817fbe56"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
