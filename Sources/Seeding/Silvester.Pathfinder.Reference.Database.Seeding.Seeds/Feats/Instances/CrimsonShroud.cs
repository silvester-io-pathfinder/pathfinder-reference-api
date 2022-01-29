using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrimsonShroud : Template
    {
        public static readonly Guid ID = Guid.Parse("05f3ca1a-fd9a-4678-b68c-177b38214003");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crimson Shroud",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "A number of times per day equal to your number of class feats from the Red Mantis assassin archetype"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("11f93211-a597-4a2d-b269-69c76096c9b3"), Type = TextBlockType.Text, Text = $"You swathe yourself in a veil of red mist for 1 minute. While the shroud is active, you gain fast healing equal to half your level. You can {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} with your shroud, swirling it around you, to gain a +1 circumstance bonus to AC until the beginning of your next turn. Finally, if you die while the shroud is active, you can choose to have your entire body vanish into red mist, leaving behind only your gear; you make this choice when you activate Crimson Shroud." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7e759345-9ee3-4a7e-8192-3cc44e9042f7"), Feats.Instances.RedMantisAssassinDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3993c03-242d-4262-86a9-dd84a7b49acf"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
