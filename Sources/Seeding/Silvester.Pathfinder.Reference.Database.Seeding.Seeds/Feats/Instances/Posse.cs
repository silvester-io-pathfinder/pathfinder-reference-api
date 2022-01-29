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
    public class Posse : Template
    {
        public static readonly Guid ID = Guid.Parse("1414c5a7-138c-49e7-be59-4478b80684c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Posse",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a4cc430-f5b1-4f61-bbd2-c85d54129b64"), Type = TextBlockType.Text, Text = $"By spending 1 minute giving guidance to help hunt down your prey, you instruct up to five willing creatures to assist you. They gain a +1 circumstance bonus to {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} your prey, to {ToMarkdownLink<Models.Entities.SkillAction>("Track", SkillActions.Instances.Track.ID)} your prey, and to {ToMarkdownLink<Models.Entities.SkillAction>("Gather Information", SkillActions.Instances.GatherInformation.ID)} about your prey. You and the creatures assisting you gain a +1 circumstance bonus to initiative rolls when entering combat with your prey." };
            yield return new TextBlock { Id = Guid.Parse("e3eb8258-cf81-492a-b536-292e14d423f4"), Type = TextBlockType.Text, Text = $"This benefit lasts until you designate a new prey or your prey dies, whichever comes first. An individual creature assisting you loses this benefit if they're out of your presence for too long to benefit from your instructions. This is usually 1 hour, but is determined by the GM." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4638931b-0168-44a1-bd5e-b93ae4e41ee2"), Feats.Instances.BountyHunterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c08b998-3b54-4be4-8e5a-9436a3670b5f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
