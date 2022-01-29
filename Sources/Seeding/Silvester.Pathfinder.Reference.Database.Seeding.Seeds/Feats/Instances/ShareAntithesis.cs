using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShareAntithesis : Template
    {
        public static readonly Guid ID = Guid.Parse("1622d590-c5f2-4a1c-ac00-c653c35cc919");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Share Antithesis",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86d4e976-7881-45a8-9fda-d08a151b5483"), Type = TextBlockType.Text, Text = $"You apply esoterica to an adjacent ally's weapons and body. That ally's {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} apply the weakness of the subject of your esoterica the same way your {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} do. This benefit ends when {ToMarkdownLink<Models.Entities.Feat>("Esoteric Antithesis", Feats.Instances.EsotericAntithesis.ID)} ends or you Share Antithesis again. You can't share a custom weakness you created with {ToMarkdownLink<Models.Entities.Feat>("Esoteric Antithesis", Feats.Instances.EsotericAntithesis.ID)}, only a weakness the creature has normally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cc8428f9-e798-47e0-ba35-200c959a0214"), Feats.Instances.EsotericAntithesis.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6aa7ccd6-174a-490c-99d9-9e8ab882c6f2"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
