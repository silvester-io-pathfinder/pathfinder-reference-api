using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AvatarsAudience : Template
    {
        public static readonly Guid ID = Guid.Parse("4a4e4f16-5166-4aef-ab3b-281e80727130");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Avatar's Audience",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("045b6277-ce95-4672-bff3-448ad3913183"), Type = TextBlockType.Text, Text = $"Your extensive service has made you a lesser herald of your deity, which affords you certain privileges." };
            yield return new TextBlock { Id = Guid.Parse("dd27935f-8d67-40aa-b302-7d8aee8f3ae8"), Type = TextBlockType.Text, Text = $"First, any creature you encounter knows instinctively that you speak for your deity." };
            yield return new TextBlock { Id = Guid.Parse("1bd7f925-f27a-403d-8b37-cef6a6f738a7"), Type = TextBlockType.Text, Text = $"Second, if you conduct the commune ritual to contact your deity, you don't have to pay any cost and you automatically get a critical success." };
            yield return new TextBlock { Id = Guid.Parse("d73950a7-4252-4d0a-bcdf-b980645d0d6d"), Type = TextBlockType.Text, Text = $"Third, once per day, you can cast {ToMarkdownLink<Models.Entities.Spell>("plane shift", Spells.Instances.PlaneShift.ID)} as a divine innate spell, but only to travel to the realm of your deity. When you cast it this way, its casting time is 1 minute, your religious symbol is a sufficient tuning fork for this spell, and you appear exactly where you want to be. If you're in your deity's realm due to this spell, you can return to the point you left when you cast it by spending a single action, which has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} and {ToMarkdownLink<Models.Entities.Trait>("divine", Traits.Instances.Divine.ID)} traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42af16e1-425d-4b19-b962-5b4e4b7c8159"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
