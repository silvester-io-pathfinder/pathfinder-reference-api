using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeralMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("86376929-c4e7-4fc3-b869-24599873afb5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Feral Mutagen",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("02f357d9-c54f-4dd4-bd12-a54bdb046479"), Type = TextBlockType.Text, Text = "Your bestial mutagen brings out the beast lurking within you, granting you especially sharp claws and teeth as well as a ferocious appearance. Whenever you’re affected by a bestial mutagen, you gain the mutagen’s item bonus to your Intimidation checks. In addition, your claws and jaws are increasingly vicious, and they gain the (trait: deadly d10) trait. Finally, you can increase the mutagen’s penalty to AC from -1 to -2 and, in exchange, increase the damage die size of your claws and jaws by one step." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30adaecc-f8c2-4429-9d1c-9de983d14d28"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
