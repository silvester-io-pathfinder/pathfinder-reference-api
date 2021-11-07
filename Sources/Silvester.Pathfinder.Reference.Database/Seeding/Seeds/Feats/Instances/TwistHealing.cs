using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwistHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("eac1e535-88a3-4170-9b1e-e631eb1a9522");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twist Healing",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09bb0b0b-3aa6-4c7f-a9a6-949145dc643f"), Type = TextBlockType.Text, Text = "Your connection to both life and undeath lets you twist the healing power of magic items to suit your own needs and aims. Whenever you (action: Activate an Item) to cast a (spell: heal) spell, you can invert its energy to produce the effects of an equivalent (spell: harm) spell instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("3b3bbf45-8bff-466e-ba31-3774c5c5dc20"), DivineFonts.Instances.Harm.ID);
            builder.HaveSpecificDivineFont(Guid.Parse("f0c1e041-d68c-44b9-acf0-2734df18f28b"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48ca204b-4757-4342-886b-5d904e1e14e5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
