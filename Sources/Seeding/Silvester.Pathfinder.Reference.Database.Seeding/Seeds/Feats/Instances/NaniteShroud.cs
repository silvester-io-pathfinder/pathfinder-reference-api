using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NaniteShroud : Template
    {
        public static readonly Guid ID = Guid.Parse("5cc75ac8-ec85-4a47-a7c2-59c19d1319c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nanite Shroud",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0c07f703-bc46-46f0-a87e-5358a0fbe180"), Type = TextBlockType.Text, Text = "Your nanites fly out of your body, swarming around you in a cloud. You become concealed for a number of rounds equal to half your level. You can’t use this concealment to (action: Hide) or (action: Sneak), as normal for concealment that makes your position obvious. While Nanite Shroud is active, you can’t use other abilities that require the use of your nanites." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4c03b9c-e760-42d4-b71d-8704317c3b4e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}