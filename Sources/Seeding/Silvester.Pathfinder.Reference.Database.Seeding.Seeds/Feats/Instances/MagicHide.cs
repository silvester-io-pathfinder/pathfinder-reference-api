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
    public class MagicHide : Template
    {
        public static readonly Guid ID = Guid.Parse("6e960764-ba6a-4b72-a95c-783297355f3f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magic Hide",
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
            yield return new TextBlock { Id = Guid.Parse("ea2f65dc-c870-4c04-ab4f-51da1d56d128"), Type = TextBlockType.Text, Text = $"You can defend your companion in battle. You gain the {ToMarkdownLink<Models.Entities.Spell>("magic hide", Spells.Instances.MagicHide.ID)} warden spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAnimalCompanionAmount(Guid.Parse("49f06962-01bc-408e-95fc-01fe39c11919"), Comparator.GreaterThanOrEqualTo, amount: 1);
            builder.HaveSpecificClass(Guid.Parse("9b1b7975-55a2-486e-b9d3-b3ece9a038da"), Classes.Instances.Ranger.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("b5dbcf60-b397-4bd1-9514-0849f3a304b7"), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c56d086-2b72-448e-9d8b-33296b4495de"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
