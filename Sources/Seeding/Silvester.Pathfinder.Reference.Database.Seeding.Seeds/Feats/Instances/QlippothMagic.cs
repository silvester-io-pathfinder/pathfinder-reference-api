using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QlippothMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("a7ee2f60-961a-4107-99c3-2f745490184d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Qlippoth Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("610bf938-cd16-45f4-a8b4-16d5930ae590"), Type = TextBlockType.Text, Text = $"You've deeply studied the secrets of your blood and can force reality to act against its own wishes. You can cast {ToMarkdownLink<Models.Entities.Spell>("blur", Spells.Instances.Blur.ID)} and {ToMarkdownLink<Models.Entities.Spell>("silence", Spells.Instances.Silence.ID)} once per day each as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2d415af3-ecf4-4bdd-af2a-e814a2f873c3"), Feats.Instances.Riftmarked.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e6f6e8a-39cb-47e0-be33-7bb3abb11288"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
