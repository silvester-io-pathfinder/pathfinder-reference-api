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
    public class PerfectKiAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("05676747-1f88-4241-8551-dab25e8708f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfect Ki Adept",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ca865b0-3051-4cd0-8ac3-88e6eff61dd9"), Type = TextBlockType.Text, Text = $"You gain the appropriate ki spell for your School of Perfection:" };
            yield return new TextBlock { Id = Guid.Parse("8cd98bfe-9376-4682-9317-f74e26fca7f3"), Type = TextBlockType.Enumeration, Text = $" : {ToMarkdownLink<Models.Entities.Spell>("Unblinking flame revelation", Spells.Instances.UnblinkingFlameRevelation.ID)} for Unblinking Flame" };
            yield return new TextBlock { Id = Guid.Parse("babcd113-b9e9-43bf-aa01-c171ac5956a0"), Type = TextBlockType.Enumeration, Text = $" : {ToMarkdownLink<Models.Entities.Spell>("Unbreaking wave advance", Spells.Instances.UnbreakingWaveAdvance.ID)} for Unbreaking Waves" };
            yield return new TextBlock { Id = Guid.Parse("3ff4e142-4f3a-4e98-8074-00fafecce4d8"), Type = TextBlockType.Enumeration, Text = $" : {ToMarkdownLink<Models.Entities.Spell>("Unfolding wind rush", Spells.Instances.UnfoldingWindRush.ID)} for Unfolding Wind" };
            yield return new TextBlock { Id = Guid.Parse("3fa0c9cf-ff9a-4f27-af66-72c004e9a3bb"), Type = TextBlockType.Enumeration, Text = $" : {ToMarkdownLink<Models.Entities.Spell>("Untwisting iron buffer", Spells.Instances.UntwistingIronBuffer.ID)} for Untwisting Iron" };
            yield return new TextBlock { Id = Guid.Parse("2198fdc2-7d75-468c-850f-92d307ed9a3c"), Type = TextBlockType.Text, Text = $"Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("452faa2d-aad7-4111-b83b-aafc99f741a8"), Feats.Instances.StudentOfPerfectionDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18ca8d89-1ed4-422b-a7c3-bcaa29d28e44"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
