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
    public class Woodcraft : Template
    {
        public static readonly Guid ID = Guid.Parse("b8d6e33f-3541-4fec-8221-85783f874a57");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Woodcraft",
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
            yield return new TextBlock { Id = Guid.Parse("f646340e-df3c-4709-950a-c033a5af0634"), Type = TextBlockType.Text, Text = $"You have a innate familiarity with forested areas. When in a forest or jungle environment, if you roll a critical failure on a Survival skill check to {ToMarkdownLink<Models.Entities.SkillAction>("Sense Direction", SkillActions.Instances.SenseDirection.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Subsist", SkillActions.Instances.Subsist.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Cover Tracks", SkillActions.Instances.CoverTracks.ID)}, you get a failure instead, and if you roll a success, you get a critical success instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4818af53-b6dc-475a-865d-9acc37a9b143"), Traits.Instances.Elf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0550a864-aaf2-43cd-a361-ad36d308cabc"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
