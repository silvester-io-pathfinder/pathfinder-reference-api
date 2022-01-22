using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IncredibleLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("9d9a0d83-91f4-43d3-bc56-ceb1fdb1aafb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Luck",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82ee093f-f8fb-469f-867b-881a198a39dd"), Type = TextBlockType.Text, Text = $"Even other halflings consider you to be particularly lucky. You can use {ToMarkdownLink<Models.Entities.Feat>("Halfling Luck", Feats.Instances.HalflingLuck.ID)} once per hour, rather than once per day. If you have {ToMarkdownLink<Models.Entities.Feat>("Guiding Luck", Feats.Instances.GuidingLuck.ID)}, you can still use {ToMarkdownLink<Models.Entities.Feat>("Halfling Luck", Feats.Instances.HalflingLuck.ID)} when you fail a Perception check or attack roll only once per day (though you can use it within the same hour that you used {ToMarkdownLink<Models.Entities.Feat>("Halfling Luck", Feats.Instances.HalflingLuck.ID)}), and if you have {ToMarkdownLink<Models.Entities.Feat>("Helpful Halfling", Feats.Instances.HelpfulHalfling.ID)}, you can still use {ToMarkdownLink<Models.Entities.Feat>("Halfling Luck", Feats.Instances.HalflingLuck.ID)} on an ally instead of yourself only once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6cd63961-3201-43ea-886c-84dc319a0666"), Feats.Instances.HalflingLuck.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ed01a0e-bb14-4818-bdbf-bc36079acba0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
