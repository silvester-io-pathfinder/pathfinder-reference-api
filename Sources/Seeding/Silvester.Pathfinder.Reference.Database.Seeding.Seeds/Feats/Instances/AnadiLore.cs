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
    public class AnadiLore : Template
    {
        public static readonly Guid ID = Guid.Parse("4a378ab7-fefa-4414-b73f-bfbdad51cfa0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anadi Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7bf3e595-85f4-4f91-b432-29a271d57532"), Type = TextBlockType.Text, Text = $"You've learned how to provide for your community, be it through hard-earned sustenance or useful crafts. You gain the trained proficiency rank in Crafting and Survival. If you would automatically become trained in one of those skills (from your background or class, for example), you become trained in a skill of your choice. You also become trained in Anadi Lore." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4b882391-e9ae-4a16-8350-78f0889b6508"), Traits.Instances.Anadi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d780886-889f-4ad7-beea-ff44346aee7d"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
