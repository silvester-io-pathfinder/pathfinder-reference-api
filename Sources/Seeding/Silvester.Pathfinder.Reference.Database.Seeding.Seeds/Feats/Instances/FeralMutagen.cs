using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeralMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("94510e56-dadc-4a14-9f4e-571a0354c8cd");

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
            yield return new TextBlock { Id = Guid.Parse("2c93a3fb-e08c-4e52-95e4-83f84eb6b56c"), Type = TextBlockType.Text, Text = $"Your bestial mutagen brings out the beast lurking within you, granting you especially sharp claws and teeth as well as a ferocious appearance. Whenever you're affected by a bestial mutagen, you gain the mutagen's item bonus to your Intimidation checks. In addition, your claws and jaws are increasingly vicious, and they gain the {ToMarkdownLink<Models.Entities.Trait>("deadly", Traits.Instances.Deadly.ID)} d10 trait. Finally, you can increase the mutagen's penalty to AC from -1 to -2 and, in exchange, increase the damage die size of your claws and jaws by one step." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b4e4aee-9e52-4273-aab4-2d344cde019e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
