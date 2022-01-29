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
    public class CatfolkDance : Template
    {
        public static readonly Guid ID = Guid.Parse("ab571c17-5295-4400-bbf6-bd49daa3b445");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catfolk Dance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("774b0898-4e65-4acb-9c7b-e82ce9af03d6"), Type = TextBlockType.Text, Text = $"You have a habit of always being in the way when other creatures attempt to move. Attempt an Acrobatics check against an adjacent creature's Reflex DC." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c8818540-394f-482a-9a1f-99495db8d0f6"), Traits.Instances.Catfolk.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("6e1b14bb-af13-46cb-b5f9-f1c8162fea64"),
                CriticalSuccess = "The target creature gains a –2 circumstance penalty to Reflex saves and is flat-footed until the start of your next turn.",
                Success = "The target creature gains a –2 circumstance penalty to Reflex saves until the start of your next turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("352cfd39-771f-45ac-a77e-44903a4c959f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
