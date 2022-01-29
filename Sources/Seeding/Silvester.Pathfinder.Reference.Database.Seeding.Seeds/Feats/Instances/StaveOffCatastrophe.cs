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
    public class StaveOffCatastrophe : Template
    {
        public static readonly Guid ID = Guid.Parse("57c4e22e-ecb7-4927-88ea-1a8bffa7428f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stave Off Catastrophe",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("349a6588-6495-489e-a84b-068aa38278a4"), Type = TextBlockType.Text, Text = $"You fully protect your allies from the worst blows. When you use the {ToMarkdownLink<Models.Entities.Feat>("Shoulder Catastrophe", Feats.Instances.ShoulderCatastrophe.ID)} reaction, you can choose to take the full critical damage and effects from the attack, including effects that apply on a critical hit, and have your ally take no damage and avoid the attack's effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("84352d45-da4b-4690-a930-6ec889174dcd"), Feats.Instances.ShoulderCatastrophe.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c906f9b4-651c-4f1e-8791-40fcd8e797a2"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
